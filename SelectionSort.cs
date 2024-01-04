using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class SelectionSort
    {
        // find the smallest, swap it with active index, move to the next index and continue until reaching the end (0 to array.length-1)  
        public static void Driver(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                (array[i], array[min]) = (array[min], array[i]);
            }
        }
    }
}
