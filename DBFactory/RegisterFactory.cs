using BLL;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    public class RegisterFactory
    {
        internal static User ZhongYi, ZhongEr, ZhongSan, ZhongSi;
        public static DbSet<User> entities;

        static RegisterFactory()
        {
            entities = Helper.CurrentContext.Set<User>();

        }
        internal static void Create()
        {


            ZhongYi = new User("钟一", User.GetMd5Hash("111111"))
            {
                Email = new Email
                {
                    Address = "1111@qq.com"
                }
            };
            ZhongEr = new User("钟二", User.GetMd5Hash("222222"))
            {
                Email = new Email
                {
                    Address = "2222@qq.com"
                }
            };
            ZhongSan = new User("钟三", User.GetMd5Hash("333333"))
            {
                Email = new Email
                {
                    Address = "3333@qq.com"
                }
            };
            ZhongSi = new User("钟四", User.GetMd5Hash("444444"))
            {
                Email = new Email
                {
                    Address = "4444@qq.com"
                }
            };


            entities.Add(ZhongYi);
            entities.Add(ZhongEr);
            entities.Add(ZhongSan);
            entities.Add(ZhongSi);

            Helper.CurrentContext.SaveChanges();
        }
    }
}
