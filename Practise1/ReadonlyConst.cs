using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    public interface IReadonlyConst
    {

        int MyProperty { get; set; }    //属性简写（prop）
        void C();

        void relect();
    
    }
    public class ReadonlyConst:IReadonlyConst
    {
        public readonly Abb _a;
        public const int b = 2;
        public readonly int f = 9;
        private int _age = 32;
        public ReadonlyConst(Abb a)       //构造函数简写（ctor）
        {
            _a = a;
        }
        public int MyProperty { get; set; }    //属性简写（prop）
        public void C()
        {
            const int d = 8;
            int e = f;
            int g = b;

        }
        public void relect()
        {
            Console.WriteLine($"{_a}反射");
        }
    }
    public class Abb { }
    class Baa : ReadonlyConst
    {
        public Baa(Abb d) : base(d)     //如果父类构造函数有形参，子类必须继承
        {                             //父类构造函数，且形参必须一致，如果父类
                                      //构造函数无参数，则不需  
        }
    }
}
