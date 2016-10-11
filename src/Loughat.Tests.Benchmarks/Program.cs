using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Tests.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var seedTest = new Seed();
            seedTest.GenerateAbbreviations();

            Console.Read();
        }
    }
}
