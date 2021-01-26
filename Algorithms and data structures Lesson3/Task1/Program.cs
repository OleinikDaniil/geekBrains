using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Prog
{

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BenchmarkClass
    {
        public class PointClass
        {
            public int X;
            public int Y;

            public PointClass(int a, int b) { X = a; Y = b; }
        }

        public struct PointStruct
        {
            public int X;
            public int Y;
            public PointStruct(int a, int b) { X = a; Y = b; }
        }

        PointClass pointOneClass = new PointClass(10,20);
        PointClass pointTwoClass = new PointClass(30,13);
        PointStruct pointOneStruct = new PointStruct(12, 22);
        PointStruct pointTwoStruct = new PointStruct(22, 32);
        public static float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static double PointDistanceStructDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceStructNoSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }
        [Benchmark]
        public void testClass()
        {
            PointDistanceClass(pointOneClass, pointTwoClass);
        }
        [Benchmark]
        public void testStructFloat()
        {
            PointDistanceStruct(pointOneStruct, pointTwoStruct);
        }
        [Benchmark]
        public void testStructDouble()
        {
            PointDistanceStructDouble(pointOneStruct, pointTwoStruct);
        }
        [Benchmark]
        public void testStructNoSqrt()
        {
            PointDistanceStructNoSqrt(pointOneStruct, pointTwoStruct);
        }
    }
}
