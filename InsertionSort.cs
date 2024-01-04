using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class InsertionSort
    {
        // take an element (starting at index 1) compare it to the one before, if its bigger, move it to the right
        public static void Driver(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];
                while (j >= 0 && array[j] > temp)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1] = temp;

            }
        }
    }
}
