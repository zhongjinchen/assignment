using BLL;
using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegisterFactory
    {
        internal static User ZhangSan, LiSi; 
        private static UserService _userService;
        static RegisterFactory()
        {
            _userService = new UserService();
        }
        internal static void Create()
        {

            ZhangSan=_userService.Register("张三",Helper.Password);
            LiSi=_userService.Register("李四", Helper.Password);
            
        }
    }
}
