using BLL;
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
            //db.EnsureDeleted();
            //db.EnsureCreated();
            RegisterFactory.Create();
        }
    }
}
