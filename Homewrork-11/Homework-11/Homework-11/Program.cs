using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Homework_11
{
    /// <summary>
    /// | Method |      Mean |     Error |    StdDev |
    ///|------- |----------:|----------:|----------:|
    ///|  Test1 | 3.0763 ns | 0.0881 ns | 0.0824 ns |
    ///|  Test2 | 3.3491 ns | 0.0461 ns | 0.0409 ns |
    ///|  Test3 | 0.0000 ns | 0.0000 ns | 0.0000 ns |
    ///|  Test4 | 1.7386 ns | 0.0722 ns | 0.0709 ns |
    /// </summary>
    /// 

   
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    /// <summary>
    /// Была ещё мысль создать массив на N количество элементов и в проверку передавать весь массив, а внутри массива циклом прогонять элементы, но боюсь 
    /// это займёт слишком много времени
    /// </summary>
    public class PointClass
    {
        public float X;
        public float Y;
    }
    public struct PointStruct
    {
        public float X;
        public float Y;
    }
    public struct PointDouble
    {
        public double X;
        public double Y;
    }
    public class BechmarkClass
    {
        PointClass a = new PointClass();
        PointClass b = new PointClass();

        PointStruct a1 = new PointStruct();
        PointStruct b1 = new PointStruct();

        PointStructDouble a2 = new PointStructDouble();
        PointStructDouble b2 = new PointStructDouble();

        public float DistanceRef(PointClass pointClass1, PointClass pointClass2)
        {
            float X = pointClass1.X - pointClass2.X;
            float Y = pointClass2.Y - pointClass2.Y;
            return (float)Math.Sqrt((X * X) + (Y * Y));
        }
        public float DistanceVal(PointStruct pointStruct1, PointStruct pointStruct2)
        {
            float X = pointStruct1.X - pointStruct2.X;
            float Y = pointStruct1.Y - pointStruct2.Y;
            return (float)Math.Sqrt((X * X) + (Y * Y));
        }
        public double DistanceValDouble(PointStructDouble pointStructDouble1, PointStructDouble pointStructDouble2)
        {
            double X = pointStructDouble1.X - pointStructDouble2.X;
            double Y = pointStructDouble1.Y - pointStructDouble2.Y;
            return Math.Sqrt((X * X) + (Y * Y));
        }
        public float DistanceValShort(PointStruct pointStruct1, PointStruct pointStruct2)
        {
            float X = pointStruct1.X - pointStruct2.X;
            float Y = pointStruct1.X - pointStruct2.Y;
            return (X * X) + (Y * Y);
        }

        [Benchmark]
        public void Test1()
        {
            DistanceRef(a, b);
        }
        [Benchmark]
        public void Test2()
        {
            DistanceVal(a1, b1);
        }
        [Benchmark]
        public void Test3()
        {
            DistanceValDouble(a2, b2);
        }
        [Benchmark]
        public void Test4()
        {
            DistanceValShort(a1, b1);
        }
    }
}
