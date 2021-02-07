using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] names = { "Миша", "Петя", "Ваня", "Гриша", "Вася", "Дима", "Рома", "Влад", "Егор" };
            int[] numbers = { 524016, 449782, 578966, 410062, 787451, 360099, 416782, 398564 };
            string[,] array = new string[5, 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; )
                {
                    array[i, j] = names[rnd.Next(0, names.Length)];
                    j++;
                    array[i,j] = PickNumber(names, numbers, rnd, array);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }
            Console.ReadLine();
        }

        //Метод который подбирает номер для следующего человека, проверяя, не был ли этот номер уже был исользован
        //В случае если был использован, подбирает другой
        static string PickNumber(string[] names, int[] numbers, Random rnd, string[,] array)
        {
            string temp = Convert.ToString(numbers[rnd.Next(0, numbers.Length)]);
            for (int i = 0, j = 1; i < array.GetLength(0) - 1; i++)
            {
                if (array[i,j] == temp)
                {
                    temp = Convert.ToString(numbers[rnd.Next(0, numbers.Length)]);
                    j = 0;
                }
            }
            return temp;
        }
    }
}
