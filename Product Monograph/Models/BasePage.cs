﻿using System;
using System.Globalization;
using System.Threading;
using System.Web.UI;
using StructuredProductMonograph.Helpers;



namespace StructuredProductMonograph
{
    /// <summary>
    /// Summary description for BasePage
    /// </summary>
    public class BasePage : Page
    {
        private const string m_DefaultCulture = "en-CA";
        public string lang { get; set; }

        protected override void InitializeCulture()
        {
            //check whether a culture is stored in the session
            if (!string.IsNullOrEmpty(SessionHelper.current.selectedLanguage))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(SessionHelper.current.selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(SessionHelper.current.selectedLanguage);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(m_DefaultCulture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(m_DefaultCulture);
            }
            lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            
            //call base class
            base.InitializeCulture();
           }

    }
}