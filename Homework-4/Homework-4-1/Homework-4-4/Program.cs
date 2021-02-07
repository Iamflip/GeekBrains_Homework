using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int fibonachiNum = Fibonachi(number);
            Console.WriteLine(fibonachiNum);
        }
        static int Fibonachi (int number)
        {
            if (number == 1 || number == 0)
            {
                return number;
            }

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }
    }
}
