using StructuredProductMonograph.Helpers;
using StructuredProductMonograph.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Xml.Linq;

namespace StructuredProductMonograph.Controller
{
    public class spmController
    {
        static readonly ISectionRepository secPlaceholder = new SectionRepository();
        static readonly IComponentRepository comPlaceholder = new ComponentRepository();

        public Section createSection(CodeEnum code, string text, bool allowText, int subSectionLevel)
        {
            var section = secPlaceholder.CreateSection(code, text, allowText, subSectionLevel);
            if (section == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return section;
        }
        public Section createSectionForDropdown(string code, string displayName, string codeSystem, int subSectionLevel)
        {
            var section = secPlaceholder.CreateSectionForDropdown(code, displayName, codeSystem, subSectionLevel);
            if (section == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return section;
        }
        public void createComponentBySection(CodeEnum code, string text, bool allowText, int subSectionLevel)
        {
            var section = createSection(code, text, allowText, subSectionLevel);
            if (section == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                comPlaceholder.CreateComponent(section);
            }
        }
        public void createComponentBySectionList(CodeEnum codeName, Dictionary<string, string> dict)
        {
            var mainSection = new Section();
            var codeStyem = string.Empty;
            switch (codeName)
            {
                case CodeEnum.SchedulingSymbol:
                    codeStyem = Constants.oid_SchedulingSymbol;
                    break;
                case CodeEnum.PharmaceuticalStandard:
                    codeStyem = Constants.oid_PharmaceuticalStandard;
                    break;
                case CodeEnum.TherapeuticClassification:
                    codeStyem = Constants.oid_TherapeuticClassification;
                    break;
                default:
                    break;
            }
            mainSection = createSection(codeName, string.Empty, false, 0);
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                var firstSection = new Section();
                firstSection = createSectionForDropdown(kvp.Key, kvp.Value, codeStyem, 1);
                mainSection.subSectionList.Add(firstSection);
            }
            if (mainSection != null)
            {
                comPlaceholder.CreateComponent(mainSection);
                saveXMLToSession(SessionHelper.current.saveForm);
            }

        }

        public void createComponentBySectionList(CodeEnum codeName, List<Dictionary<CodeEnum, string>> list)
        {
            var mainSection = new Section();
            switch (codeName)
            {
                case CodeEnum.PharmaceuticalInformation:
                    foreach (var item in list)
                    {
                        var firstSection = new Section();
                        foreach (KeyValuePair<CodeEnum, string> kvp in item)
                        {
                            if (kvp.Key == CodeEnum.PharmaceuticalInformation)
                            {
                                if (mainSection.code == null)
                                {
                                    mainSection = createSection(CodeEnum.PharmaceuticalInformation, kvp.Value, true, 0);
                                }
                            }
                            else
                            {
                                switch (kvp.Key)
                                {
                                    case CodeEnum.DrugSubstance:
                                        firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                        break;
                                    case CodeEnum.DrugProperName:
                                    case CodeEnum.ChemicalName:
                                    case CodeEnum.MolecularFormulaAndMolecularMass:
                                    case CodeEnum.StructuralformulaIncludingrelative:
                                    case CodeEnum.PhysicochemicalProperties:
                                        if (firstSection == null)
                                        {
                                            firstSection = createSection(CodeEnum.DrugSubstance, kvp.Value, true, 1);
                                            mainSection.subSectionList.Add(firstSection);
                                        }
                                        if (firstSection != null && firstSection.subSectionList != null)
                                        {
                                            var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                            firstSection.subSectionList.Add(secondSection);
                                        }
                                        break;
                                    default:
                                        firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                        break;
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            if (mainSection != null)
            {
                comPlaceholder.CreateComponent(mainSection);
                saveXMLToSession(SessionHelper.current.saveForm);
            }
        }
        
        public void createComponentBySectionList(CodeEnum codeName, Dictionary<CodeEnum, string> dict)
        {
            var mainSection = new Section();
            switch (codeName)
            {
                case CodeEnum.AdverseReactions:
                case CodeEnum.DrugInteractions:
                case CodeEnum.AboutThisMedication:
                case CodeEnum.ProperUseOfThisMedication:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        switch (kvp.Key)
                        {
                            case CodeEnum.AdverseReactions:
                            case CodeEnum.DrugInteractions:
                            case CodeEnum.AboutThisMedication:
                            case CodeEnum.ProperUseOfThisMedication:
                                mainSection = createSection(kvp.Key, kvp.Value, true, 0);
                                break;
                            default:
                                firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                mainSection.subSectionList.Add(firstSection);
                                break;
                        }
                    }
                    break;               
                case CodeEnum.DosageAndAdministration:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        if (kvp.Key == CodeEnum.DosageAndAdministration)
                        {
                            mainSection = createSection(CodeEnum.DosageAndAdministration, kvp.Value, true, 0);
                        }
                        else
                        {
                            if (kvp.Key == CodeEnum.OralSolutions || kvp.Key == CodeEnum.ParenteralProducts)
                            {
                                firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.Reconstitution].Code).FirstOrDefault();
                                if( firstSection == null )
                                {
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                }
                                if ( firstSection != null && firstSection.subSectionList != null )
                                {
                                    var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                    firstSection.subSectionList.Add(secondSection);
                                }
                            }
                            else
                            {
                                firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                mainSection.subSectionList.Add(firstSection);
                            }
                        }
                    }
                    break;
               case CodeEnum.IndicationsAndClinicalUse:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        if (kvp.Key == CodeEnum.IndicationsAndClinicalUse)
                        {
                            mainSection = createSection(CodeEnum.IndicationsAndClinicalUse, kvp.Value, true, 0);
                        }
                        else
                        {
                            if (kvp.Key == CodeEnum.Geriatrics || kvp.Key == CodeEnum.Pediatrics)
                            {
                                firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.PatientSubsets].Code).FirstOrDefault();
                                if (firstSection == null)
                                {
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                }
                                if (firstSection != null && firstSection.subSectionList != null)
                                {
                                    var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                    firstSection.subSectionList.Add(secondSection);
                                }
                            }
                            else
                            {
                                firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                mainSection.subSectionList.Add(firstSection);
                            }
                        }
                    }
                    break;                 
              case CodeEnum.WarningsAndPrecautions:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        if (kvp.Key == CodeEnum.WarningsAndPrecautions)
                        {
                            mainSection = createSection(CodeEnum.WarningsAndPrecautions, kvp.Value, true, 0);
                        }
                        else
                        {
                            switch (kvp.Key)
                            {
                                case CodeEnum.SpecialPopulations:
                                    firstSection = createSection(kvp.Key, string.Empty, false, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                                case CodeEnum.PregnantWomen:
                                case CodeEnum.NursingWomen:
                                case CodeEnum.SpecialPopulationsGeriatrics:
                                case CodeEnum.SpecialPopulationsPediatrics:
                                    firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.SpecialPopulations].Code).FirstOrDefault();
                                    if (firstSection == null)
                                    {
                                        firstSection = createSection(CodeEnum.SpecialPopulations, string.Empty, false, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                    }
                                    if (firstSection != null && firstSection.subSectionList != null)
                                    {
                                        var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                        firstSection.subSectionList.Add(secondSection);
                                    }
                                    break;
                                case CodeEnum.SpecialPopulationsMisc:                                   
                                    var tempKeys = kvp.Value.Split(new char[] { '|' });
                                    if(tempKeys.Length > 0)
                                    {
                                        foreach( var key in tempKeys)
                                        {
                                            firstSection = new Section();
                                            var tempValues = key.Split(new char[] { ':' });
                                            if(tempValues.Length > 0)
                                            {
                                                var codeElement = new Code();
                                                firstSection.sectionID = Guid.NewGuid().ToString().ToLower();
                                                firstSection.rootID = mainSection.sectionID;
                                                codeElement.code = CodeCollection.codes[CodeEnum.SpecialPopulationsMisc].Code;
                                                codeElement.displayName = CodeCollection.codes[CodeEnum.SpecialPopulationsMisc].DisplayName;
                                                codeElement.codeSystem = Constants.oid_SectionIdentifier;
                                                firstSection.allowText = true;
                                                firstSection.allowTitle = true;
                                                firstSection.title = tempValues[0];
                                                firstSection.subSectionLevel = 1;
                                                firstSection.text = tempValues[1];
                                                firstSection.effectiveTime = UtilityHelper.TodayDate;
                                                firstSection.code = codeElement;
                                                mainSection.subSectionList.Add(firstSection);
                                            }
                                        }
                                    }                                                                                  
                                    break;
                                default:
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                            }                            
                        }
                    }
                    break;
                case CodeEnum.ClinicalTrials:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        if (kvp.Key == CodeEnum.ClinicalTrials)
                        {
                            mainSection = createSection(CodeEnum.ClinicalTrials, kvp.Value, true, 0);
                        }
                        else
                        {
                            if (kvp.Key == CodeEnum.StudyDemographicsAndTrialDesign || kvp.Key == CodeEnum.StudyResults)
                            {
                                firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.EfficacyandSafetyStudies].Code).FirstOrDefault();
                                if (firstSection == null)
                                {
                                    firstSection = createSection(CodeEnum.EfficacyandSafetyStudies, string.Empty, true, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                }
                                if (firstSection != null && firstSection.subSectionList != null)
                                {
                                    var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                    firstSection.subSectionList.Add(secondSection);
                                }
                            }
                            else
                            {
                                firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                mainSection.subSectionList.Add(firstSection);
                            }
                        }
                    }
                    break;
                case CodeEnum.ActionAndClinicalPharmacology:
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        var secondSection = new Section();
                        if (kvp.Key == CodeEnum.ActionAndClinicalPharmacology)
                        {
                            mainSection = createSection(CodeEnum.ActionAndClinicalPharmacology, kvp.Value, true, 0);
                        }
                        else
                        {
                            switch (kvp.Key)
                            {
                                case CodeEnum.Pharmacokinetics:
                                    firstSection = createSection(kvp.Key, string.Empty, false, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                                case CodeEnum.Absorption:
                                case CodeEnum.Distribution:
                                case CodeEnum.Metabolism:
                                case CodeEnum.Excretion:
                                case CodeEnum.SpecialPopulationsAndConditions:
                                    firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.Pharmacokinetics].Code).FirstOrDefault();
                                    if (firstSection == null)
                                    {
                                        firstSection = createSection(CodeEnum.Pharmacokinetics, string.Empty, false, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                    }
                                    if (firstSection != null && firstSection.subSectionList != null)
                                    {
                                        if( kvp.Key == CodeEnum.SpecialPopulationsAndConditions)
                                        {
                                            secondSection = createSection(CodeEnum.SpecialPopulationsAndConditions, string.Empty, false, 2);
                                        }
                                        else
                                        {
                                            secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                        }
                                        firstSection.subSectionList.Add(secondSection);
                                    }
                                    break;
                                case CodeEnum.ActionAndClinicalPediatrics:
                                case CodeEnum.ActionAndClinicalGeriatrics:
                                case CodeEnum.Gender:
                                case CodeEnum.Race:
                                case CodeEnum.HepaticInsufficiency:
                                case CodeEnum.RenalInsufficiency:
                                case CodeEnum.GeneticPolymorphism:
                                    firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.Pharmacokinetics].Code).FirstOrDefault();
                                    if (firstSection == null)
                                    {
                                        firstSection = createSection(CodeEnum.Pharmacokinetics, string.Empty, false, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                    }
                                    if (firstSection != null && firstSection.subSectionList != null)
                                    {
                                        secondSection = firstSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.SpecialPopulationsAndConditions].Code).FirstOrDefault();
                                        if (secondSection == null)
                                        {
                                            secondSection = createSection(CodeEnum.SpecialPopulationsAndConditions, string.Empty, false, 2);
                                            firstSection.subSectionList.Add(secondSection);
                                        }
                                        if (secondSection != null && secondSection.subSectionList != null)
                                        {
                                            var thirdSection = createSection(kvp.Key, kvp.Value, true, 3);
                                            secondSection.subSectionList.Add(thirdSection);
                                        }
                                    }                                    
                                    break;
                                default:
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                            }
                        }
                    }
                    break;
                case CodeEnum.PharmaceuticalInformation:                    
                    foreach (KeyValuePair<CodeEnum, string> kvp in dict)
                    {
                        var firstSection = new Section();
                        if (kvp.Key == CodeEnum.PharmaceuticalInformation)
                        {
                            mainSection = createSection(CodeEnum.PharmaceuticalInformation, kvp.Value, true, 0);
                        }
                        else
                        {
                            switch (kvp.Key)
                            {
                                case CodeEnum.DrugSubstance:
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                                case CodeEnum.DrugProperName:
                                case CodeEnum.ChemicalName:
                                case CodeEnum.MolecularFormulaAndMolecularMass:
                                case CodeEnum.StructuralformulaIncludingrelative:
                                case CodeEnum.PhysicochemicalProperties:
                                    firstSection = mainSection.subSectionList.Where(x => x.code.code == CodeCollection.codes[CodeEnum.DrugSubstance].Code).FirstOrDefault();
                                    if (firstSection == null)
                                    {
                                        firstSection = createSection(CodeEnum.DrugSubstance, kvp.Value, true, 1);
                                        mainSection.subSectionList.Add(firstSection);
                                    }
                                    if (firstSection != null && firstSection.subSectionList != null)
                                    {
                                        var secondSection = createSection(kvp.Key, kvp.Value, true, 2);
                                        firstSection.subSectionList.Add(secondSection);
                                    }
                                    break;
                                default:
                                    firstSection = createSection(kvp.Key, kvp.Value, true, 1);
                                    mainSection.subSectionList.Add(firstSection);
                                    break;
                            }
                        }
                    }
                    break;
                default:                  
                    break;
            }

            
            if (mainSection != null)
            {
                comPlaceholder.CreateComponent(mainSection);
                saveXMLToSession(SessionHelper.current.saveForm);
            }
        }
        
        public void createAuthor(List<Author> items)
        {
            comPlaceholder.CreateAddress(items);
            saveXMLToSession(SessionHelper.current.saveForm);
        }

        private void saveXMLToSession(XDocument document)
        {

            foreach (XElement childElement in
                           from x in document.DescendantNodes().OfType<XElement>()
                           where x.IsEmpty
                           select x)
            {
                childElement.Value = "";
            }
            SessionHelper.current.saveForm = document;
        }

    }
}