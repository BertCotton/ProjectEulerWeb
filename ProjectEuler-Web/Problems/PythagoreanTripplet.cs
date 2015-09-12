using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerWeb.Problems
{
    class PythagoreanTripplet
    {
        public long FindProduct(long targetSum)
        {
            for(long a = 1;a < targetSum ; a++)
            {
                for(long b = 1; (a + b) < targetSum;b++)
                {
                    for(long c = 1;(a + b + c) <= targetSum;c++)
                    {
                        if (a + b + c == targetSum && isPythagoreanTriplet(a, b, c))
                            return (a * b * c);
                    }
                }
            }
            return 0;
        }

        private bool isPythagoreanTriplet(long a, long b, long c)
        {
            return (a * a) + (b * b) == (c * c);
        }
    }
}
