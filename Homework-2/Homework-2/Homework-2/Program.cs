using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxTemperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру за сутки");
            double minTemperature = int.Parse(Console.ReadLine());
            Console.WriteLine($"Средняя температура за сутки {(minTemperature + maxTemperature) / 2} C");
            Console.ReadLine();
        }
    }
}
