using StructuredProductMonograph.Helpers;
using System;
using System.Globalization;
using System.Threading;
using System.Web.UI.WebControls;

namespace StructuredProductMonograph
{
    public partial class ProdMono : System.Web.UI.MasterPage
    {
        public string pageTitleValue { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if( !string.IsNullOrWhiteSpace(SessionHelper.current.selectedLanguage))
            {
                if (!string.IsNullOrWhiteSpace(SessionHelper.current.selectedLanguage))
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(SessionHelper.current.selectedLanguage);
            }

            if (!IsPostBack)
            {

            }
            this.pageTitle.Text = pageTitleValue;
        }

        protected void SwitchLanguageFrench_Click(object sender, EventArgs e)
        {
            SessionHelper.current.selectedLanguage = "fr-CA";
            SessionHelper.current.masterPage = "ProdMonoFr.Master";
            Server.Transfer(Request.Path);
        }
    }
}

