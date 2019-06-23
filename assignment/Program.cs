using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Threading;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            callMethod.referenceTypeCast();

            callMethod.getSet();

            callMethod.toRepeat();

            callMethod.XML();

            ArticleFactory.inti();

            Console.Read();
        }

        private static void Button_OnClick(object sender, EventArgs e)
        {
            Console.WriteLine("点击事件");
        }
        static void ForEach<T>(T[] array)
        {
            foreach (T j in array)
            {
                Console.WriteLine(j);
            }
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
        static IList<string> removeRepeat(string path)
        {
            IEnumerable<string> emailFile = File.ReadLines(path);
            IList<string> emailList = new List<string>();
            int x = 0, y = 0;
            foreach (var item in emailFile)
            {

                string[] email = item.Split(";");
                using (StreamWriter writer = File.AppendText(@"C:\17bang\yzHomework\emailList.txt"))
                {
                    foreach (var i in email)
                    {
                        if (!emailList.Contains(i))
                        {
                            emailList.Add(i);
                            x++;

                            writer.Write(i + " ; ");

                            Console.Write(i + " ; ");
                            if (x == 30)
                            {
                                x = 0;
                                Console.WriteLine();
                                Console.WriteLine();
                                writer.WriteLine();
                                writer.WriteLine();

                            }
                        }
                        else
                        {
                            y++;
                        }
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"有{y}处重复被去除");
            //StreamWriter writer = File.CreateText(@"C:\17bang\yzHomework\emailList.txt");



            return emailList;
        }
        static void removeRepeatTest()
        {

            IList<string> emailList = new List<string>();
            foreach (var item in removeRepeat(@"C:\17bang\yzHomework\email.txt"))
            {
                if (!emailList.Contains(item))
                {
                    emailList.Add(item);
                }
                else
                {
                    Console.WriteLine("有重复");
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
    class Date
    {
        internal DateTime date1 = new DateTime(2019, 3, 6);

        internal void DateCalculation()
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
    internal class FG<T> where T : IComparable, IConvertible
    {
        //public FG(T a, T b)
        //{

        //    if (a.CompareTo(b)>0)
        //    {

        //    }
        //}
        internal void Max(T[] array)
        {
            T max = array[0];
            Console.WriteLine($"最大值的初始值为:{max}");
            for (int i = 1; i < array.Length; i++)
            {             //泛型不能用运算符
                if (array[i].CompareTo(max) > 0)
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

    }

}

