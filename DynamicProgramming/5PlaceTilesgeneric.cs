using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /*  Given a floor of size n x m and tiles of size 1 x m. 
     *  The problem is to count the number of ways to tile the given floor using 1 x m tiles. 
     *  A tile can either be placed horizontally or vertically. 
        Both n and m are positive integers and 2 < = m
     */

    /*
     * Approach: For a given value of n and m, the number of ways to tile the floor can be obtained
     * from the following relation. 
                    |  1, 1 < = n < m
         count(n) = |  2, n = m
                    | count(n-1) + count(n-m), m < n
     */

    public class PlaceTilesgeneric
    {

        public int CountWays(int n, int m)
        {
            //Terminating Condition
            if (n < m || n == 1) return 1;

            if (n == m) return 2;

            return CountWays(n - 1, m) + CountWays(n - m, m);
        }


        // Using DP
        public int countWaysDP(int n, int m)
        {

            // table to store values
            // of subproblems
            int[] count = new int[n + 1];
            count[0] = 0;

            // Fill the table upto value n
            int i;
            for (i = 1; i <= n; i++)
            {

                // recurrence relation
                if (i > m)
                    count[i] = count[i - 1] + count[i - m];

                // base cases and i = m = 1
                else if (i < m || i == 1)
                    count[i] = 1;

                // i = = m
                else
                    count[i] = 2;
            }

            // required number of ways
            return count[n];
        }
    }
}
