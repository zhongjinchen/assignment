using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Generic<TAge>
    {
        public TAge Age;
        public Generic(TAge age)
        {
            Age = age;
        }
    }
}
