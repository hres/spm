using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Xml;
using System.Drawing;
using System.ComponentModel;
using System.Xml.Linq;
using System.Collections;
using StructuredProductMonograph.Helpers;
using StructuredProductMonograph.Controller;
using System.Text;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using StructuredProductMonograph.Models;
using System.Collections.Specialized;

namespace StructuredProductMonograph
{
    public partial class titlePage : BasePage
    {
        string strscript = string.Empty;
        protected static string datePreparation;
        protected static string brandNameTitle;
        protected static string properNameTitle;
        protected static string addButton;
        protected static string removeButton;
        protected static string resetButton;
        protected static string existXmlFile;
        protected static string brandNameHidden;
        //bool isClientLoadXML = false;
        
        private XDocument document  = new XDocument();
        private spmController controller = new spmController();
        private string rootID = string.Empty;
        private SPLControlledVocabulary psCV = new SPLControlledVocabulary();
        private SPLControlledVocabulary tcCV = new SPLControlledVocabulary();
        private SPLControlledVocabulary wpCV = new SPLControlledVocabulary();
        private SPLControlledVocabulary spCV = new SPLControlledVocabulary();
        private SPLControlledVocabulary pkCV = new SPLControlledVocabulary();
        private SPLControlledVocabulary spcCV = new SPLControlledVocabulary();
        protected void Page_PreRender(object sender, EventArgs e)
        {
            //var savedXMLstring = string.Concat(SessionHelper.Current.saveForm.Declaration.ToString(), "\r\n", SessionHelper.Current.saveForm.ToString());
            //this.savedXml.Text = savedXMLstring;
        }

        #region Browser Refresh
        //private bool refreshState;
        //private bool isRefresh;

        //protected override void LoadViewState(object savedState)
        //{
        //    object[] AllStates = (object[])savedState;
        //    base.LoadViewState(AllStates[0]);
        //    refreshState = bool.Parse(AllStates[1].ToString());
        //    if (Session["ISREFRESH"] != null)
        //        isRefresh = (refreshState == (bool)Session["ISREFRESH"]);
        //}

        //protected override object SaveViewState()
        //{
        //    Session["ISREFRESH"] = refreshState;
        //    object[] AllStates = new object[3];
        //    AllStates[0] = base.SaveViewState();
        //    AllStates[1] = !(refreshState);
        //    return AllStates;
        //}
        #endregion



