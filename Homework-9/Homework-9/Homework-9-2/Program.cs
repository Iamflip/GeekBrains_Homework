using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // O(1)
            for (int i = 0; i < inputArray.Length; i++) // N * N * N
            {
                for (int j = 0; j < inputArray.Length; j++) // N * N
                {
                    for (int k = 0; k < inputArray.Length; k++) // N
                    {
                        int y = 0;

                        if (j != 0) // O(1)
                        {
                            y = k / j; 
                        }

                        sum += inputArray[i] + i + k + j + y; // O(1)
                    }
                }
            }

            return sum; // O(1)
        } // N * N * N

    }
}
