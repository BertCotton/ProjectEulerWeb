using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ProjectEulerWeb.Problems
{
    public class MultiplesOf3And5
    {
        public int GetSumOfMultiples(int max)
        {
            int sum = 0;

            for (int i = 1; i < max; i++)
            {
                if (i % 3 == 0)
                {
                    Debug.WriteLine(i + " is a multiple of 3");
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    Debug.WriteLine(i + " is a multiple of 5");
                    sum += i;
                }
            }
            return sum;
        }
    }
}