using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    //引用类型的类型转换
    class Basics
    {
        internal void BasicsTry()
        {
            Console.WriteLine("父类");
        }
    }
    class Child : Basics
    {
        //internal void ChildTry()
        //{
        //    Console.WriteLine("子类");
        //}
    }
    //索引
    class Index
    {
        internal int[] _score;
        internal int this[int index]
        {
            get { return _score[index]; }
            set { _score[index]=value; }

        }
    }

}
