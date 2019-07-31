using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
    public class ProblemRepository : Repository<Problem>
    {
        public ProblemRepository(DbContext currentContext) : base(currentContext)
        {

        }


        //public new IList<Problem> GetAll()
        //{
        //    return entities.Include(p => p.User)
        //        .ToList();
        //}

        //public IQueryable<Problem> Get(int pageIndex, int pageSize)
        //{
        //    return Paged(entities, pageIndex, pageSize);
        //}

        public IQueryable<Problem> GetByAuthor(int AuhtorId)
        {
            return entities.Where(w=>w.User.Id==AuhtorId).OrderByDescending(e => e.Id);
        }
    }
}
