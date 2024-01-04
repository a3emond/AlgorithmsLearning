using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateIntArray();
            //Print Unsorted Array:
            Console.WriteLine("Unsorted Array:");
            PrintArray(array);
            //Active Sorting Algorithm:
            
            CountSort.Driver(array);
            //Print Sorted Array:
            Console.WriteLine("Sorted Array:");
            PrintArray(array);
            Console.ReadKey();

        }
        public static int[] GenerateIntArray()
        {
            Random random = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(101);
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("");
            foreach (int item in array)
            {
                Console.Write(item + "; ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
