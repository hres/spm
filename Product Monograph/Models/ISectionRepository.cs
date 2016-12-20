using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuredProductMonograph.Models
{
    public interface ISectionRepository
    {
        Section CreateSection(CodeEnum code, string text, bool allowText, int subSectionLevel);
        Section CreateSectionForDropdown(string code, string displayName, string codeSystem, int subSectionLevel);
    }
}
