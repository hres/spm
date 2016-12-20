using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace StructuredProductMonograph.Models
{
    public class Address
    {
        public string companyName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string emailAdress { get; set; }
        public string contactName { get; set; }

        public bool HasAllEmptyProperties()
        {
            var type = GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var hasProperty = properties.Select(x => x.GetValue(this, null))
                                        .Any(y => y != null && !String.IsNullOrWhiteSpace(y.ToString()));
            return hasProperty;
        }
    }

}