using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class ObjectHomeWork
    {

        //构造一个能装任何数据的数组，并完成数据的读写
        public object[] array;
        public ObjectHomeWork(object [] Array)
        {
            array = Array;

        }

        public void Array()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }
          
}
}
