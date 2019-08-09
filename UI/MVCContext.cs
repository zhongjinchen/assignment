using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UI
{
    public class MVCContext: DbContext
    {
        public MVCContext() : base("MVCDataBase")
        {

        }
    }
}