using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"Число {number} чётное");
            else
                Console.WriteLine($"Число {number} не чётное");
            Console.ReadLine();
        }
    }
}
