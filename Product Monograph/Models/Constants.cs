using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Web;
using System.Xml;

namespace StructuredProductMonograph.Models
{

    public sealed class Constants
    {
        private Constants() { }
        //public static readonly string Val1 = "MyVal1";
        public const string oid_sponsorRoot = "2.16.840.1.113883.3.989.5.1.4.1.31";
        public const string oid_companyRoot = "2.16.840.1.113883.3.989.5.1.4.1.33";
        public const string oid_roleRoot = "2.16.840.1.113883.3.989.5.1.4.1.35";       
        public const string oid_SectionIdentifier = "2.16.840.1.113883.3.989.5.1.4.1.8";
        public const string oid_SchedulingSymbol = "2.16.840.1.113883.3.989.5.1.4.1.1";
        public const string oid_PharmaceuticalStandard = "2.16.840.1.113883.3.989.5.1.4.1.5";
        public const string oid_TherapeuticClassification = "2.16.840.1.113883.3.989.5.1.4.1.6";
        //public const string oid_DateofPreparation = "2.16.840.1.113883.3.989.5.1.4.1.6";
        //public const string oid_DateofRevision = "2.16.840.1.113883.3.989.5.1.4.1.6";
        //public const string oid_SubmissionControlNumber = "2.16.840.1.113883.3.989.5.1.4.1.6";
    }
}