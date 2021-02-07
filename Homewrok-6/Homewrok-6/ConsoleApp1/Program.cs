using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"C:\Новая папка\1.txt");
            Process[] pr = Process.GetProcessesByName("notepad");
        }
    }
}
