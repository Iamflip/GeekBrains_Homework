using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();

            int[] values = new int [] { 50, 25, 75, 12, 40, 60, 80, 10, 55 };

            for (int i = 0; i < values.Length; i++)
            {
                tree.Add(values[i]);
            }

            tree.Delete(75);

            tree.DFC();
        }
    }
}
