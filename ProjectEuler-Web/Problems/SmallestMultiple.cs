using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEulerWeb.Problems
{
    public class SmallestMultiple
    {
        public Int64 GetSmallestMultiple(Int64 lowerBound, Int64 upperBound)
        {
            Int64 testNumber = 1;
            while (testNumber < Int64.MaxValue)
            {
                bool divisibleByAll = true;
                for (Int64 divisor = lowerBound; divisor < upperBound; divisor++)
                {
                    if (testNumber % divisor != 0)
                    {
                        divisibleByAll = false;
                        break;
                    }
                }
                if (divisibleByAll)
                    return testNumber;
                testNumber++;

            }
            return 0;
        }
    }
}