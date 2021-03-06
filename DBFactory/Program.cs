﻿using BLL;
using BLL.Repoistory;
using DBFactory.Suggest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.SqlServer.Server;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseFacade db = new UserRepoistory().Database;

            DatabaseFacade db = Helper.CurrentContext.Database; /*new SQLContext().Database;*/

            db.EnsureDeleted();
            db.EnsureCreated();
            RegisterFactory.Create();
            //NewFactory.Create();
            //ProblemFactory.Create();

            Console.WriteLine("完成");
            Console.ReadLine();
        }
    }
}
