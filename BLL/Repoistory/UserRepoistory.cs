using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserRepoistory : Repository<User>
    {
        //private SQLContext _sqlContext;
        private EmailRepository emailRepository;
        public UserRepoistory()
        {
            //_sqlContext = new SQLContext();
            emailRepository = new EmailRepository();
        }

        public User GetByName(string userName)
        {
            return entities.Where(w => w.Name == userName).SingleOrDefault();
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
            Email email = emailRepository.entities.Where(w => w.Id == id).SingleOrDefault();
            return email;
        }




    }
}
