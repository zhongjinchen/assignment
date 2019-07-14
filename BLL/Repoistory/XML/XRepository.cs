using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Repository<T> : IRepository<T>
    {

        public virtual void Add(T model)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> Get()
        {
            throw new NotImplementedException();
        }

        public virtual T GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
