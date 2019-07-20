using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class SQLContext:DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Email> _emails { get; set; }
        public DbSet<Suggest> _suggests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(ConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options => {
                options.ToTable("User")
                .Property(x => x.Name)
                .IsRequired();
            });
            //modelBuilder.Entity<Article>();
        }
    }
}
