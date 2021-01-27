using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchMark b = new BenchMark();
            b.Go();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            //| Method | Mean | Error | StdDev | Median |
            //| ------- | --------------:| ------------:| ------------:| --------------:|
            //| Test1 | 27,677.258 ns | 486.1975 ns | 597.0942 ns | 27,721.013 ns |
            //| Test2 | 5.341 ns | 0.1375 ns | 0.2682 ns | 5.221 ns |

        }


    }
    public class Words
    {
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            Words word = obj as Words;

            if (word == null)
                return false;

            return Value == word.Value;
        }
        public override int GetHashCode()
        {
            int valueHashCode = Value?.GetHashCode() ?? 0;
            return valueHashCode;
        }
    }
    public class BenchMark
    {
        string[] words = new string[10000];
        Words [] wordsClass = new Words[10000];

        HashSet<Words> Hashset = new HashSet<Words>();

        public void Go()
        {
            RandomStrings(words);
            Initialize(wordsClass, words);
            ContainHashSet(Hashset, wordsClass);
        }


        public void RandomStrings(string[] words)
        {
            Random rnd = new Random();
            string word = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    word += (char)rnd.Next(97, 123);
                }
                words[i] = word;
                word = "";
            }
        }
        public void Initialize(Words[] wordsClass, string[] words)
        {
            for (int i = 0; i < wordsClass.Length; i++)
            {
                wordsClass[i] = new Words();
                wordsClass[i].Value = words[i];
            }
        }
        public void ContainHashSet(HashSet<Words> hashWordss, Words[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                hashWordss.Add(words[i]);
            }
        }


        public string FindInArray(string[] words, string value)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (value.Equals(words[i]))
                {
                    return words[i];
                }
            }
            return "";
        }
        public void FindInHashSet(HashSet<Words> words, Words value)
        {
            words.Contains(value);
        }

        [Benchmark]
        public void Test1()
        {
            FindInArray(words, "aaaaa");
        }
        [Benchmark]
        public void Test2()
        {
            FindInHashSet(Hashset, new Words { Value = "aaaaa" });
        }
    }
}
