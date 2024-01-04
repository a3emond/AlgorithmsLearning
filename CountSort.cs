using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class CountSort
    {
        public static void Driver(int[] array)
        {
            int[] outputArray = Sort(array);
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = outputArray[i];
            }
        }
        public static int[] Sort (int[] inputArray)
        {
            int length = inputArray.Length;
            int max = 0;
            // get max value of inputArray
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, inputArray[i]);
            }
            // create a count array with length = max value +1 filled with zeros
            int[] countArray = new int[max + 1];

            // get the number of time each value is contain in input array and add that count to the index equal to the value in the count array
            for (int i = 0;i < length; i++)
            {
                countArray[inputArray[i]]++;
            }
            //store cummulative sum of the countArray element (actif = actif + precedent)
            for (int i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }
            // create outputArray
            int[] outputArray = new int[length];
            for (int i =  length - 1; i >= 0; i--)
            {
                outputArray[countArray[inputArray[i]]-1] = inputArray[i];
                countArray[inputArray[i]]--;
            }

            return outputArray;

        }
            

    }
}
