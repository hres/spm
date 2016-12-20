
using System.Collections.Generic;

namespace StructuredProductMonograph.Models
{

    public class Section
    {
        public string sectionID { get; set; }
        public string rootID { get; set; }
        public Code code { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string effectiveTime { get; set; }
        public bool allowTitle { get; set; }
        public bool allowText { get; set; }
        public int subSectionLevel { get; set; }
        public List<Section> subSectionList { get; set; }
    }

    public class ManufacturedProduct
    {
        public string code { get; set; }
        public string codeSystem { get; set; }
        public string name { get; set; }
        public Code formCode { get; set; }
        public AsEntityWithGeneric asEntityWithGeneric { get; set; }
        public AsEquivalentEntity ssEquivalentEntity { get; set; }
        public Ingredient ingredient { get; set; }
        public AsContent asContent { get; set; }
    }
    public class Code
    {
        public string code { get; set; }
        public string codeSystem { get; set; }
        public string displayName { get; set; }
    }

    public class AsEntityWithGeneric
    {
        public string genericMedicine { get; set; }
    }

    public class AsEquivalentEntity
    {
        public string code { get; set; }
        public string definingMaterialKind { get; set; }
    }

    public class Ingredient
    {
        public string quantity { get; set; }
        public string ingredientSubstance { get; set; }
    }

    public class AsContent
    {
        public string quantity { get; set; }
        public string containerPackagedProduct { get; set; }
    }

    public class Author
    {
        public string companyRoot { get; set; }
        public string companyExtension { get; set; }
        public string roleRoot { get; set; }
        public string roleExtension { get; set; }
        public string sponsorRoot { get; set; }
        public string sponsorExtension { get; set; }
        //public Code addressCode { get; set; }
        public Address address { get; set; }
        public bool isRrepresentedAddress { get; set; }
    }

    public class SPLControlledVocabulary
    {
        public string id { get; set; }        
        public string name { get; set; }
        public string fra_name { get; set; }
        public string oid { get; set; }
        public List<CVItem> cvList { get; set; }
    }

    public class CVItem
    {
        public string code { get; set; }
        public string name { get; set; }
        public string fra_name { get; set; }
        public string definition { get; set; }
        public string fra_definition { get; set; }
    }
}