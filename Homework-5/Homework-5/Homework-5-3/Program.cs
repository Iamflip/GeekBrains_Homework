using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_3
{
    class Program
    {

        //Почему то записывает все данные как нули
        //Пытался реализовать без цикла строкой File.WriteAllText("BeFile.bin", num.ToString());
        //Но тогда записывать просто System.Int32[]
        static void Main(string[] args)
        {
            int[] numbers = CreateNumbers();
            BiFile(numbers);
        }
        static void BiFile(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                File.AppendAllText("BeFile.bin", num[i].ToString());
            }
        }
        static int[] CreateNumbers()
        {
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = CheckNumber();
            }
            return nums;
        }
        static bool Validation(int temp)
        {
            if (temp < 0 || temp > 255)
            {
                return false;
            }

            return true;
        }
        static int CheckNumber()
        {
            Console.WriteLine("Введите 5 чисел от 0 до 255");
            int num = 0;
            bool IsDone = false;

            while (!IsDone)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if(Validation(num))
                    {
                        IsDone = true;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное число, попробуйте ещё раз");
                    }
                }
                catch
                {
                    Console.WriteLine("Введены неверные данные");
                }
            }

            return num;
        }
    }
}
