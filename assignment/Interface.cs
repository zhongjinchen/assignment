using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public  class Eat
    {
        public  void Lunch()
        {
            Console.WriteLine("吃午饭");
        }
    }
    interface Sleep
    {
        void Rest();
    }
    interface Bathe
    {
        void Swim();
    }
    public class Man: Eat, Sleep, Bathe
    {
        public void Rest()
        {
            Console.WriteLine("休息");
        }
        public void Swim()
        {
            Console.WriteLine("游泳");
        }
    }
}
