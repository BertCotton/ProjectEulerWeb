using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerWeb.Problems
{
    class LargestProductInGrid
    {
        public long FindLargestProduct(int[][] grid, int length)
        {
            long largestProduct = 0;

            for(int x = 0; x < length; x++)
            {
                for(int y = 0; y < length; y++)
                {
                    largestProduct = getGreater(largestProduct, upProduct(grid, length, x, y));
                    largestProduct = getGreater(largestProduct, upLRightProduct(grid, length, x, y));
                    largestProduct = getGreater(largestProduct, rightProduct(grid, length, x, y));
                    largestProduct = getGreater(largestProduct, downRightProduct(grid, length, x, y));
                    largestProduct = getGreater(largestProduct, downProduct(grid, x, y));
                    largestProduct = getGreater(largestProduct, downLeftProduct(grid, x, y));
                    largestProduct = getGreater(largestProduct, leftProduct(grid, x, y));
                    largestProduct = getGreater(largestProduct, upLteftProduct(grid, length, x, y));
                }
            }

            return largestProduct;
        }

        private long getGreater(long largestProduct, long testProduct)
        {
            if (testProduct > largestProduct)
                return testProduct;
            return largestProduct;
        }

        private long upProduct(int[][] grid, int length, int x, int y)
        {
            if ((y+3) >= length)
                return 0;
            return grid[x][y] * grid[x][y + 1] * grid[x][y + 2] * grid[x][y + 3];
        }


        private long upLRightProduct(int[][] grid, int length, int x, int y)
        {
            if ((y + 3) >= length || (x + 3) >= length)
                return 0;
            return grid[x][y] * grid[x + 1][y + 1] * grid[x + 2][y + 2] * grid[x + 3][y + 3];
        }

        private long rightProduct(int[][] grid, int length, int x, int y)
        {
            if ((x + 3) >= length)
                return 0;
            return grid[x][y] * grid[x+ 1][y] * grid[x + 2][y] * grid[x + 3][y];
        }

        private long downRightProduct(int[][] grid, int length, int x, int y)
        {
            if (y < 3 || (x + 3) >= length)
                return 0;
            return grid[x][y] * grid[x + 1][y - 1] * grid[x + 2][y - 2] * grid[x + 3][y - 3];
        }

        private long downProduct(int[][] grid, int x, int y)
        {
            if (y < 3)
                return 0;
            return grid[x][y] * grid[x][y - 1] * grid[x][y - 2] * grid[x][y - 3];
        }

        private long downLeftProduct(int[][] grid, int x, int y)
        {
            if (y < 3 || x < 3)
                return 0;
            return grid[x][y] * grid[x - 1][y - 1] * grid[x - 2][y - 2] * grid[x - 3][y - 3];
        }

        private long leftProduct(int[][] grid, int x, int y)
        {
            if (x < 3)
                return 0;
            return grid[x][y] * grid[x - 1][y] * grid[x - 2][y] * grid[x - 3][y];
        }

        private long upLteftProduct(int[][] grid, int length,  int x, int y)
        {
            if (x < 3 || (y + 3) >= length)
                return 0;
            return grid[x][y] * grid[x - 1][y + 1] * grid[x - 2][y + 2] * grid[x - 3][y + 3];
        }
    }
}
