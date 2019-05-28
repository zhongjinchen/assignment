using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    //冒泡排序
    class Sort
    {
        internal void bubbleSort(int[] array)
        {
            int swap;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = swap;

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
