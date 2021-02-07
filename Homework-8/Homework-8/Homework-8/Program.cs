using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);

            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine("Введите ваше имя");
                Properties.Settings.Default.Name = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст");
                Properties.Settings.Default.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите вашу профессию");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string name = Properties.Settings.Default.Name;
            int age = Properties.Settings.Default.Age;
            string occupation = Properties.Settings.Default.Occupation;

            string result = $"Вас зовут {name}, Ваш возраст - {age}, Ваш род деятельностии - {occupation}";

            Console.WriteLine(result);
        }
    }
}
