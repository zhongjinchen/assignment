using BLL.Model;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{

    public class UserRepository : Repository<User>
    {
        
        private EmailRepository _emailRepository;
  
        public UserRepository(DbContext currentContext, EmailRepository emailRepository) :base(currentContext)
        {
            _emailRepository = emailRepository;
        }

        public IQueryable<User> GetByName(string userName)
        {
            return entities.Where(w => w.Name == userName);
        }

        public User GetByEmail(string email)
        {
            return entities.Where(w => w.Email.Address == email).SingleOrDefault();
        }

  

        public static User Get(int id)
        {
            return null;
        }

        public Email GetEmailById(int id)
        {
            Email email = _emailRepository.entities.Where(w => w.Id == id).SingleOrDefault();
            return email;
        }

        public void ResetPassword(string password,int UserId)
        {
            User user=entities.Where(u=>u.Id==UserId).SingleOrDefault();
            
        }
    }
}
