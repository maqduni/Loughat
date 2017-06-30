using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loughat.Tests;

namespace Loughat.Tests.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var seedTest = new Seed();
            seedTest.GenerateAlphabet();

            Console.Read();
        }
    }
}
