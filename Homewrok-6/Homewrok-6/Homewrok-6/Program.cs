using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = VievProcesses();
            int chose = Choose();
            switch (chose)
            {
                case 1:
                    Console.WriteLine("Введите название процесса");
                    string name = Console.ReadLine();
                    KillProcessByName(name, processes);
                    break;
                case 2:
                    Console.WriteLine("Введите ID процесса");
                    int number = int.Parse(Console.ReadLine());
                    KillProcessByID(number, processes);
                    break;
                default:
                    Console.WriteLine("Неверные данные");
                    break;
            }
        }
        static Process[] VievProcesses()
        {
            Console.WriteLine("Process Name & Process Id");
            Process[] process = Process.GetProcesses();
            for (int i = 0; i < process.Length; i++)
            {
                Console.WriteLine($"{process[i].ProcessName} -- {process[i].Id}");
            }
            return process;
        }
        static int Choose()
        {
            Console.WriteLine("Выберите метод уничтожения процесса - 1. По названию  2. По ID");
            int choose = int.Parse(Console.ReadLine());
            return choose;
        }
        static void KillProcessByName(string name, Process [] processes)
        {
            List<Process> proc = new List<Process>();

            for (int i = 0; i < processes.Length; i++)
            {
                if (name == processes[i].ProcessName)
                {
                    proc.Add(processes[i]);
                }
            }
            switch (proc.Count)
            {
                case 1:
                    proc[0].Kill();
                    Console.WriteLine("Процесс успешно остановлен");
                    break;
                case 0:
                    Console.WriteLine("Процессов с таким именем не обнаружено");
                    break;
                default:
                    Console.WriteLine($"Было найдено {proc.Count} процессов с данным именем" +
                        $"выберите нужный процесс по ID");
                    for (int i = 0; i < proc.Count; i++)
                    {
                        Console.WriteLine($"{proc[i].ProcessName} {proc[i].Id}");
                    }
                    Console.WriteLine("Введите ID процесса");
                    int number = int.Parse(Console.ReadLine());
                    KillProcessByID(number, processes);
                    break;
            }
        }
        static void KillProcessByID(int number, Process [] processes)
        {
            for (int i = 0; i < processes.Length; i++)
            {
                if (number == processes[i].Id)
                {
                    processes[i].Kill();
                    Console.WriteLine("Процесс успешно уничтожен");
                    return;
                }
            }
            Console.WriteLine("Такого процесса не обнаружено");
        }
    }
}
