using BLL;
using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBFactory
{
    public class ProblemFactory
    {

        public static DbSet<Problem> PEntities;
        public static DbSet<User> UEntities;
        static ProblemFactory()
        {

            PEntities = Helper.CurrentContext.Set<Problem>();
            UEntities = Helper.CurrentContext.Set<User>();
        }
        internal static void Create()
        {
            PEntities.Add(
                new Problem
                {
                    Title = "标题1",
                    Body = "内容1",
                    User = UEntities.Where(u => u.Name == "钟一").SingleOrDefault(),
                    Date = "2019年7月1日1时1分1秒"

                }
            );
            PEntities.Add(
               new Problem
               {
                   Title = "标题2",
                   Body = "内容2",
                   User = UEntities.Where(u => u.Name == "钟一").SingleOrDefault(),
                   Date = "2019年7月2日1时1分1秒"

               }
           );
            PEntities.Add(
                new Problem
                {
                    Title = "标题3",
                    Body = "内容3",
                    User = UEntities.Where(u => u.Name == "钟二").SingleOrDefault(),
                    Date = "2019年7月3日1时1分1秒"

                }
            );

            Helper.CurrentContext.SaveChanges();
        }
    }
}
