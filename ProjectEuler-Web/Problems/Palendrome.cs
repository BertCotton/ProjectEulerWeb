using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEuler_Web.Problems
{
    public class Palendrome
    {

        public Int64 findBiggestPalendrome(Int64 baseProductSize)
        {
            Int64 biggestNumber = 0;
            Int64 smallestNumber = 0;
            while(biggestNumber.ToString().Length < baseProductSize)
            {
                biggestNumber *= 10;
                biggestNumber += 9;

                if (smallestNumber == 0)
                    smallestNumber = 1;
                else
                    smallestNumber *= 10;
            }

            Int64 biggestPalendrome = 0;
            while (smallestNumber < biggestNumber)
            {
                for (var i = smallestNumber; i < biggestNumber; i++)
                {
                    Int64 test = i * biggestNumber;

                    if (isPalendrome(test) && test > biggestPalendrome)
                        biggestPalendrome = test;
                }
                biggestNumber--;
            }
            return biggestPalendrome;
        }

        private Boolean isPalendrome(Int64 test)
        {
            IList<long> characters = new List<long>();
            Int64 tempTest = test;
            while(tempTest > 0)
            {
                characters.Add(tempTest % 10);
                tempTest = tempTest / 10;
            }
            long[] characterArray = characters.ToArray<long>();
            int i = 0;
            int j = characterArray.Length - 1;
            while(i < j)
            {
                if (characterArray[i] != characterArray[j])
                    return false;
                i++;
                j--;
            }
            return true;
            
        }
    }
}