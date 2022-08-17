using BenchmarkDotNet.Running;
using System;

namespace BenchmarkIntegerConverters
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkCollection>();
            //BenchmarkCollection n = new BenchmarkCollection();
            //n.TestAccess();
        }
    }
}
