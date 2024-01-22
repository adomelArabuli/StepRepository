using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void CallBackDelegate(int result);

    public delegate void OperationDelegate(int x, int y);
    internal class Calculator
    {
        public void Add(int a, int b, CallBackDelegate callBackDelegate)
        {
            int result = a+ b;
            callBackDelegate(result);
        }

        public void PerformOperation(int a, int b, OperationDelegate operation)
        {
            operation(a, b);
        }
    }
}
