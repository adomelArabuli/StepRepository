using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool CheckDelegate(int number);
    public static class PredicatDeligate
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
