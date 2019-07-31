using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class CommentRepository:Repository<Comment>
    {
        public CommentRepository(DbContext currentContext) : base(currentContext)
        {

        }
    }
}
