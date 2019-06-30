using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Repository<T> : IRepository<T>
    {

        public virtual void Add(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
