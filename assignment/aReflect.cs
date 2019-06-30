using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace assignment
{
    //查找源代码，说明：为什么标记为[Flags] 的枚举在Console.WriteLine()时可以输入“Student,TeacherAssist”的效果。 
    //声明一个权限（Token）枚举，用[Flags] 标记，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
    //声明一个权限管理（TokenManager）类，可作为此前User类的属性，使用私有的Token枚举_tokens存储所具有的权限，具有Add(Token)、Remove(Token)和Has(Token)方法，可以添加删除查看其权限
    //使用反射调用上述TokenManager类的Add()、Remove()和Has()方法，以及private的_tokens字段。
    class aReflect
    {
        public static void aReflectCall()
        {
            Type target = Type.GetType("assignment.TokenManager");
            object otarget = target.GetConstructor(new Type[] { }/*null*/).Invoke(new object[] { }/*null*/);

            target.GetMethod("Add").Invoke(otarget, new object[] { Token.SuperAdmin });
            target.GetMethod("Add").Invoke(otarget, new object[] { Token.Admin});
            target.GetMethod("Remove").Invoke(otarget, new object[] { Token.SuperAdmin });
            target.GetMethod("Has").Invoke(otarget, new object[] {});
            Console.WriteLine(target.GetField("_tokens",BindingFlags.NonPublic|BindingFlags.Instance).GetValue(otarget));
        }

    }

    public class TokenManager
    {
        private Token _tokens;
        public void Add(Token token)
        {
            _tokens = _tokens | token;
        }
        public void Remove(Token token)
        {
            _tokens = _tokens ^ token;

        }
        public void Has()
        {
            Console.WriteLine(_tokens);
        }
    }


    [Flags]
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16,
    }
}
