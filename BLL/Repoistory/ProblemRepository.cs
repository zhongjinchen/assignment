using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class ProblemRepository : Repository<Problem>
    {
        public ProblemRepository(DbContext currentContext) : base(currentContext)
        {

        }

      
    }
}
