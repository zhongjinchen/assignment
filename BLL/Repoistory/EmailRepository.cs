using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class EmailRepository :Repository<Email>
    {

        public EmailRepository(DbContext currentContext) : base(currentContext)
        {

           
        }
    }
}
