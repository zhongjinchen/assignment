using BLL;
using System;

namespace Servise
{
    public class RegisterSevise
    {
        private UserRepoistory _userRepoistory;
        public RegisterSevise()
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
    }
}
