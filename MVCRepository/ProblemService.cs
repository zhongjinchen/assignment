using MVCBLL;
using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCService
{
    public class ProblemService:Service<Problem>
    {
        public ProblemService():base() 
        {

        }

        public IQueryable<Problem> GetByAuthor(int AuhtorId)
        {
            return entities.Where(w => w.User.Id == AuhtorId).OrderByDescending(e => e.Id);
        }

    }
}
