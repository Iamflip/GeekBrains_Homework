using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            char[] reverseWord = new char[word.Length];
            for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
            {
                reverseWord[i] = word[j];
            }
            string newWord = new string(reverseWord);
            Console.WriteLine(newWord);
        }
    }
}
