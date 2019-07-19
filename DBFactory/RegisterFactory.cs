using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegisterFactory
    {
        private static UserService _userService;
        static RegisterFactory()
        {
            _userService = new UserService();
        }
        internal static void Create()
        {

            _userService.Register("张三",Helper.Password);
            _userService.Register("李四", Helper.Password);

        }
    }
}
