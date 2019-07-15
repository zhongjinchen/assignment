using BLL;
using System;

namespace Servise
{
    public class UserService
    {
        private UserRepoistory _userRepoistory;
        public UserService()
        {
            _userRepoistory = new UserRepoistory();
        }
        public void Register(string name, string password)
        {
            User user = new User(name, password);
            user.Register();
            _userRepoistory.Save(user);
        }

        public bool HasExist(string userName)
        {
            return _userRepoistory.GetByName(userName) != null;
        }

        public void SendValidationEmail(string emailAddress,string ValidationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };

            _userRepoistory.Save(email);

            string VaildationUrl = string.Format(ValidationUrlFormat, email.Id, email.ValidationCode);
        }
    }
}
