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
            //int i = 0;
            //DateTime secondyear = date;
            //bool nextYear = false;
            //while (!nextYear)
            //{
            //    //i++;
            //    //if(secondyear.Year > 2019)
            //    //{
            //    //    success = true;
            //    //    secondyear = date.AddDays(7*(i+1));

            //    //}
            //    //else
            //    //{
            //    //    success = false;
            //    //}

            //    date.AddDays(7);
            //    nextYear = date.Year > 2019;                
            //}

            //Console.WriteLine($"i={i}");
            int week = 1;
            bool success = false;
            DateTime expiryDate = date;
            while(!success)                          //for (int week = 1;week<4; week++)
            {
                if(expiryDate.Year <2020)
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




            Console.Read();
        }
    }
}
