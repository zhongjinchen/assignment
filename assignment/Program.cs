using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mimicstact imitate = new Mimicstact(5);
            imitate.Push(8);
            imitate.Push(10);
            imitate.Push(4);
            imitate.Push(7);
            imitate.Push(5);
            Console.Read();
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
        private int[] array = null;
        private int top;
        private int max;
        public Mimicstact(int Length)
        {
            array = new int[Length];
        }
        internal void Push(int[]value)
        {
            for (int i = 0; i <value.Length; i++)
            {
                array[top] = value[i];
                top++;
            }
            Console.WriteLine($"{value}入栈");
           
            ArrayShow.Inline(array);
            Console.WriteLine();
            Console.WriteLine("------------------");
            if (top == array.Length)
            {
                Console.WriteLine("栈溢出");
            }
        }
        internal void pop()
        {
            Console.WriteLine($"{array[top - 1]}出栈");
            array[top - 1] = 0;
            top--;
            ArrayShow.Inline(array);
            Console.WriteLine();
            Console.WriteLine("------------------");
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
        internal static void Inline(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i] + "   ");
            }
        }
    }
}
