using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что то");
            string text = Console.ReadLine();
            WriteFile(text);
        }
        
        static void WriteFile(string text)
        {
            File.WriteAllText("text.txt", text);
        }
    }
}
