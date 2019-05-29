using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class getSet
    {
        private int _age;
        internal int Age
        {
            //第一种写法，可以在花括号后面给它设默认值
            get;
            set;
            /* private set; */    //可以给set设置为私有外界就无法访问

            //第二种
            //get => _age;
            //set { _age = value; }

            //第三种
            //get { return _age; }
            //set { _age = value; }
            //可以获取到值(Console.WriteLine(get.Age);)
            //get
            //{
            //    if (_age < 10)
            //    {
            //        Console.WriteLine("太小了？");
            //        return 1;

            //    }
            //    else
            //    {
            //        return 2;
            //    }
            //}
            ////set可以限制设置的值，但是决定最终值的还是get:(get=>?)
            //set
            //{
            //    if (value > 28)
            //    {
            //        Console.WriteLine("把老娘弄得这么老，你忍心么？");
            //        value = 18;
            //    }
            //    _age = value;
            //}
        }/* = 8;   当没有给它设值的时候默认为 8 */
    }
}
