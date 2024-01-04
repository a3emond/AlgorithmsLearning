using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class QuickSort
    {
        // put the pivot (last element) at its position by putting all smaller values before (si c plus petit tu l'envoye en avant)
        public static void Driver(int[] array, int start, int end)
        {
            if (end <= start) return;
            int pivot = Partition(array, start, end);
            // want to exclude the current pivot from the next iterations
            Driver(array, start, pivot-1);
            Driver(array, pivot+1, end );

        }
        public static int Partition(int[] array, int start, int end)
        {
            int i = start;
            int j = i - 1;
            int pivot = array[end];
            for (;i < end; i++)
            {
                if (array[i] < pivot)
                {
                    j++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            j++;
            (array[i], array[j]) = (array[j], array[i]);
            return j;
        }
    }
}
