using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuredProductMonograph.Models
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        TEntity Get(TKey code);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
