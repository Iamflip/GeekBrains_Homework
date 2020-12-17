using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1,999);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i,i]);
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("\t");
                }
            }

            Console.WriteLine();

            for (int i = array.GetLength(0) - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i,i]);
                for (int k = array.GetLength(0) ; k > i; k--)
                {
                    Console.Write("\t");
                }
            }

            Console.WriteLine();

            for (int i = 0, j = array.GetLength(0) - 1 ; i < array.GetLength(0); i++, j--)
            {
                Console.WriteLine(array[i,j]);
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("\t");
                }
            }

            Console.WriteLine();

            for (int i = array.GetLength(0) -1, j = 0; i >= 0; i--, j++)
            {
                Console.WriteLine(array[i,j]);
                for (int k = array.GetLength(0); k > i; k--)
                {
                    Console.Write("\t");
                }
            }
        }
    }
}
