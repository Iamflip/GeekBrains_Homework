using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_4
{
    class Program
    {
        //Я пытался но голова уже не варит, к следующему дз постараюсь сделать
        static void Main(string[] args)
        {
            CheckFiles(@"C:\Users\Iamflip\Desktop\GeekBrains_Howework\Homework-5\Homework-5\Homework-5-3");
        }
        static string CheckFiles(string directory)
        {
            int help = 0;
            string[] files = Directory.GetFiles(directory);
            string[] directories = Directory.GetDirectories(directory);

            if (Directory.GetFiles(directory).Length > 0)
            {
                CheckFiles(files[help]);

            }

            return files.ToString();

        }
    }
}
