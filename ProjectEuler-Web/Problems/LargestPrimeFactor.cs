using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerWeb.Problems
{
    class LargestPrimeFactor
    {
        public Int64 getLargestPrimeFactor(Int64 input)
        {
            Int64 sqrRt = Convert.ToInt64(Math.Round(Math.Sqrt(input), 0));

            for (Int64 i = sqrRt; i > 0; i--)
            {
                // Since we are counting down we can stop once we find the first one
                if (input % i == 0 && isPrime(i))
                    return i;
            }
            return 1;
        }

        private Boolean isPrime(Int64 input)
        {
            for (Int64 i = Convert.ToInt64(Math.Round(Math.Sqrt(input), 0)); i > 1; i--)
                if (input % i == 0)
                    return false;
            return true;
            
        }
    }
}
