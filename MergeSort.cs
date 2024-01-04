using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class MergeSort
    {
        public static void Driver(int[] array)
        {
            if (array.Length <= 1) return;
            int[] left = new int[array.Length/2];
            int[] right = new int[array.Length - left.Length];
            for (int i = 0;i < array.Length; i++)
            {
                if (i < left.Length)
                {
                    left[i] = array[i];
                }
                else
                {
                    right[i-left.Length] = array[i];
                }
            }
            Driver(left);
            Driver(right);
            Merge(array, left, right);
        }
        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0;
            int l = 0;
            int r = 0;
            while (l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                {
                    array[i] = left[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = right[r];
                    i++;
                    r++;
                }
            }
            while (l < left.Length)
            {
                array[i] = left[l];
                i++;
                l++;
            }
            while(r < right.Length)
            {
                array[i] = right[r];
                i++;
                r++;
            }
        }
    }
}
