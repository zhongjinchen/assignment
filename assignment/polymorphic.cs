using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class polymorphic
    {

    }
    abstract class mather
    {
        internal int Money = 1000000;
    }
    class son:mather
    {
        public void a()
        {
            Console.WriteLine("花光");
        }
        
    }
}
