using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerWeb.Problems
{
    class LargestProductInSeries
    {
        public long FindLargestProduct(String source, long adjacentBound)
        {
            if(source.Length < adjacentBound)
                throw new InvalidOperationException("Source not as long as adjacentBound");
            long largestProduct = 0;
            LinkedList<long> currentProductChain = new LinkedList<long>();
            

            int listSize = 0;
            foreach(char digitString in source.ToCharArray())
            {
                if (digitString == ' ')
                    continue;
                int digit = Int32.Parse(digitString.ToString());
                if (listSize >= adjacentBound)
                    currentProductChain.RemoveFirst();
                else
                    listSize++;

                currentProductChain.AddLast(digit);
                long currentProduct = getProduct(currentProductChain);
                if (currentProduct > largestProduct)
                    largestProduct = currentProduct;
            }

            return largestProduct;
        }

        private long getProduct(LinkedList<long> productChain)
        {
            long total = 1;
            foreach(long value in productChain)
            {
                total *= value;
            }
            return total;
        }
    }
}
