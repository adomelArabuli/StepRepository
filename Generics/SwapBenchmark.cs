using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    [MemoryDiagnoser]
    public class SwapBenchmark
    {
        [Benchmark]
        public void GenericSwapBenchmark()
        {
            double a = 1;
            double b = 5.7;
            SwapTestClass.GenericSwap(ref a, ref b);
        }

        [Benchmark]
        public void NonGenericSwapBenchmark()
        {
            object a = 1;
            object b = 5.7;
            SwapTestClass.Swap(ref a, ref b);
        }
    }
}
