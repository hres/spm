using System;
using System.IO;
using System.Xml;
using StructuredProductMonograph.Helpers;
using System.Xml.Linq;
using System.Text;
using System.Configuration;
using StructuredProductMonograph.Models;
using System.Collections.Generic;

namespace StructuredProductMonograph
{
    public partial class index : BasePage
    {
        void Page_PreInit(Object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SessionHelper.current.masterPage))
            {
                this.MasterPageFile = SessionHelper.current.masterPage;
            }
            if (this.lang.Equals("fr"))
            {
                ((ProdMonoFr)Page.Master).pageTitleValue = Resources.Resource.formInstruction;
            }
            else
            {
                ((ProdMono)Page.Master).pageTitleValue = Resources.Resource.formInstruction;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SessionHelper.current.fileSaved = false;
            if (!Page.IsPostBack)
            {
                if ( lang.Equals("fr"))
                {
                    sectionEng.Visible = false;
                    sectionFra.Visible = true;
                }
                else
                {
                    sectionEng.Visible = true;
                    sectionFra.Visible = false;
                }
                //Load Health Canada SPL Controlled Vocabulary List.
                var hcSPLcvXml = ConfigurationManager.AppSettings["hcSPLcvFile"].ToString();
                if (File.Exists(hcSPLcvXml))
                {
                    var cvList = new List<SPLControlledVocabulary>();
                    var cvDoc = XDocument.Load(hcSPLcvXml);
                    var elements = cvDoc.Descendants("items");
                    if (elements != null)
                    {
                        foreach (var element in elements)
                        {
                            var item = new SPLControlledVocabulary();
                            item.id = element.Attribute("id").Value;
                            item.oid = element.Attribute("oid").Value;
                            item.name = element.Attribute("name").Value;
                            item.fra_name = element.Attribute("fra_name").Value;
                            item.cvList = new List<CVItem>();
                            foreach (var sub in element.Elements("item"))
                            {
                                var subItem = new CVItem();
                                subItem.code = sub.Attribute("code").Value;
                                subItem.name = sub.Attribute("name").Value;
                                subItem.fra_name = sub.Attribute("fra_name").Value;
                                subItem.definition = sub.Attribute("definition").Value;
                                subItem.fra_definition = sub.Attribute("fra_definition").Value;
                                item.cvList.Add(subItem);
                            }
                            cvList.Add(item);
                        }
                        if (cvList.Count > 0)
                        {
                            SessionHelper.current.cvItems = cvList;
                        }
                    }
                }
            }
        }

        protected void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            var newGuid = Guid.NewGuid().ToString();
            var newSetID = Guid.NewGuid().ToString();
            var todayDate = string.Format("{0}{1}{2}",
                            DateTime.Now.Year.ToString(),
                            DateTime.Now.Month.ToString().PadLeft(2, '0'),
                            DateTime.Now.Day.ToString().PadLeft(2, '0'));

            XNamespace xmlns = XNamespace.Get("urn:hl7-org:v3");
            XNamespace xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
            XNamespace schemaLocation = XNamespace.Get("urn:hl7-org:v3 http://www.accessdata.fda.gov/spl/schema/spl.xsd");

            var doc =
                new XDocument(
                    new XDeclaration("1.0", "UTF-8", null),
                    new XProcessingInstruction("xsl-stylesheet", "type=\"text/xsl\" href=\"http://www.accessdata.hc.ca/spl/stylesheet/spl.xsl\""),
                    new XProcessingInstruction("xsl-stylesheet", "type=\"text/css\" href=\"http://www.accessdata.hc.ca/spl/stylesheet/spl.css\""),
                    new XElement(xmlns + "document",
                            new XAttribute(XNamespace.Xmlns + "xsi", xsi),
                            new XAttribute(xsi + "schemaLocation", schemaLocation),
                            new XElement(xmlns + "typeId",
                                new XAttribute("assigningAuthorityName", "Health Canada")),
                            new XElement(xmlns + "id",
                                new XAttribute("root", newGuid)),      
                            new XElement(xmlns + "code",
                                new XAttribute("code", "1"),
                                new XAttribute("codeSystem", "2.16.840.1.113883.3.989.5.1.4.1.10"),
                                new XAttribute("displayName", "2004 Product Monograph Template – Standard")),
                            new XElement(xmlns + "title", ""),
                            new XElement(xmlns + "effectiveTime", new XAttribute("value", todayDate)),
                            new XElement(xmlns + "languageCode",
                                new XAttribute("code", ""),
                                new XAttribute("codeSystem", "2.16.840.1.113883.3.989.5.1.4.1.30"),
                                new XAttribute("displayName", "")),
                            new XElement(xmlns + "setId", new XAttribute("root", newSetID)),
                            new XElement(xmlns + "versionNumber", ""),
                            new XElement(xmlns + "author", new XElement("time")),
                            new XElement(xmlns + "component", new XElement("structuredBody") )
                )
            );

            SessionHelper.current.xmlFileGuid = newGuid;
            SessionHelper.current.saveForm = doc;
            SessionHelper.current.brandName = string.Empty;
            SessionHelper.current.properName = string.Empty;
            SessionHelper.current.existXmlFile = false;           
            Response.Redirect("titlePage.aspx");
        }

        protected void btnLoadXml_Click(object sender, EventArgs e)
        {

            try
            {
                if (fuXmlDraft.HasFile)
                {
                    int idirectory = fuXmlDraft.PostedFile.FileName.LastIndexOf("\\");
                    FileInfo fi = new FileInfo(fuXmlDraft.FileName);
                    if (!fi.Extension.ToString().ToLower().Contains("xml"))
                    {
                        return;
                    }
                    if(fi.FullName.Contains("©"))
                    {
                        errorSection.Visible = true;
                        return;
                    }
                }
                else
                {
                    return;
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(fuXmlDraft.PostedFile.InputStream);
                SessionHelper.current.draftForm = doc;
                SessionHelper.current.existXmlFile = true;
                Response.Redirect("Coverpage.aspx");
            }
            catch (Exception err)
            {

            }
        }

    }

    
}