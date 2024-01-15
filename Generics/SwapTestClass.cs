using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class SwapTestClass
    {
        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref object x, ref object y)
        {
            object temp = x;
            x = y;
            y = temp;
        }
    }
}
