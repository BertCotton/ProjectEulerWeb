using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEulerWeb.Problems
{
    public class NthPrimes
    {

        public long GetNthPrime(long upperBound)
        {
            long primeAttempt = 2;
            long primeCounter = 0;
            while(true)
            {
                if (isPrime(primeAttempt))
                    primeCounter++;
                if (primeCounter >= upperBound)
                    break;
                primeAttempt++;
            }
            return primeAttempt;
            
        }

        private Boolean isPrime(long value)
        {
            if (value < 2)
                return false;
            else if (value == 2 || value == 3)
                return true;
            for(double i = 2; i <= Math.Round(Math.Sqrt(value),0); i++ )
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}