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

    interface ICode { }

    internal class Major { }
    internal class SQL : Major { }
    internal class Person<T> where T : Major { }
    //internal class Person<T> where T: SQL { }  仅仅是Type parameter不同，不算是不同的泛型类

    internal class Teacher<T> : Person<T> where T : Major { }
    internal class littleTeacher<T> : Person<T> where T:SQL{ }
    //Teacher<T>和Teacher有没有什么关系？

    internal class Student : Person<Major>, ICode { }
    //internal class GoodStudent : Teacher { }
}
