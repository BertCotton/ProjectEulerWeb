using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerWeb.Problems
{
    class SummationOfPrimes
    {

        public long SumOfPrimes(long upperBound)
        {
            long summation = 0;
            for(long i = 2; i < upperBound; i++)
            {
                if (isPrime(i))
                    summation += i;
            }
            return summation;
        }

        private bool isPrime(long value)
        {
            for(long i = 2; i <= Math.Round(Math.Sqrt(value),0); i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}
