using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace DBFactory
{
    internal class Helper
    {
        internal const string Password = "1234";
        public static DbContext CurrentContext;
        public static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)
            .Parent.Parent.FullName;
        static Helper()
        {
            CurrentContext = new SQLContext(new ConfigurationBuilder()
                .SetBasePath(projectDirectory /*Path.Combine(AppContext.BaseDirectory)*/)
                .AddJsonFile("appsettings.json", optional: true)
                .Build());
        }
    }

    class MyConfig : IConfiguration
    {
        public string this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}
