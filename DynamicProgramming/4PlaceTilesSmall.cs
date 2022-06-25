using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    //Given a floor of size 2 x m and tiles of size 2 x 1.
    //The problem is to count the number of ways to tile the given floor using 2 x 1 tiles.
    //A tile can either be placed horizontally or vertically. 
    public class PlaceTiles
    {
        // Plane Recursion

        // If we place first tile vertically then problem reduces to 
        // Number of ways tiles can be placed in a plot of size 2*(n -1)

        // If we place first tile horizontally then the second tile must also be placed horizontally.
        // The problem reduces to Number of ways tiles can be placed in a plot of size 2*(n -2)


        // Now this problem is similar to fibonacci sequence with optimal substructure and overlapping subproblems
        public int CountWays(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            return CountWays(n - 1) + CountWays(n - 2);
        }


        //Memoization, Top Down, Using Array as a cache
        private int[] fib = new int[10];

        public int fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            if (fib[n] != 0)
                return fib[n];

            return fib[n] = fibonacci(n - 1) + fibonacci(n - 2);
        }


        //Using DP, Bottom Up

        public long BottomUpCountWays(int n)
        {
            int[] arr = new int[n];

            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
        }

    }
}
