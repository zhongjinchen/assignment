using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
    public class Repository<T> where T : Entity
    {
        public DbContext CurrentContext { get; set; }
        public DbSet<T> entities { get; set; }
        public Repository(DbContext currentContext)
        {
            CurrentContext = currentContext;
            entities = CurrentContext.Set<T>();
        }

        public IList<T> GetAll()
        {
            return entities.ToList();
        }

        public void SetEntities(SQLContext context)
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

        public IQueryable<T> GetById(int id)
        {
            return entities.Where(w => w.Id == id)/*.SingleOrDefault()*/;
        }


    }
}
