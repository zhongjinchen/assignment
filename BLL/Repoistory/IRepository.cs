using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BLL
{
    public interface IRepository<T>
    {
        T GetBy(int Id);
        IList<T> Get();
        void Add(T model);
        void Delete(T model);
    }
 
}
