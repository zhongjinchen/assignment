using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserRepoistory 
    {
        private SQLContext _sqlContext;
        public UserRepoistory()
        {
            _sqlContext = new SQLContext();
        }
        public void Save(User user)
        {
            _sqlContext._users.Add(user);
            _sqlContext.SaveChanges();
        
        }

        public void Save(Email email)
        {
            _sqlContext._emails.Add(email);
            _sqlContext.SaveChanges();
           
        }

        public void Flush()
        {
            _sqlContext.SaveChanges();
        }

        public User GetByName(string userName)
        {
            return _sqlContext._users.Where(w => w.Name == userName).SingleOrDefault();
        }

        public User GetByEmail(string email)
        {
            return _sqlContext._users.Where(w => w.Email.Address == email).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return _sqlContext._users.Where(w => w.Id == id).SingleOrDefault();
        }

        public static User Get(int id)
        {
            return null;
        }

        public Email GetEmailById(int id)
        {
            Email email = _sqlContext._emails.Where(w => w.Id == id).SingleOrDefault();
            return email;
        }

    

       
    }
}
