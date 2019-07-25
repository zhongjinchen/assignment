using BLL;
using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    public class RegisterFactory
    {
        internal static User ZhongYi, ZhongEr, ZhongSan, ZhongSi;
        private static UserService _userService;
        static RegisterFactory()
        {
            _userService = new UserService();
        }
        internal static void Create()
        {

            ZhongYi = _userService.Register("钟一", "111111", "1111@qq.com");
            ZhongEr = _userService.Register("钟二", "222222", "2222@qq.com");
            ZhongSan = _userService.Register("钟三", "333333", "3333@qq.com");
            ZhongSi = _userService.Register("钟四", "444444", "4444@qq.com");

        }
    }
}
