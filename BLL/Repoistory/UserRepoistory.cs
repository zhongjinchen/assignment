using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserRepoistory : DbContext
    {
        public DbSet<User> _users { get; set; }
        public DbSet<Email> _emails { get; set; }
        public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();
        
        }

        public void Save(Email email)
        {
            _emails.Add(email);
            SaveChanges();
           
        }

        public User GetByName(string userName)
        {
            return _users.Where(w => w.Name == userName).SingleOrDefault();
        }

        public static User Get(int id)
        {
            return null;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(ConnectionString);

        }
    }
}
