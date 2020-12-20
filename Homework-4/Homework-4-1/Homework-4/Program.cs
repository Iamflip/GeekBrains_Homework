using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Goga";
            string name2 = "Radik";
            string name3 = "Misha";

            string lastName1 = "Gigov";
            string lastName2 = "Gorohov";
            string lastName3 = "Putin";

            string patronymic1 = "Aleksandrovich";
            string patronymic2 = "Valerevich";
            string patronymic3 = "Olegovich";

            string fullName1 = GetFullName(name1, lastName1, patronymic1);
            string fullName2 = GetFullName(name2, lastName2, patronymic2);
            string fullName3 = GetFullName(name3, lastName3, patronymic3);

            Console.WriteLine(fullName1);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);

        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
    }
}
