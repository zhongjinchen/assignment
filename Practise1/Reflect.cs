using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    public class Reflect
    {
        public void reflectCall()
        {
            Console.WriteLine("".GetType().Name);
            Console.WriteLine(typeof(Int32).Assembly);
        }
    }
}
