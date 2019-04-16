using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Father
    {
        internal virtual void Fly()
        {
            Console.WriteLine("飞");
        }
    }
    class Son : Father
    {
        internal override void Fly()
        {
            Console.WriteLine("扇翅膀飞");
        }
    }
    //class Father
    //{
    //    internal string Fly()
    //    {
    //        return "飞";
    //    }
    //}
    //class Son : Father
    //{
    //    internal string Bird()
    //    {
    //        return "扇翅膀飞";
    //    }
    //}

    abstract class Dad
    {
        internal abstract void Eat();
    }
    class Boy:Dad
    {
        internal override void Eat()
        {
            Console.WriteLine("吃饭");
        }
    }


}
