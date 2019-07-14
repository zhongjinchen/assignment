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
        private static int _idCount;
        public User Save(User user)
        {
            _idCount++;
            user.Id = _idCount;
            _users.Add(user);
            SaveChanges();
            return user;
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
            string ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";
            optionsBuilder.UseSqlServer(ConnectionString);

        }
    }
}
