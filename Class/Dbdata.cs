using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//using Microsoft.IdentityModel.Protocols;

namespace MVCBLL
{
    public class Dbdata : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MVCDataBase"].ConnectionString;
            base.OnConfiguring(optionsBuilder);
        }
    }
}
