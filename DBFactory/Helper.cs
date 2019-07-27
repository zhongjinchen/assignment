using BLL.Repoistory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class Helper
    {
        internal const string Password = "1234";
        public static DbContext CurrentContext;
        static Helper()
        {
            CurrentContext = new SQLContext();
        }
    }
}
