using BLL;
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
            DatabaseFacade db = new SQLContext().Database;

            db.EnsureDeleted();
            db.EnsureCreated();
            RegisterFactory.Create();
            NewFactory.Create();

        }
    }
}
