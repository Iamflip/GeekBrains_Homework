using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
    class Program
    {
        static int[,] area;
        static void Main(string[] args)
        {
            AreaSize();
            Console.WriteLine(CalculateWays(area.GetLength(0) - 1, area.GetLength(1) - 1));
        }
        static int CalculateWays(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 1;
            }
            if (a >= 0 && b>= 0)
            {
                if (area[a,b] > 0)
                {
                    return area[a, b];
                }
            }
            int result = CalculateWays(a - 1, b) + CalculateWays(a, b - 1);

            if (a >= 0 && b >= 0)
            {
                area[a, b] = result;
            }

            return result;
        }
        static void AreaSize()
        {
            Console.WriteLine("Введите количество рядов");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int column = int.Parse(Console.ReadLine());

            area = new int[row, column];
        }
    }
}
