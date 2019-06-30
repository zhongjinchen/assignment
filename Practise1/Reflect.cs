#define Name
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Practise
{
    //[Online]
    [Online(2, name = "老程")]

    public class Reflect
    {

        public void reflectCall()
        {
#if Name
            Console.WriteLine("".GetType().Name);

#else
            Console.WriteLine(typeof(Int32).Assembly);
#endif
            string path = Path.Join(Environment.CurrentDirectory, "refect.txt");
            string classType = File.ReadAllText(path);
            Type target = Type.GetType(classType);

            //Type target = Type.GetType("Practise.ReadonlyConst");
            //object otarget = target.GetConstructor(new Type[1] { typeof(Abb) }).Invoke(new object[]{ new Abb()});
            //target.GetMethod("relect").Invoke(otarget,null);

            //转换成接口类型可以直接点出类里面的成员来
            IReadonlyConst otarget;
            try
            {
                otarget = (IReadonlyConst)target.GetConstructor(new Type[1] { typeof(Abb) }).Invoke(new object[] { new Abb() });

            }
            catch (Exception)
            {
                throw;
            }
            otarget.relect();
            Console.WriteLine(target.GetField("_age", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(new ReadonlyConst(new Abb())));
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class OnlineAttribute : Attribute
    {
        public string name { get; set; }
        public OnlineAttribute()
        {
            Console.WriteLine("无参构造函数");
        }
        public OnlineAttribute(int age)
        {
            Console.WriteLine("有参构造函数" + age);
        }
    }


}
