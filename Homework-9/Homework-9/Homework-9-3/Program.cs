using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(20));
        }
        static int FibbonachiRec (int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }

            return (FibbonachiRec(n - 1) + (FibbonachiRec(n - 2)));
        }

        static int Fibonachi (int n)
        {
            int x = 0;
            int y = 1;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = x;
                x = y;
                y += temp;
            }
            return x;
        }
    }
}
