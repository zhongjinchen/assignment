using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MVCBLL.Entitis;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();

            modelBuilder.Entity<Email>();
            modelBuilder.Entity<Suggest>();

            modelBuilder.Entity<Comment>();
            modelBuilder.Entity<Message>();

            modelBuilder.Entity<Problem>()
           .HasMany(b => b.Comments)
           .WithOne(p => p.Problem)
           .OnDelete(DeleteBehavior.Cascade);

            //base.OnModelCreating(modelBuilder);
        }
    }
}
