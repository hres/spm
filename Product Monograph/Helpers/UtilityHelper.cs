using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace StructuredProductMonograph.Helpers
{
    public class UtilityHelper
    {
        public static string ToStringWithDeclaration(XDocument doc)
        {
            if (doc == null)
            {
                throw new ArgumentNullException("doc");
            }
            StringBuilder builder = new StringBuilder();
            using (TextWriter writer = new StringWriter(builder))
            {
                doc.Save(writer);
            }
            return builder.ToString();
        }

        public static string TodayDate
        {
            get { return string.Format("{0}{1}{2}", DateTime.Now.Year.ToString(),
                             DateTime.Now.Month.ToString().PadLeft(2, '0'),
                             DateTime.Now.Day.ToString().PadLeft(2, '0')); }
        }
        public static string SectionID
        {
            get
            {
                return Guid.NewGuid().ToString().ToLower();
            }
        }

        public static T Convert<T>(string value)
        {
            if (typeof(T).GetTypeInfo().IsEnum)
                return (T)Enum.Parse(typeof(T), value);

            return (T)System.Convert.ChangeType(value, typeof(T));
        }

    }
}