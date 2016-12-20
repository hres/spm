using StructuredProductMonograph.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace StructuredProductMonograph.Helpers
{
    public class SessionHelper
    {
        // This key is used to identify object from session
        private const string KEY = "draft";

        public SessionHelper()
        {
        }

        // Gets the current session.
        public static SessionHelper current
        {
            get
            {
                SessionHelper session = (SessionHelper)HttpContext.Current.Session[KEY];
                if (session == null)
                {
                    session = new SessionHelper();
                    HttpContext.Current.Session[KEY] = session;
                }
                return session;
            }
        }

        // Add your session properties here:
        public bool fileSaved { get; set; }
        public string xmlFileGuid { get; set; }
        public string masterPage { get; set; }
        public string selectedLanguage { get; set; }
        public string brandName { get; set; }
        public string properName { get; set; }
        public XmlDocument draftForm { get; set; }
        public bool existXmlFile { get; set; }
        public XDocument saveForm { get; set; }
        public List<SPLControlledVocabulary> cvItems { get; set; }
    }

}