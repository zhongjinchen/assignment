using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
    public class Repository<T> where T : Entity
    {
        public SQLContext CurrentContext { get; set; }
        public DbSet<T> entities { get; set; }
        public Repository()
        {
            CurrentContext = new SQLContext();
            entities = CurrentContext.Set<T>();
        }

        public void SetEntities(SQLContext context )
        {
            CurrentContext = context;
            entities = CurrentContext.Set<T>();
        }

        public T Save(T entity)
        {
            entities.Add(entity);
            CurrentContext.SaveChanges();
            return entity;
        }

        public void Flush()
        {
            CurrentContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return entities.Where(w => w.Id == id).SingleOrDefault();
        }

   
    }
}