        protected void Page_Load(object sender, EventArgs e)
        {
            rootID = SessionHelper.current.xmlFileGuid;
            
            if (!IsPostBack)
            {
                brandNameTitle = Resources.Resource.brandNameTitle;
                properNameTitle = Resources.Resource.properNameTitle;               
                addButton = Resources.Resource.addButton;
                removeButton = Resources.Resource.removeButton;
                btnSaveDraft.Text = Resources.Resource.saveButton;
                btnSaveDraft.Attributes["Title"] = Resources.Resource.saveButtonTitle;
                resetButton = Resources.Resource.resetButton;
                try
                {
                    if (SessionHelper.current.saveForm != null)
                    {
                        document = SessionHelper.current.saveForm;
                    }
                    //LoadFromXML();
                    if (SessionHelper.current.saveForm != null)
                    {
                        //savedXml.Text = string.Concat(SessionHelper.Current.saveForm.Declaration.ToString(), "\r\n", SessionHelper.Current.saveForm.ToString());
                    }
                   // XmlDocument xmldoc = SessionHelper.Current.draftForm;

                    if (string.IsNullOrEmpty(SessionHelper.current.brandName))
                    {
                        brandNameHidden = string.Empty;
                    }
                    else
                    {
                        //this.brandName.Text = SessionHelper.Current.brandName;
                        brandNameHidden = SessionHelper.current.brandName;
                    }
                    if (!string.IsNullOrEmpty(SessionHelper.current.properName))
                    {
                        //this.properName.Text = SessionHelper.Current.properName;
                    }
                    existXmlFile = SessionHelper.current.existXmlFile.ToString();
                }
                catch
                {

                }
            }
            BindControlledVocaluraryList();
        }
        protected void btnViewXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessionHelper.current.fileSaved)
                {
                    
                }
                else
                {
                    SaveDraftForm();
                }
                if (SessionHelper.current.saveForm != null)
                {
                    var savedXMLstring = string.Concat(SessionHelper.current.saveForm.Declaration.ToString(), "\r\n", SessionHelper.current.saveForm.ToString());
                   // this.savedXml.Text = string.Format("<pre><![CDATA[{0}]]></pre>", savedXMLstring); 
                    //this.xmlOutput.InnerText = string.Format("<pre><![CDATA[{0}]]></pre>", savedXMLstring);
                    this.xmlOutput.InnerText = savedXMLstring;
                    ////string strscript = "$('#saveTextXml').html(\"" + savedXMLstring + "\");";
                    //string strscript = "$('#saveTextXml').html(\"aaaa\");";
                    //ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "LoadEventsScript", savedXMLstring, true);
                    //var common = new Helpers.Common(SessionHelper.Current.xmlFileGuid);
                    //common.SaveXmlFile(SessionHelper.Current.saveForm);
                }
            }
            catch (System.Threading.ThreadAbortException thr)
            {
                var strMessage = string.Format("{0}-{1}", "Coverpage", "btnSaveDraft_Click");
                ExceptionHelper.LogException(thr, strMessage);
            }
            catch (Exception ex)
            {
                var strMessage = string.Format("{0}-{1}", "Coverpage", "btnSaveDraft_Click");
                ExceptionHelper.LogException(ex, strMessage);
            }
        }
        protected void btnSaveDraft_Click(object sender, EventArgs e)
        {
            try
            {
                //HttpContext.Current.Request.Form.GetValues("tbBrandName") != null
                //controller.createComponentByCode(CodeEnum.PharmaceuticalStandard, title.Text, true, false);

                // if (isRefresh == false)
                // {
                SaveDraftForm();
                if (SessionHelper.current.saveForm != null)
                {
                    //var savedXMLstring = string.Concat(SessionHelper.Current.saveForm.Declaration.ToString(), "\r\n", SessionHelper.Current.saveForm.ToString());
                    //this.savedXml.Text = savedXMLstring;
                    //string strscript = "$('#saveTextXml').html(\"" + savedXMLstring + "\");";
                    //string strscript = "$('#saveTextXml').html(\"aaaa\");";
                    //ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "LoadEventsScript", strscript, true);

                    if(!SessionHelper.current.fileSaved)
                    {
                        SessionHelper.current.fileSaved = true;
                    }
                    var common = new Helpers.Common(SessionHelper.current.xmlFileGuid);
                    common.SaveXmlFile(SessionHelper.current.saveForm);                  
                }
            }
            catch (System.Threading.ThreadAbortException thr)
            {
                var strMessage = string.Format("{0}-{1}", "titlePage", "btnSaveDraft_Click");
                ExceptionHelper.LogException(thr, strMessage);
            }
            catch (Exception ex)
            {
                var strMessage = string.Format("{0}-{1}", "titlePage", "btnSaveDraft_Click");
                ExceptionHelper.LogException(ex, strMessage);
            }
         }

        protected void BindControlledVocaluraryList()
        {
            if (SessionHelper.current.cvItems != null)
            {
                psCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.PharmaceuticalStandard].Code).FirstOrDefault();
                if (psCV != null)
                {
                    pharmaceuticalStandard.DataSource = psCV.cvList;
                    pharmaceuticalStandard.DataTextField = "name";
                    pharmaceuticalStandard.DataValueField = "code";
                    pharmaceuticalStandard.DataBind();
                    pharmaceuticalStandard.Items.Insert(0, new ListItem(string.Format("Select a {0}", psCV.name), string.Empty));
                }

                tcCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.TherapeuticClassification].Code).FirstOrDefault();
                if( tcCV !=  null )
                {
                    therapeuticClassification.DataSource = tcCV.cvList;
                    therapeuticClassification.DataTextField = "name";
                    therapeuticClassification.DataValueField = "code";
                    therapeuticClassification.DataBind();
                    therapeuticClassification.Items.Insert(0, new ListItem(string.Format("Select a {0}", tcCV.name), string.Empty));
                }

                wpCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.WarningsAndPrecautions].Code).FirstOrDefault();
                if( wpCV != null)
                {
                    warningsPrecautionsList0.DataSource = wpCV.cvList;
                    warningsPrecautionsList0.DataTextField = "name";
                    warningsPrecautionsList0.DataValueField = "code";
                    warningsPrecautionsList0.DataBind();
                    warningsPrecautionsList0.Items.Insert(0, new ListItem(string.Format("Select a {0}", wpCV.name), string.Empty));
                }

                spCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.SpecialPopulations].Code).FirstOrDefault();
                if (spCV != null)
                {
                    specialPopulationsList0.DataSource = spCV.cvList;
                    specialPopulationsList0.DataTextField = "name";
                    specialPopulationsList0.DataValueField = "code";
                    specialPopulationsList0.DataBind();
                    specialPopulationsList0.Items.Insert(0, new ListItem(string.Format("Select a {0}", spCV.name), string.Empty));
                }
                pkCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.Pharmacokinetics].Code).FirstOrDefault();
                if (pkCV != null)
                {
                    pharmacokineticsList0.DataSource = pkCV.cvList;
                    pharmacokineticsList0.DataTextField = "name";
                    pharmacokineticsList0.DataValueField = "code";
                    pharmacokineticsList0.DataBind();
                    pharmacokineticsList0.Items.Insert(0, new ListItem(string.Format("Select a {0}", pkCV.name), string.Empty));
                }
                spcCV = SessionHelper.current.cvItems.Where(x => x.id == CodeCollection.codes[CodeEnum.SpecialPopulationsAndConditions].Code).FirstOrDefault();
                if (spcCV != null)
                {
                    specialConditionsList0.DataSource = spcCV.cvList;
                    specialConditionsList0.DataTextField = "name";
                    specialConditionsList0.DataValueField = "code";
                    specialConditionsList0.DataBind();
                    specialConditionsList0.Items.Insert(0, new ListItem(string.Format("Select a {0}", spcCV.name), string.Empty));
                }
            }
        }

        protected void SaveDraftForm()
        {
            try
            {
                document = SessionHelper.current.saveForm;
                rootID = SessionHelper.current.xmlFileGuid;
                #region Title, Version, and Language
                var xmlns = XNamespace.Get("urn:hl7-org:v3");
                if (!string.IsNullOrWhiteSpace(this.title.Text))
                {
                    var title = document.Root.Descendants(xmlns + "title").FirstOrDefault();
                    if (title != null)
                    {
                        title.SetValue(this.title.Text);
                    }
                }
                if (!string.IsNullOrWhiteSpace(this.version.Text))
                {
                    var version = document.Root.Descendants(xmlns + "versionNumber").FirstOrDefault();
                    if (version != null)
                    {
                        version.SetValue(this.version.Text);
                    }
                }
                if (HttpContext.Current.Request.Form["language"] != null)
                {
                    var selectedLang = HttpContext.Current.Request.Form["language"];
                    var language = document.Root.Descendants(xmlns + "languageCode").FirstOrDefault();
                    if (language != null)
                    {
                        if (selectedLang.Equals("fra"))
                        {
                            language.Attribute("code").SetValue(selectedLang);
                            language.Attribute("displayName").SetValue("French");
                        }
                        else
                        {
                            language.Attribute("code").SetValue(selectedLang);
                            language.Attribute("displayName").SetValue("English");
                        }
                    }
                }
                this.xmlOutput.InnerText = UtilityHelper.ToStringWithDeclaration(document); 

                #region Author
                var items = new List<Author>();
                var item = new Author();
                item.isRrepresentedAddress = true;

                //Company ID(1.33)
                item.companyRoot = Constants.oid_companyRoot;
                if (string.IsNullOrWhiteSpace(this.comID.Text))
                {
                    item.companyExtension = "999999999";
                }
                else
                {
                    item.companyExtension = this.comID.Text;
                }
                //OrganizationRole(1.35)
                item.roleRoot = Constants.oid_roleRoot;
                item.roleExtension = "1";

                // var authorCode = new Code();
                //Sponsor registry(1.31)
                item.sponsorRoot = Constants.oid_sponsorRoot;
                if (HttpContext.Current.Request.Form["sponsorRegistry"] != null)
                {
                    var sponsorRegistry = HttpContext.Current.Request.Form["sponsorRegistry"];
                    if (string.IsNullOrWhiteSpace(sponsorRegistry))
                    {
                        item.sponsorExtension = "???";
                    }
                    else
                    {
                        item.sponsorExtension = sponsorRegistry;
                    }
                }
                else
                {
                    item.sponsorExtension = "???";
                }

                var address = new Address();
                address.companyName = this.comName.Text.Trim();
                address.street = this.street.Text.Trim();
                address.city = this.city.Text.Trim();
                address.province = this.province.Text.Trim();
                address.country = this.country.Text.Trim();
                address.postalCode = this.postalCode.Text.Trim();
                address.phone = string.Format("tel:+{0}", this.phone.Text.Trim());
                address.emailAdress = string.Format("mailto:{0}", this.email.Text.Trim());
                address.contactName = string.Format("{0}, {1}", this.firstName.Text.Trim(), this.lastName.Text.Trim());
                item.address = address;
                items.Add(item);

                if (HttpContext.Current.Request.Form.GetValues("agentComName") != null || HttpContext.Current.Request.Form.GetValues("agentComID") != null ||
                    HttpContext.Current.Request.Form.GetValues("agentOrganizationRole") != null || HttpContext.Current.Request.Form.GetValues("agentStreet") != null ||
                    HttpContext.Current.Request.Form.GetValues("agentCity") != null || HttpContext.Current.Request.Form.GetValues("agentProvince") != null ||
                    HttpContext.Current.Request.Form.GetValues("agentCountry") != null || HttpContext.Current.Request.Form.GetValues("agentPostalCode") != null ||
                    HttpContext.Current.Request.Form.GetValues("agentEmail") != null || HttpContext.Current.Request.Form.GetValues("agentPhone") != null ||
                    HttpContext.Current.Request.Form.GetValues("agentLastName") != null || HttpContext.Current.Request.Form.GetValues("agentFirstName") != null
                    )
                {
                    var comNameList = HttpContext.Current.Request.Form.GetValues("agentComName").ToList();
                    var comIDList = HttpContext.Current.Request.Form.GetValues("agentComID").ToList();
                    var organizationRoleList = HttpContext.Current.Request.Form.GetValues("agentOrganizationRole").ToList();
                    var streetList = HttpContext.Current.Request.Form.GetValues("agentStreet").ToList();
                    var cityList = HttpContext.Current.Request.Form.GetValues("agentCity").ToList();
                    var provinceList = HttpContext.Current.Request.Form.GetValues("agentProvince").ToList();
                    var countryList = HttpContext.Current.Request.Form.GetValues("agentCountry").ToList();
                    var postalCodeList = HttpContext.Current.Request.Form.GetValues("agentPostalCode").ToList();
                    var phoneList = HttpContext.Current.Request.Form.GetValues("agentEmail").ToList();
                    var emailList = HttpContext.Current.Request.Form.GetValues("agentPhone").ToList();
                    var firstNameList = HttpContext.Current.Request.Form.GetValues("agentFirstName").ToList();
                    var lastNameList = HttpContext.Current.Request.Form.GetValues("agentLastName").ToList();

                    if (comNameList.Count > 0)
                    {
                        for (int i = 0; i < comNameList.Count; i++)
                        {
                            var newItem = new Author();
                            var newAddress = new Address();

                            if (!string.IsNullOrWhiteSpace(comNameList[i].ToString().Trim()))
                            {
                                newAddress.companyName = comNameList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(streetList[i].ToString().Trim()))
                            {
                                newAddress.street = streetList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(cityList[i].ToString().Trim()))
                            {
                                newAddress.city = cityList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(provinceList[i].ToString().Trim()))
                            {
                                newAddress.province = provinceList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(countryList[i].ToString().Trim()))
                            {
                                newAddress.country = countryList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(postalCodeList[i].ToString().Trim()))
                            {
                                newAddress.postalCode = postalCodeList[i].ToString().Trim();
                            }
                            if (!string.IsNullOrWhiteSpace(phoneList[i].ToString().Trim()))
                            {
                                newAddress.phone = string.Format("tel:+{0}", phoneList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(emailList[i].ToString().Trim()))
                            {
                                newAddress.emailAdress = string.Format("mailto:{0}", emailList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(firstNameList[i].ToString().Trim()))
                            {
                                newAddress.contactName = string.Format("{0}, {1}", firstNameList[i].ToString().Trim(), lastNameList[i].ToString().Trim());
                            }

                            var addressExist = newAddress.HasAllEmptyProperties();
                            if (addressExist)
                            {
                                //Company ID(1.353)
                                newItem.companyRoot = Constants.oid_companyRoot;
                                if (string.IsNullOrWhiteSpace(comIDList[i].ToString().Trim()))
                                {
                                    newItem.companyExtension = "999999999";
                                }
                                else
                                {
                                    newItem.companyExtension = comIDList[i].ToString().Trim();
                                }
                                //OrganizationRole(1.35)
                                newItem.roleRoot = Constants.oid_roleRoot;
                                if (string.IsNullOrWhiteSpace(organizationRoleList[i].ToString().Trim()))
                                {
                                    newItem.roleExtension = "999999999";
                                }
                                else
                                {

                                }
                                newItem.address = newAddress;
                                items.Add(newItem);
                            }
                            else
                            {
                                if (!string.IsNullOrWhiteSpace(comIDList[i].ToString().Trim()))
                                {
                                    newItem.companyExtension = comIDList[i].ToString().Trim();
                                }

                                if (!string.IsNullOrWhiteSpace(organizationRoleList[i].ToString().Trim()))
                                {
                                    newItem.roleExtension = organizationRoleList[i].ToString().Trim();
                                }

                                if (!string.IsNullOrWhiteSpace(newItem.companyExtension) || !string.IsNullOrWhiteSpace(newItem.roleExtension))
                                {
                                    items.Add(newItem);
                                }
                            }
                        }
                    }
                }

                if (items.Count > 0)
                {
                    controller.createAuthor(items);
                }
                #endregion
                document = SessionHelper.current.saveForm;
                controller.createComponentBySection(CodeEnum.TitlePage, string.Empty, false, 0);
                //if( !string.IsNullOrWhiteSpace(titleBlock.Value))
                //{
                controller.createComponentBySection(CodeEnum.TitleBlock, this.title.Text, true, 0);
                //}

                if (HttpContext.Current.Request.Form.GetValues("pharmaceuticalStandard") != null)
                {
                    var psList = HttpContext.Current.Request.Form.GetValues("pharmaceuticalStandard").ToList();
                    if (psList.Count > 0)
                    {
                        var psDict = new Dictionary<string, string>();
                        foreach (var ps in psList)
                        {
                            if (psCV != null && psCV.cvList.Count > 0)
                            {
                                var foundCV = psCV.cvList.Where(x => x.code == ps).FirstOrDefault();
                                if (foundCV != null)
                                {
                                    psDict.Add(foundCV.code, foundCV.name);
                                }
                            }
                        }
                        if (psDict.Count > 0)
                        {
                            controller.createComponentBySectionList(CodeEnum.PharmaceuticalStandard, psDict);
                        }
                    }
                }
                if (HttpContext.Current.Request.Form.GetValues("therapeuticClassification") != null)
                {
                    var tcList = HttpContext.Current.Request.Form.GetValues("therapeuticClassification").ToList();
                    if (tcList.Count > 0)
                    {
                        var tcDict = new Dictionary<string, string>();
                        foreach (var tc in tcList)
                        {
                            if (tcCV != null && tcCV.cvList.Count > 0)
                            {
                                var foundTC = tcCV.cvList.Where(x => x.code == tc).FirstOrDefault();
                                if (foundTC != null)
                                {
                                    tcDict.Add(foundTC.code, foundTC.name);
                                }
                            }
                        }
                        if (tcDict.Count > 0)
                        {
                            controller.createComponentBySectionList(CodeEnum.TherapeuticClassification, tcDict);
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(this.dateofPreparation.Text))
                {
                    controller.createComponentBySection(CodeEnum.DatePreparation, this.dateofPreparation.Text, true, 0);
                }

                if (!string.IsNullOrWhiteSpace(this.dateofRevision.Text))
                {
                    controller.createComponentBySection(CodeEnum.DateRevision, this.dateofRevision.Text, true, 0);
                }

                if (!string.IsNullOrWhiteSpace(this.submissionControlNumber.Text))
                {
                    controller.createComponentBySection(CodeEnum.SubmissionControlNumber, this.submissionControlNumber.Text, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.footnote.Value))
                {
                    controller.createComponentBySection(CodeEnum.Footnote, this.footnote.Value, true, 0);
                }
                #endregion
                #region Part I 
                controller.createComponentBySection(CodeEnum.PartIPage, string.Empty, false, 0);
                if (!string.IsNullOrWhiteSpace(this.summaryProductInformation.Value))
                {
                    controller.createComponentBySection(CodeEnum.SummaryProductInformation, this.summaryProductInformation.Value, true, 0);
                }

                #region Indications And Clinical Use

                if (HttpContext.Current.Request.Form.GetValues("indicationsClinicalUse") != null ||
                    HttpContext.Current.Request.Form.GetValues("patientSubsets") != null ||
                    HttpContext.Current.Request.Form.GetValues("geriatrics") != null ||
                    HttpContext.Current.Request.Form.GetValues("pediatrics") != null)
                {
                    var indicationsClinicalUseList = HttpContext.Current.Request.Form.GetValues("indicationsClinicalUse").ToList();
                    var patientSubsetsList = HttpContext.Current.Request.Form.GetValues("patientSubsets").ToList();
                    var geriatricsList = HttpContext.Current.Request.Form.GetValues("geriatrics").ToList();
                    var pediatricsList = HttpContext.Current.Request.Form.GetValues("pediatrics").ToList();

                    if (indicationsClinicalUseList.Count > 0)
                    {
                        for (int i = 0; i < indicationsClinicalUseList.Count; i++)
                        {
                            var indicationsClinicalDict = new Dictionary<CodeEnum, string>();
                            if (!string.IsNullOrWhiteSpace(indicationsClinicalUseList[i].ToString().Trim()))
                            {
                                indicationsClinicalDict.Add(CodeEnum.IndicationsAndClinicalUse, indicationsClinicalUseList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(patientSubsetsList[i].ToString().Trim()))
                            {
                                indicationsClinicalDict.Add(CodeEnum.PatientSubsets, patientSubsetsList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(geriatricsList[i].ToString().Trim()))
                            {
                                indicationsClinicalDict.Add(CodeEnum.Geriatrics, geriatricsList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(pediatricsList[i].ToString().Trim()))
                            {
                                indicationsClinicalDict.Add(CodeEnum.Pediatrics, pediatricsList[i].ToString().Trim());
                            }
                            if (indicationsClinicalDict != null && indicationsClinicalDict.Count > 0)
                            {
                                controller.createComponentBySectionList(CodeEnum.IndicationsAndClinicalUse, indicationsClinicalDict);
                            }
                        }
                    }
                }
                #endregion
                if (!string.IsNullOrWhiteSpace(this.contradictions.Value))
                {
                    controller.createComponentBySection(CodeEnum.Contradictions, this.contradictions.Value, true, 0);
                }

                #region Warnings And Precautions
                var warningsPrecautionsDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.warningsAndPrecautions.Value.Trim()))
                {
                    warningsPrecautionsDict.Add(CodeEnum.WarningsAndPrecautions, this.warningsAndPrecautions.Value);
                }
                if (HttpContext.Current.Request.Form.GetValues("warningsPrecautionsList") != null ||
                    HttpContext.Current.Request.Form.GetValues("specialPopulationsList") != null ||
                    HttpContext.Current.Request.Form.GetValues("specialPopulationsMisc") != null ||
                    HttpContext.Current.Request.Form.GetValues("warningsPrecautions") != null)
                {
                    var headingList = HttpContext.Current.Request.Form.GetValues("warningsPrecautionsList").ToList();
                    var specialPopulationsList = HttpContext.Current.Request.Form.GetValues("specialPopulationsList").ToList();
                    var specialPopulationsMisc = HttpContext.Current.Request.Form.GetValues("specialPopulationsMisc").ToList();
                    var warningsPrecautions = HttpContext.Current.Request.Form.GetValues("warningsPrecautions").ToList();
                    if (headingList.Count > 0)
                    {
                        var tempDict = new Dictionary<CodeEnum, string>();
                        var sb = new StringBuilder();
                        for (int i = 0; i < headingList.Count; i++)
                        {
                            if (wpCV != null && wpCV.cvList.Count > 0)
                            {

                                var foundWP = wpCV.cvList.Where(x => x.code == headingList[i]).FirstOrDefault();
                                if (foundWP != null)
                                {
                                    var tempWP = CodeCollection.codes.Where(x => x.Value.Code == foundWP.code).FirstOrDefault();
                                    if (tempWP.Key == CodeEnum.SpecialPopulations)
                                    {
                                        tempDict.Add(CodeEnum.SpecialPopulations, string.Empty);
                                        var foundSP = spCV.cvList.Where(x => x.code == specialPopulationsList[i]).FirstOrDefault();
                                        if (foundSP != null)
                                        {
                                            var tempSP = CodeCollection.codes.Where(x => x.Value.Code == foundSP.code).FirstOrDefault();
                                            tempDict.Add(tempSP.Key, warningsPrecautions[i]);
                                        }
                                    }
                                    else if (tempWP.Key == CodeEnum.SpecialPopulationsMisc)
                                    {
                                        sb.Append(specialPopulationsMisc[i]).Append(":").Append(warningsPrecautions[i]).Append("|");
                                    }
                                    else
                                    {
                                        tempDict.Add(tempWP.Key, warningsPrecautions[i]);
                                    }
                                }
                            }
                        }
                        if (sb.Length > 0)
                        {
                            tempDict.Add(CodeEnum.SpecialPopulationsMisc, sb.ToString().TrimEnd('|'));
                        }
                        if (tempDict.Count > 0)
                        {
                            tempDict.OrderBy(x => x.Key);
                            foreach (var kvp in tempDict)
                            {
                                warningsPrecautionsDict.Add(kvp.Key, kvp.Value);
                            }
                        }
                    }
                    if (warningsPrecautionsDict != null && warningsPrecautionsDict.Count > 0)
                    {
                        controller.createComponentBySectionList(CodeEnum.WarningsAndPrecautions, warningsPrecautionsDict);
                    }
                }
                #endregion
                #region Adverse Reactions
                var adverseReactionDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.adverseReaction.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.AdverseReactions, this.adverseReaction.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.adverseReactionOverview.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.AdverseDrugReactionOverview, this.adverseReactionOverview.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.adverseReactionOverview.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.ClinicalTrialAdverseDrugReactions, this.clinicalTrial.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.adverseReactionOverview.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.LessCommonClinicalTrialAdverseDrugReactions, this.lessCommonClinicalTrial.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.adverseReactionOverview.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.AbnormalHematologicAndClinicalChemistryFindings, this.abnormalHematologic.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.adverseReactionOverview.Value.Trim()))
                {
                    adverseReactionDict.Add(CodeEnum.PostMarketAdverseDrugReactions, this.postMarketAdverse.Value);
                }
                if (adverseReactionDict != null && adverseReactionDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.AdverseReactions, adverseReactionDict);
                }
                #endregion
                #region Drug Interactions
                var drugInteractionsDict = new Dictionary<CodeEnum, string>();
                //drugInteractions
                if (!string.IsNullOrWhiteSpace(this.drugInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugInteractions, this.drugInteractions.Value);
                }
                //drugInteractionsOverview
                if (!string.IsNullOrWhiteSpace(this.drugInteractionsOverview.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugInteractionsOverview, this.drugInteractionsOverview.Value);
                }
                //drugDrugInteractions
                if (!string.IsNullOrWhiteSpace(this.drugDrugInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugDrugInteractions, this.drugDrugInteractions.Value);
                }
                //drugFoodInteractions
                if (!string.IsNullOrWhiteSpace(this.drugFoodInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugFoodInteractions, this.drugFoodInteractions.Value);
                }
                //drugHurbInteractions
                if (!string.IsNullOrWhiteSpace(this.drugHurbInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugHerbInteractions, this.drugHurbInteractions.Value);
                }
                //drugLaboratoryInteractions
                if (!string.IsNullOrWhiteSpace(this.drugLaboratoryInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugLaboratoryTestInteractions, this.drugLaboratoryInteractions.Value);
                }
                //drugLifestyleInteractions
                if (!string.IsNullOrWhiteSpace(this.drugLifestyleInteractions.Value.Trim()))
                {
                    drugInteractionsDict.Add(CodeEnum.DrugLifestyleInteractions, this.drugLifestyleInteractions.Value);
                }
                if (drugInteractionsDict != null && drugInteractionsDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.DrugInteractions, drugInteractionsDict);
                }
                #endregion
                #region Dosage And Administration
                var dosageAdministrationDict = new Dictionary<CodeEnum, string>();
                //Dosage And Administration
                if (!string.IsNullOrWhiteSpace(this.dosageAdministration.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.DosageAndAdministration, this.dosageAdministration.Value);
                }
                //Dosing Considerations
                if (!string.IsNullOrWhiteSpace(this.dosingConsiderations.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.DosingConsiderations, this.dosingConsiderations.Value);
                }
                //Recommended Dose And Dosage Adjustment
                if (!string.IsNullOrWhiteSpace(this.recommendedAdjustment.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.RecommendedDoseAndDosageAdjustment, this.recommendedAdjustment.Value);
                }
                //Missed Dose
                if (!string.IsNullOrWhiteSpace(this.dosageAdministrationMissedDose.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.DosageAdministrationMissedDose, this.dosageAdministrationMissedDose.Value);
                }
                //Administration
                if (!string.IsNullOrWhiteSpace(this.administration.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.Administration, this.administration.Value);
                }
                //Reconstitution
                if (!string.IsNullOrWhiteSpace(this.reconstitution.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.Reconstitution, this.reconstitution.Value);
                }
                //Oral Solutions
                if (!string.IsNullOrWhiteSpace(this.oralSolutions.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.OralSolutions, this.oralSolutions.Value);
                }
                //Parenteral Products
                if (!string.IsNullOrWhiteSpace(this.parenteralProducts.Value.Trim()))
                {
                    dosageAdministrationDict.Add(CodeEnum.ParenteralProducts, this.parenteralProducts.Value);
                }
                if (dosageAdministrationDict != null && dosageAdministrationDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.DosageAndAdministration, dosageAdministrationDict);
                }
                #endregion
                //Overdosage
                if (!string.IsNullOrWhiteSpace(this.overdosage.Value))
                {
                    controller.createComponentBySection(CodeEnum.Overdosage, this.overdosage.Value, true, 0);
                }

                #region Action And Clinical Pharmacology
                var actionClinicalDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.actionClinical.Value.Trim()))
                {
                    actionClinicalDict.Add(CodeEnum.ActionAndClinicalPharmacology, this.actionClinical.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.mechanismAction.Value.Trim()))
                {
                    actionClinicalDict.Add(CodeEnum.MechanismOfAction, this.mechanismAction.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.pharmacodynamics.Value.Trim()))
                {
                    actionClinicalDict.Add(CodeEnum.Pharmacodynamics, this.pharmacodynamics.Value);
                }
                if (HttpContext.Current.Request.Form.GetValues("pharmacokineticsList") != null ||
                    HttpContext.Current.Request.Form.GetValues("specialConditionsList") != null ||
                    HttpContext.Current.Request.Form.GetValues("pharmacokinetics") != null)
                {
                    var pharmacokineticsList = HttpContext.Current.Request.Form.GetValues("pharmacokineticsList").ToList();
                    var specialConditionsList = HttpContext.Current.Request.Form.GetValues("specialConditionsList").ToList();
                    var pharmacokinetics = HttpContext.Current.Request.Form.GetValues("pharmacokinetics").ToList();
                    if (pharmacokineticsList.Count > 0)
                    {
                        var tempDict = new Dictionary<CodeEnum, string>();
                        for (int i = 0; i < pharmacokineticsList.Count; i++)
                        {
                            if (pkCV != null && pkCV.cvList.Count > 0)
                            {

                                var foundPK = pkCV.cvList.Where(x => x.code == pharmacokineticsList[i]).FirstOrDefault();
                                if (foundPK != null)
                                {
                                    var tempPK = CodeCollection.codes.Where(x => x.Value.Code == foundPK.code).FirstOrDefault();
                                    if (tempPK.Key == CodeEnum.SpecialPopulationsAndConditions)
                                    {
                                        //tempDict.Add(CodeEnum.SpecialPopulationsAndConditions, string.Empty);
                                        var foundSPC = spcCV.cvList.Where(x => x.code == specialConditionsList[i]).FirstOrDefault();
                                        if (foundSPC != null)
                                        {
                                            var tempSPC = CodeCollection.codes.Where(x => x.Value.Code == foundSPC.code).FirstOrDefault();
                                            tempDict.Add(tempSPC.Key, pharmacokinetics[i]);
                                        }
                                    }
                                    else
                                    {
                                        tempDict.Add(tempPK.Key, pharmacokinetics[i]);
                                    }
                                }
                            }
                        }
                        if (tempDict.Count > 0)
                        {
                            tempDict.OrderBy(x => x.Key);
                            foreach (var kvp in tempDict)
                            {
                                actionClinicalDict.Add(kvp.Key, kvp.Value);
                            }
                        }
                    }
                    if (actionClinicalDict != null && actionClinicalDict.Count > 0)
                    {
                        controller.createComponentBySectionList(CodeEnum.ActionAndClinicalPharmacology, actionClinicalDict);
                    }
                }
                #endregion

                if (!string.IsNullOrWhiteSpace(this.storageandStability.Value))
                {
                    controller.createComponentBySection(CodeEnum.StorageandStability, this.storageandStability.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.specialHandlingInstructions.Value))
                {
                    controller.createComponentBySection(CodeEnum.SpecialHandlingInstructions, this.specialHandlingInstructions.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.dosageFormsComposition.Value))
                {
                    controller.createComponentBySection(CodeEnum.DosageFormsCompositionandPackaging, this.dosageFormsComposition.Value, true, 0);
                }
                #endregion
                #region Part II 
                controller.createComponentBySection(CodeEnum.PartIIPage, string.Empty, false, 0);

                #region Pharmaceutical Information
                var pharmaceuticalInformationDict = new Dictionary<CodeEnum, string>();
                var drugSubstancDicList = new List<Dictionary<CodeEnum, string>>();
                if (!string.IsNullOrWhiteSpace(this.pharmaceuticalInformation.Value))
                {
                    pharmaceuticalInformationDict.Add(CodeEnum.PharmaceuticalInformation, this.pharmaceuticalInformation.Value);
                    drugSubstancDicList.Add(pharmaceuticalInformationDict);
                }

                if (HttpContext.Current.Request.Form.GetValues("drugSubstance") != null ||
                    HttpContext.Current.Request.Form.GetValues("drugProperName") != null ||
                    HttpContext.Current.Request.Form.GetValues("chemicalName") != null ||
                    HttpContext.Current.Request.Form.GetValues("molecularFormula") != null ||
                    HttpContext.Current.Request.Form.GetValues("stereochemistry") != null ||
                    HttpContext.Current.Request.Form.GetValues("physicochemical") != null)
                {
                    var drugSubstanceList = HttpContext.Current.Request.Form.GetValues("drugSubstance").ToList();
                    var drugProperNameList = HttpContext.Current.Request.Form.GetValues("drugProperName").ToList();
                    var chemicalNameist = HttpContext.Current.Request.Form.GetValues("chemicalName").ToList();
                    var molecularFormulaList = HttpContext.Current.Request.Form.GetValues("molecularFormula").ToList();
                    var stereochemistryList = HttpContext.Current.Request.Form.GetValues("stereochemistry").ToList();
                    var physicochemicalList = HttpContext.Current.Request.Form.GetValues("physicochemical").ToList();

                    if (drugSubstanceList.Count > 0)
                    {
                        for (int i = 0; i < drugSubstanceList.Count; i++)
                        {
                            var drugSubstanceDict = new Dictionary<CodeEnum, string>();
                            if (!string.IsNullOrWhiteSpace(drugSubstanceList[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.DrugSubstance, drugSubstanceList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(drugProperNameList[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.DrugProperName, drugProperNameList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(chemicalNameist[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.ChemicalName, chemicalNameist[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(molecularFormulaList[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.MolecularFormulaAndMolecularMass, molecularFormulaList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(stereochemistryList[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.StructuralformulaIncludingrelative, stereochemistryList[i].ToString().Trim());
                            }
                            if (!string.IsNullOrWhiteSpace(physicochemicalList[i].ToString().Trim()))
                            {
                                drugSubstanceDict.Add(CodeEnum.PhysicochemicalProperties, physicochemicalList[i].ToString().Trim());
                            }
                            if (drugSubstanceDict != null && drugSubstanceDict.Count > 0)
                            {
                                drugSubstancDicList.Add(drugSubstanceDict);
                            }
                        }
                        //pharmaceuticalInformationDict                        
                    }

                    if (drugSubstancDicList != null && drugSubstancDicList.Count > 0)
                    {
                        controller.createComponentBySectionList(CodeEnum.PharmaceuticalInformation, drugSubstancDicList);
                    }
                }
                #endregion
                #region Clinical Trials
                var clinicalTrialsDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.clinicalTrials.Value.Trim()))
                {
                    clinicalTrialsDict.Add(CodeEnum.ClinicalTrials, this.clinicalTrials.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.efficacySafety.Value.Trim()))
                {
                    clinicalTrialsDict.Add(CodeEnum.EfficacyandSafetyStudies, this.efficacySafety.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.studyDemographics.Value.Trim()))
                {
                    clinicalTrialsDict.Add(CodeEnum.StudyDemographicsAndTrialDesign, this.studyDemographics.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.studyResults.Value.Trim()))
                {
                    clinicalTrialsDict.Add(CodeEnum.StudyResults, this.studyResults.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.pivotalComparative.Value.Trim()))
                {
                    clinicalTrialsDict.Add(CodeEnum.PivotalComparativeBioavailabilityStudies, this.pivotalComparative.Value);
                }

                if (clinicalTrialsDict != null && clinicalTrialsDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.ClinicalTrials, clinicalTrialsDict);
                }
                #endregion
                if (!string.IsNullOrWhiteSpace(this.detailedPharmacology.Value))
                {
                    controller.createComponentBySection(CodeEnum.DetailedPharmacology, this.detailedPharmacology.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.microbiology.Value))
                {
                    controller.createComponentBySection(CodeEnum.Microbiology, this.microbiology.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.toxicology.Value))
                {
                    controller.createComponentBySection(CodeEnum.Toxicology, this.toxicology.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.references.Value))
                {
                    controller.createComponentBySection(CodeEnum.References, this.references.Value, true, 0);
                }
                #endregion

                #region Part III
                controller.createComponentBySection(CodeEnum.PartIIIPage, string.Empty, false, 0);
                if (!string.IsNullOrWhiteSpace(this.general.Value))
                {
                    controller.createComponentBySection(CodeEnum.General, this.general.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.openingDisclaimer.Value))
                {
                    controller.createComponentBySection(CodeEnum.OpeningDisclaimer, this.openingDisclaimer.Value, true, 0);
                }
                #region About This Medication
                var aboutMedicationDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.aboutMedication.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.AboutThisMedication, this.aboutMedication.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.medicationUsedFor.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhatTheMedicationIsUsedFor, this.medicationUsedFor.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.whatItDoes.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhatItDoes, this.whatItDoes.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.whenNotBeUsed.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhenItShouldNotBeUsed, this.whenNotBeUsed.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.medicinalIngredient.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhatTheMedicinalIngredientIs, this.medicinalIngredient.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.nonmedicinalIngredients.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhatTheImportantNonmedicinalIngredientsAre, this.nonmedicinalIngredients.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.whatDosageForms.Value))
                {
                    aboutMedicationDict.Add(CodeEnum.WhatDosageFormsItComesIn, this.whatDosageForms.Value);
                }
                if (aboutMedicationDict != null && aboutMedicationDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.AboutThisMedication, aboutMedicationDict);
                }
                #endregion
                if (!string.IsNullOrWhiteSpace(this.warningAndPrecaution.Value))
                {
                    controller.createComponentBySection(CodeEnum.WarningAndPrecaution, this.warningAndPrecaution.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.interactionsMedication.Value))
                {
                    controller.createComponentBySection(CodeEnum.InteractionsWithThisMedication, this.interactionsMedication.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.sideEffectsWhatTodo.Value))
                {
                    controller.createComponentBySection(CodeEnum.SideEffectsandwhatToDoAboutThem, this.sideEffectsWhatTodo.Value, true, 0);
                }

                #region Proper Use Of This Medication
                var properUseMedicationDict = new Dictionary<CodeEnum, string>();
                if (!string.IsNullOrWhiteSpace(this.properUseMedication.Value))
                {
                    properUseMedicationDict.Add(CodeEnum.ProperUseOfThisMedication, this.properUseMedication.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.usualDose.Value))
                {
                    properUseMedicationDict.Add(CodeEnum.UsualDose, this.usualDose.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.overdose.Value))
                {
                    properUseMedicationDict.Add(CodeEnum.Overdose, this.overdose.Value);
                }
                if (!string.IsNullOrWhiteSpace(this.missedDose.Value))
                {
                    properUseMedicationDict.Add(CodeEnum.MissedDose, this.missedDose.Value);
                }
                if (properUseMedicationDict != null && properUseMedicationDict.Count > 0)
                {
                    controller.createComponentBySectionList(CodeEnum.ProperUseOfThisMedication, properUseMedicationDict);
                }
                #endregion
                if (!string.IsNullOrWhiteSpace(this.howStoreIt.Value))
                {
                    controller.createComponentBySection(CodeEnum.HowToStoreIt, this.howStoreIt.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.moreInformation.Value))
                {
                    controller.createComponentBySection(CodeEnum.MoreInformation, this.moreInformation.Value, true, 0);
                }
                if (!string.IsNullOrWhiteSpace(this.lastRevision.Text))
                {
                    controller.createComponentBySection(CodeEnum.PartIIIRevisionDate, this.lastRevision.Text, true, 0);
                }
                #endregion
            }
            catch (System.Threading.ThreadAbortException thr)
            {
                var strMessage = string.Format("{0}-{1}", "titlePage", "SaveDraftForm()");
                ExceptionHelper.LogException(thr, strMessage);
            }
            catch (Exception ex)
            {
                var strMessage = string.Format("{0}-{1}", "titlePage", "SaveDraftForm()");
                ExceptionHelper.LogException(ex, strMessage);
            }
        }
    }
}

