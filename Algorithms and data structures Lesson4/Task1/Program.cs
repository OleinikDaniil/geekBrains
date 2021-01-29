using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Task1
{
    public class TestHash
    {
        public string RandomString { get; set; }
        public override bool Equals(object obj)
        {
            var thash = obj as TestHash;
            if (thash == null)
                return false;
            return RandomString == thash.RandomString;
        }
        public override int GetHashCode()
        {
            int randomStringHashCode = RandomString?.GetHashCode() ?? 0;
            return randomStringHashCode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class BenchmarkClass
    {
        [Benchmark]
        public void SearchHash()
        {
            var hashSet = new HashSet<TestHash>();
            string[] someStringMassive = new string[10001];
            for (int i = 0; i < 10000; i++)
            {
                if (i == 15)
                {
                    var preciseString = new TestHash() { RandomString = $"FoundYa" };
                    hashSet.Add(preciseString);
                    someStringMassive[15] = "FoundYa";
                }
                else
                {
                    var randomString = new TestHash() { RandomString = $"1" + i };
                    hashSet.Add(randomString);
                    someStringMassive[i] = "1" + i;
                }
            }
            var searchStr = new TestHash()
            {
                RandomString = "FoundYa",
            };
            hashSet.Contains(searchStr);
        }
        [Benchmark]
        public bool SearchMass()
        {
            string[] someStringMassive = new string[10001];
            for (int i = 0; i < 10000; i++)
            {
                if (i == 15)
                {
                    someStringMassive[15] = "FoundYa";
                }
                else
                {
                    someStringMassive[i] = "1" + i;
                }
            }
            for (int i = 0; i < 10000; i++)
            {
                if (someStringMassive[i] == "FoundYa")
                return true;
            }
            return false;
        }
    }
}
