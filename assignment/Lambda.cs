using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Lambda
    {
    }
    class Delegate
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine($"a+b={a+b}");
        }
        public static void rooting(int a)
        {
            Console.WriteLine($"a*2={a*2}");
        }
        internal static void AddDel(int a,int b,Action<int,int>c)
        {
            c(a,b);
        }
        internal static void rootingDel(int a, calculator<int> b)
        {
            b(a);
        }
    }

    public delegate void calculator<in T>(T a);
    class Button
    {
        public event EventHandler OnClick;
        public void click()
        {
            if (OnClick!=null)
            {
                OnClick(this,new EventArgs());
            }
        }
    }
    class Fathers { }
    class Children : Fathers
    {

    }
}
