using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    public interface IRepository<T>
    {
        T GetById();
        IList<T> Get();
        void Add(T model);
        void Delete(T model);
    }
 
}
