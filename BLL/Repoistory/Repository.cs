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

        public IQueryable<T> Get()
        {
            return entities.OrderByDescending(e=>e.Id);
        }

        public IQueryable<T> Paged(IQueryable<T> entities,int pageIndex, int pageSize)
        {
            return entities
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
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


        public void Delete(T entitie)
        {
            entities.Remove(entitie);
            Flush();
        }

        public IQueryable<T> GetById(int id)
        {
            return entities.Where(w => w.Id == id);
        }


    }
}
