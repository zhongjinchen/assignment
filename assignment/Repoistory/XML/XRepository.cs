using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class XRepository<T> : IRepository<T>
    {

        public virtual void Add(T model)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> Get()
        {
            throw new NotImplementedException();
        }

        public T Load()
        {
            throw new NotImplementedException();
        }

    }
}
