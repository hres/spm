using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuredProductMonograph.Models
{
    public interface IComponentRepository
    {
        void CreateAddress(List<Author> items);
        void CreateComponent(Section section);
    }
}
