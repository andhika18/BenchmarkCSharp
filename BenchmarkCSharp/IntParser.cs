using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkIntegerConverters
{
    public class IntParser
    {
        public int ParseIntFromString(string numberAsString)
        {
            return int.Parse(numberAsString);
        }

        public int ConvertIntFromString(string numberAsString)
        {
            return Convert.ToInt32(numberAsString);
        }

        public int GetIntFromStringManual(ReadOnlySpan<char> numberAsSpan)
        {
            var num = 0;
            for (int i = 0; i < numberAsSpan.Length; i++)
            {
                num = num * 10 + (numberAsSpan[i] - '0');
            }
            return num;
        }
    }
}
