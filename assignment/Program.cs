using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //seekMaxValue Seek = new BinaryChop();
            //seekMaxValue Seek = new violenceSeek();
            //显式实现
            //seekMaxValue Seek = new DisplayImplementation();
            seekMinValue Seek = new DisplayImplementation();
            Seek.seek();


            //Mimicstact imitate = new Mimicstact(5);
            //imitate.Push(new int[]{8});
            //imitate.Push(8,9);
            //imitate.pop();
            //imitate.Push(10);
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
            Console.Read();
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
        private int[] array = null;
        private int top;
        public Mimicstact(int Length)
        {
            array = new int[Length];
        }
        internal void Push(params int[] value)
        {
            for (int i = 0; i < value.Length; i++)
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

