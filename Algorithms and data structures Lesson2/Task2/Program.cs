using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max) 
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid; 
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int [] testArray = { 10, 20, 30, 35, 40, 50, 60 };
            int found = BinarySearch(testArray, 30); //O(log(n))
            Console.WriteLine(found);
        }
    }
}
