using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class SuggestRepository :Repository<Suggest>
    {
        
        public SuggestRepository(DbContext currentContext) : base(currentContext)
        {
            
        }

    }
}
