using System;
using StructuredProductMonograph.Helpers;
using System.Collections.Generic;

namespace StructuredProductMonograph.Models
{

    public class SectionRepository : ISectionRepository
    {
        public Section CreateSection(CodeEnum codeEnum, string text, bool allowText, int subSectionLevel)
        {
            var psComp = new Section();
            psComp.subSectionList = new List<Section>();
            var code = new Code();
            code.code  = CodeCollection.codes[codeEnum].Code;
            psComp.allowText = allowText;
            psComp.allowTitle = true;
            psComp.subSectionLevel = subSectionLevel;
            switch (code.code)
            {
                case "000":
                    code.codeSystem = Constants.oid_SectionIdentifier;
                    code.displayName = Resources.Resource.title_SubmissionControlNumber;
                    psComp.title = Resources.Resource.title_SubmissionControlNumber;
                    break;
                default:
                    code.codeSystem = Constants.oid_SectionIdentifier;
                    code.displayName = CodeCollection.codes[codeEnum].DisplayName;
                    psComp.title = CodeCollection.codes[codeEnum].DisplayName;
                    break;                    
            }
            psComp.rootID = SessionHelper.current.xmlFileGuid;
            psComp.text = text;          
            psComp.code = code;
            psComp.sectionID = Guid.NewGuid().ToString().ToLower();
            psComp.effectiveTime = UtilityHelper.TodayDate;
            return psComp;
        }

        public Section CreateSectionForDropdown(string code, string displayName, string codeSystem, int subSectionLevel)
        {
            var psComp = new Section();
            psComp.subSectionList = new List<Section>();
            var codeElement = new Code();
            psComp.sectionID = Guid.NewGuid().ToString().ToLower();
            psComp.rootID = SessionHelper.current.xmlFileGuid;
            codeElement.code = code;
            psComp.allowText = false;
            psComp.allowTitle = false;
            psComp.title = string.Empty;
            psComp.subSectionLevel = subSectionLevel;
            psComp.text = string.Empty;
            psComp.effectiveTime = UtilityHelper.TodayDate;
            switch (codeElement.code)
            {
                case "000":
                    codeElement.codeSystem = codeSystem;
                    codeElement.displayName = displayName;
                    break;
                default:
                    codeElement.codeSystem = codeSystem;
                    codeElement.displayName = displayName;
                    break;
            }
            psComp.code = codeElement;
            return psComp;
        }
    }
}