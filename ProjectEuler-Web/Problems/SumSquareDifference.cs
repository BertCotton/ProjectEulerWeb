using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEulerWeb.Problems
{
    public class SumSquareDifference
    {
        public Int64 Difference(Int64 lowerBound, Int64 upperBound)
        {
            Int64 sumOfSquare = 0;
            Int64 squareOfSum = 0;
            while(lowerBound <= upperBound)
            {
                sumOfSquare += (lowerBound * lowerBound);
                squareOfSum += lowerBound;

                lowerBound++;
            }

            return (squareOfSum * squareOfSum) - sumOfSquare;
        }
    }
}