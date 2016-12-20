using System;
using System.IO;
using System.Xml;
using StructuredProductMonograph.Helpers;

namespace StructuredProductMonograph
{
    public partial class PMForm : BasePage
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
            }
        }

        protected void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode rootnode = doc.CreateElement("ProductMonographTemplate");
            doc.AppendChild(rootnode);

            XmlNode xnode = doc.CreateElement("TemplateVersion");
            xnode.AppendChild(doc.CreateTextNode(ddlTemplate.Value));
            rootnode.AppendChild(xnode);

            SessionHelper.current.draftForm = doc;
            SessionHelper.current.brandName = string.Empty;
            SessionHelper.current.properName = string.Empty;
            SessionHelper.current.existXmlFile = false;
            Response.Redirect("spmCoverpage.aspx");
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