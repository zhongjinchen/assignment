using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCService
{
    public class UserService:Service<User>
    {
        private EmailService _emailService;

        public UserService() : base()
        {

            _emailService =new EmailService();
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
            Email email = _emailService.entities.Where(w => w.Id == id).SingleOrDefault();
            return email;
        }

        public void ResetPassword(string password, int UserId)
        {
            User user = entities.Where(u => u.Id == UserId).SingleOrDefault();

        }
    }
}
