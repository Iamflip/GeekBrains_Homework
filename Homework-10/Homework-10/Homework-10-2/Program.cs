using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0; // O(1)
            int max = inputArray.Length - 1; //O(N)
            while (min <= max) //O(1+N) == O(N)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[max])
                {
                    return mid; //O(1)
                }
                else if (searchValue < mid)
                {
                    mid = max - 1; //O(1)
                }
                else
                {
                    mid = max + 1; //O(1)
                }
            }
            return -1;
        }
    }
}
