using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectEulerWeb.Problems
{
    class EvenFibonacci
    {
        public Int64 GetSumOfEvenFibonacci(int nth)
        {
            Int64 sum = 0;
            int nMinus2 = 1;
            int nMinus1 = 2;
            if (nth >= 1)
            {
                sum = 1;
            }
            if (nth >= 2)
            {
                sum = 2;
            }

            int iteration = 3;
            int currentN;
            do
            {
                currentN = nMinus1 + nMinus2;
                if (currentN % 2 == 0) 
                sum += currentN;

                nMinus2 = nMinus1;
                nMinus1 = currentN;
                iteration++;


            } while (currentN < nth);

            return sum;
        }
    }
}
