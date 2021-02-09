using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "4 15 29 5 90 1 12 540";

            char[] nums = numbers.ToArray();

            int sum = Sum(nums);

            Console.WriteLine(sum);
            
        }
        static int Sum (char[] numbers)
        {
            string temp = "";
            int tempNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length -1)
                {
                    temp += numbers[i];
                    tempNumber += int.Parse(temp);
                    temp = "";
                    return tempNumber;
                }
                if (numbers[i] != ' ')
                {
                    temp += numbers[i];
                }
                else
                {
                    tempNumber += int.Parse(temp);
                    temp = "";
                }
            }
            return tempNumber;
        }
    }
}
