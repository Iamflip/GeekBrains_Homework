using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_3
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            int numberOFSeason = Validation();
            Season season = FindSeason(numberOFSeason);
        }
        static Season FindSeason (int numberOfSeason)
        {

            if (numberOfSeason == 12 || numberOfSeason == 1 || numberOfSeason == 2)
            {
                return Season.Winter;
            }
            else if (numberOfSeason > 2 && numberOfSeason < 6)
            {
                return Season.Spring;
            }
            else if (numberOfSeason > 5 && numberOfSeason < 9)
            {
                return Season.Summer;
            }
            else 
            {
                return Season.Autumn;
            }

        }
        static int Validation()
        {
            Console.WriteLine("Введите номер месяца");
            int numberOfSeason = int.Parse(Console.ReadLine());
            bool isOkay = false;
            while (!isOkay)
            {
                if (numberOfSeason < 1 || numberOfSeason > 12)
                {
                    Console.WriteLine("Ошибка, введите число от 1 до 12");
                }
            }
            return numberOfSeason;
        }
        static void WriteSeason (Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine($"Now is {Season.Autumn}");
                    break;
                case Season.Spring:
                    Console.WriteLine($"Now is {Season.Spring}");
                    break;
                case Season.Summer:
                    Console.WriteLine($"Now is {Season.Summer}");
                    break;
                case Season.Winter:
                    Console.WriteLine($"Now is {Season.Winter}");
                    break;
            }
        }
    }
}
