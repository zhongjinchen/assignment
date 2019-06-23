using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    public interface IRepository<T>
    {
        T Load();
        IList<T> Get();
        void Add(T model);
    }
 
}
