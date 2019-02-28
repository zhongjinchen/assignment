using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var span = DateTime.Now - new DateTime(2019,1,1);
            //Console.WriteLine(span);
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
            
            for (int week = 1; week < 53; week++)
            {
                DateTime Todate = date.AddDays(7 * week-7);
                Console.Write($"第{week}周:{Todate.Year}年{Todate.Month}月{Todate.Day}日-");
                DateTime Expirydate = date.AddDays(7 * week-1);
                Console.WriteLine($"{Expirydate.Year}年{Expirydate.Month}月{Expirydate.Day}日");
                Console.WriteLine();
            }




            Console.Read();
        }
    }
}
