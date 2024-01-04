using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class HeapSort
    {
        // use binary tree format (MaxHeap in this case)

        public static void Driver(int[] array)
        {
            int length = array.Length;
            //build Heap (rearrange array)
            for (int i = length/2-1; i >=0; i--)
            {
                Heapify(array, length,i);
            }
            // one by one remove an element from the heap
            // moove the current root to the end
            for (int i = length-1; i >=0; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0);
            }

        }
        public static void Heapify(int[] array, int length, int i)
        {
            int max = i;
            int l = 2 * i + 1;//child node left
            int r = 2 * i + 2;//child node right
            
            if (l < length && array[max] < array[l] )
            {
                max = l;
            }
            if ( r < length && array[max] < array[r])
            {
                max = r;
            }
            if (max != i)
            {
                (array[i], array[max]) = (array[max], array[i]);
                Heapify(array, length, max);
            }

        }
    }
}
