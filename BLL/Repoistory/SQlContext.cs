using BLL.Model;
//using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace BLL.Repoistory
{
    public class SQLContext :DbContext
    {
        //public DbSet<User> _users { get; set; }
        //public DbSet<Email> _emails { get; set; }
        //public DbSet<Suggest> _suggests { get; set; }

        private IConfiguration _configuration { get; }

        public SQLContext()
        {
            
        }

        public SQLContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = _configuration.GetConnectionString("RegisterContext") /*@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;"*/;
            optionsBuilder
                 .UseLazyLoadingProxies()
                .UseSqlServer(ConnectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options => {
                options.ToTable("User")
                .Property(x => x.Name)
                .IsRequired();
            });

            modelBuilder.Entity<Email>();
            modelBuilder.Entity<Suggest>();

            modelBuilder.Entity<Comment>();
            modelBuilder.Entity<Message>();

            modelBuilder.Entity<Problem>()
           .HasMany(b => b.Comments)
           .WithOne(p => p.Problem)
           .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Article>();
        }
    }
}
