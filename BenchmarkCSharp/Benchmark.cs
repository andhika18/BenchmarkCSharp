using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenchmarkIntegerConverters
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmark
    {
        private int[] _number = Enumerable.Repeat(1, 1000).ToArray();

        private static readonly LoopFunction _loop = new LoopFunction();

        [Benchmark]
        public void WhileLoopTest()
        {
            _loop.WhileLoop(_number);
        }

        [Benchmark]
        public void DoWhileLoopTest()
        {
            _loop.DoWhileLoop(_number);
        }

        [Benchmark]
        public void ForLoopTest()
        {
            _loop.ForLoop(_number);
        }

        [Benchmark]
        public void ForeachLoopTest()
        {
            _loop.ForeachLoop(_number);
        }
    }
}
