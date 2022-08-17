using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkIntegerConverters
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkIntParser
    {
        public const string NumberAsString = "2021";
        private static readonly IntParser Parser = new IntParser();

        [Benchmark]
        public void ParseNumberFromString()
        {
            Parser.ParseIntFromString(NumberAsString);
        }

        [Benchmark]
        public void ConvertIntFromString()
        {
            Parser.ConvertIntFromString(NumberAsString);
        }

        [Benchmark]
        public void GetIntFromStringManual()
        {
            Parser.GetIntFromStringManual(NumberAsString);
        }
    }
}
