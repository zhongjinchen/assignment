using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型传递是copy
            //int i = 8;
            //int j = i;
            //Console.WriteLine(i);     --i还有值

            //Console.WriteLine(typeof(char));
            //多态练习
            //Father father = new Son();    //----父类的实例指向子类的引用
            //father.Fly();
            ////Console.WriteLine(father.Bird());
            //Dad dad = new Boy();
            //dad.Eat();

            ////接口联系
            //Man man = new Man();
            //man.Lunch();
            //man.Rest();
            //man.Swim();

            ////接口作业
            ////用接口实例（不是类的实例）调用“找到最大值”的方法 
            //IseekMaxValue Seek = new BinaryChop();
            //IseekMaxValue Seek = new violenceSeek();

            //显式实现
            //IseekMaxValue Seek = new DisplayImplementation();
            //IseekMinValue Seek = new DisplayImplementation();
            //Seek.seek();

            //模拟出入栈
            //Mimicstact imitate = new Mimicstact(5);
            //imitate.Push(new object[] {"xl"});  //调用用params（参数数组）方法既可以传递
            //imitate.Push("is", true);         //一个数组实参如(new int[] { 8 })，也可以传递一组数字如（2，2，4）
            //imitate.pop();
            //imitate.Push(10, 3);
            //imitate.Push(4);
            //imitate.Push(7);

            // Bueaty bueaty = new Bueaty(20);
            //// bueaty.toBueaty();
            // Console.WriteLine(bueaty.toBueaty);
            //Bueaty BueatyHeight = new Bueaty(170);
            //  bueaty.Bueatyheight(168);

            // bueaty.Age = 100;
            // Console.WriteLine(bueaty.Age);
            //Console.WriteLine(bueaty.Height);
            //Child money = new Child();
            //Console.WriteLine(money.Tomoney);
            //school("yuanzhan");
            //Date date = new Date();
            //Beautyliu liu = new Beautyliu();
            //liu.beauty = 30;

            //使用object改造数据结构栈（Stack），并在出栈时获得出栈元素      
            //ObjectHomeWork objectHomeWork = new ObjectHomeWork(new object[] { });
            //objectHomeWork.Array();

            //泛型
            //Generic<int> generic = new Generic<int>(4);
            //Console.WriteLine(generic.Age);
            //用泛型改造之前代码，包括：取最大值、冒泡排序、快速排序

            //Max(new int[] { 2, 4, 3, 7, 9, 5, 6, 8, 0 });



            //foreach遍历数组
            //ForEach(new int[]{2,3 });

            //冒泡排序
            Sort sort = new Sort();
            sort.bubbleSort(new int[] { 2, 3,3,9,12,33,44,2,7, 2, 5, 8, 5, 9, 5, 7, 1, 4, 5 });

            Console.Read();
        }

        static void ForEach<T>(T[] array)
        {
            foreach(T j in array){
                Console.WriteLine(j);
            }
        }

        static void Max(int[] array)
        {
            int max = array[0];
            Console.WriteLine($"最大值的初始值为:{max}");
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}>{max},目前最大值为{array[i]}"); max = array[i];

                }
                else
                {
                    Console.WriteLine($"第{i}次比较，{array[i]}<={max},最大值不变" + max);
                }
            }
            Console.WriteLine($"最终结果，最大值为{max}");
        }

        static void school(string name)
        {

            char[] input = name.ToCharArray();
            char[] output = new char[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }

            Console.WriteLine(output);
        }

        static void Date()
        {
            DateTime date = new DateTime(2019, 1, 1);
            for (int day = 1; day < 7; day++)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    break;
                }
                else
                {
                    date = date.AddDays(1);
                }
            }
            Console.WriteLine($"{date.Year}年{date.Month}月{date.Day}日为该年第一个星期一");

            int week = 1;
            bool success = false;

            DateTime expiryDate = date;
            while (!success)
            {
                if (expiryDate.Year < 2020)
                {
                    DateTime Todate = date.AddDays((7 * week) - 7);
                    Console.Write($"第{week}周:{Todate.Year}年{Todate.Month}月{Todate.Day}日-");
                    expiryDate = date.AddDays(7 * week - 1);
                    Console.WriteLine($"{expiryDate.Year}年{expiryDate.Month}月{expiryDate.Day}日");
                    Console.WriteLine();
                    week++;
                }
                else
                {
                    success = false;
                }
            }
        }


    }

    class Mimicstact
    {
        private object[] array = null;
        private int top;
        public Mimicstact(int Length)
        {
            array = new object[Length];
        }
        internal void Push(params object[] value)
        {

            if (top == array.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    array[top] = value[i];
                    top++;
                    Console.Write($"{value[i]},");
                }

                Console.WriteLine("入栈");

                ArrayShow.Inline(array);
                Console.WriteLine();
                Console.WriteLine("--------------------");
            }



        }
        internal void pop()
        {
            Console.WriteLine($"{array[top - 1]}出栈");
            array[top - 1] = 0;
            top--;
            ArrayShow.Inline(array);
            Console.WriteLine();
            Console.WriteLine("--------------------");
            if (top == array.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else if (top == 0)
            {
                Console.WriteLine("栈已空");
            }
        }

    }
    class ArrayShow
    {
        internal static void Inline(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + "   ");
            }
        }
    }
    class Bueaty
    {
        //internal readonly int Age;
        //internal int Height;
        private int Age;
        public Bueaty(int age)
        {

            Age = age;
        }
        //public int toBueaty
        //{
        //    get{ return Age; }

        //  //  set { Age = value; }
        //}
        public int toBueaty { get; private set; } = 100;
        //public Bueaty(int age, int height)
        //{
        //    Age = age;
        //    Height = height;
        //}

        //public int Bueatyheight(int height)
        //{
        //    Height = height;
        //    return Height;
        //}

    }
    class Date
    {
        internal DateTime date1 = new DateTime(2019, 3, 6);

        internal Date()
        {
            Console.WriteLine($"当前日期{date1.Year}年{date1.Month}月{date1.Day}日请输入：");
            string input = Convert.ToString(Console.ReadLine());
            string integer = input.Substring(0, input.Length - 1);
            string Chinese = input.Substring(input.Length - 1);
            int integer1 = Convert.ToInt32(integer);
            if (Chinese == "周")
            {
                DateTime end = date1.AddDays(integer1 * 7);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
            if (Chinese == "月")
            {
                DateTime end = date1.AddMonths(integer1);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
            if (Chinese == "日")
            {
                DateTime end = date1.AddDays(integer1);
                Console.WriteLine($"{input}过后的日期为：{end.Year}年{end.Month}月{end.Day}日");
            }
        }

    }


    internal class FG<T> where T: IComparable/*, IConvertible*/
    {
        //public FG(T a, T b)
        //{
            
        //    if (a.CompareTo(b)>0)
        //    {
                               
        //    }
        //}

   
    }

    class Beautyliu
    {
        private int _age;
        //internal int beauty
        //{
        //    get { return _age; }
        //    //set { _age = 20; }
        //}

        //internal int beauty { get;private set; }
        //internal int Age { get; set; } = 28;

        public int beauty
        {
            get => _age;
            //set => _age = 18;
            set { _age = 18; }
        }

        //public Beauty()
        //{

        //}




    }
}

