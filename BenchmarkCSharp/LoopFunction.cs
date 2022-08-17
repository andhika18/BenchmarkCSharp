using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkIntegerConverters
{
    public class LoopFunction
    {
        public int WhileLoop(int[] data)
        {
            int result = 0;
            while (result < data.Length)
            {
                result++;
            }
            return result;
        }
        public int DoWhileLoop(int[] data)
        {
            int result = 0;
            do
            {
                result++;
            }
            while (result < data.Length);
            return result;
        }
        public int ForLoop(int[] data)
        {
            int result = 0;
            for(var i = 0; i < data.Length; i++)
            {
                result++;
            }
            return result;
        }
        public int ForeachLoop(int[] data)
        {
            int result = 0;
            foreach(var d in data)
            {
                result++;
            }
            return result;
        }

    }
}
