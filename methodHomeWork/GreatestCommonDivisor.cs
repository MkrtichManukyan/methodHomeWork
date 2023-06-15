using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHomeWork
{
    internal class GreatestCommonDivisor
    {
        public int FindGreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return FindGreatestCommonDivisor(b, a % b);
        }
    }
}
