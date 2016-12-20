using System;
using System.Threading;
using System.Globalization;
using StructuredProductMonograph.Helpers;
using System.Web.UI.WebControls;

namespace StructuredProductMonograph
{
    public partial class ProdMonoFr : System.Web.UI.MasterPage
    {
        public string pageTitleValue { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ////retrieve culture information from session
            if (!string.IsNullOrWhiteSpace(SessionHelper.current.selectedLanguage))
            {
                if (!string.IsNullOrWhiteSpace(SessionHelper.current.selectedLanguage))
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(SessionHelper.current.selectedLanguage);
            }

            if (!IsPostBack)
            {

            }
            this.pageTitle.Text = pageTitleValue;
        }

        protected void SwitchLanguageEnglish_Click(object sender, EventArgs e)
        {
            SessionHelper.current.selectedLanguage = "en-CA";
            SessionHelper.current.masterPage = "ProdMono.Master";
            Server.Transfer(Request.Path);
        }
    }
}
