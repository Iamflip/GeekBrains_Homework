using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    class Program
    {
        //Хотел изначально сделать через одно условие if, но почему то нельзя делать выражение в виде
        // if (numberOfMontsh == 1 || 2 || 12)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            int numberOfMonth = int.Parse(Console.ReadLine());

            bool IsWitnter = false;

            if (numberOfMonth == 1)
                IsWitnter = true;
            else if (numberOfMonth == 2)
                IsWitnter = true;
            else if (numberOfMonth == 12)
                IsWitnter = true;

            Console.WriteLine("Введите среднюю температуру");
            int AverageTemperature = int.Parse(Console.ReadLine());
            if (IsWitnter && AverageTemperature > 0)
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
