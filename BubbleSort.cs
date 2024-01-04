using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class BubbleSort
    {
        // Compare i and i+1 and push the greater right and so on...
        public static void Driver(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for(int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}
