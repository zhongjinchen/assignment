using Servise;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    public class ProblemFactory
    {
        private static ProblemService _problemService;
        static ProblemFactory()
        {
            _problemService =new ProblemService();
        }
        internal static void Create()
        {
            //_problemService.Publish();
        }
    }
}
