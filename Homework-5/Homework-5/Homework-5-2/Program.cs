using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что то");
            string text = Console.ReadLine();
            WriteFileAndTimeNow(text);
        }
        static void WriteFileAndTimeNow(string text)
        {
            File.WriteAllText("startup.txt", text);
            File.AppendAllText("startup.txt", Environment.NewLine);
            File.AppendAllText("startup.txt", DateTime.Now.ToString());
        }
    }
}
