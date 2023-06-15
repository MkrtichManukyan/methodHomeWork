using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHomeWork
{
    internal class Fibonacci
    {
        public int FibonacciFunction(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            else
            {
                return FibonacciFunction(n - 1) + FibonacciFunction(n - 2);
            }

        }
    }
}
