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
    interface ISleep
    {
        void Rest();
    }
    interface IBathe
    {
        void Swim();
    }
    public class Man: Eat, ISleep, IBathe
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
    //为找到最大值定义一个接口，并在“二分查找”和“暴力查找”中实现 
    
    internal interface IseekMaxValue
    {
        void seek();
    }
    internal interface IseekMinValue
    {
        void seek();
    }

    public class BinaryChop: IseekMaxValue
    {
        public void seek()
        {
            Console.WriteLine("二分查找");
        }
    }
    public class violenceSeek : IseekMaxValue
    {
        public void seek()
        {
            Console.WriteLine("暴力查找");
        }
    }

    //虚拟一个需要使用接口“显式实现”的场景，并实现之
    public class DisplayImplementation:IseekMaxValue,IseekMinValue
    {
        void IseekMaxValue.seek()
        {
            Console.WriteLine("查找最大值");
        }
        void IseekMinValue.seek()
        {
            Console.WriteLine("查找最小值");
        }
    }
}
