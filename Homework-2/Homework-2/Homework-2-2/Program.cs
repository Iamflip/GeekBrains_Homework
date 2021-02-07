using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    class Program
    {
    /* Изначально хотел сделать данное задание через перечисления
     * Но не понял как это можно реализовать*/
        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрел,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октрябль,
            Ноябрь,
            Декабрь
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер текущего месяца");
            int numberOfMonth = int.Parse(Console.ReadLine());
            switch(numberOfMonth)
            {
                case 1:
                    Console.WriteLine("Сейчас январь");
                    break;
                case 2:
                    Console.WriteLine("Сейчас февраль");
                    break;
                case 3:
                    Console.WriteLine("Сейчас март");
                    break;
                case 4:
                    Console.WriteLine("Сейчас апрель");
                    break;
                case 5:
                    Console.WriteLine("Сейчас май");
                    break;
                case 6:
                    Console.WriteLine("Сейчас июнь");
                    break;
                case 7:
                    Console.WriteLine("Сейчас июль");
                    break;
                case 8:
                    Console.WriteLine("Сейчас август");
                    break;
                case 9:
                    Console.WriteLine("Сейчас сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Сейчас октябрь");
                    break;
                case 11:
                    Console.WriteLine("Сейчас ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Сейчас декабрь");
                    break;
                default:
                    Console.WriteLine("Введены неверные данные");
                    break;
            }
        }
    }
}
