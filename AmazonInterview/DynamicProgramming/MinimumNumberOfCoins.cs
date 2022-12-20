using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    /* Given an unlimited supply of coins of given denominations, 
     * find the minimum number of coins required to get the desired change.
     */
    public class MinimumNumberOfCoins
    {

        public int minCoinRecursive(int[] S, int target)
        {
            // if the total is 0, no coins are needed
            if (target == 0)
            {
                return 0;
            }

            int minCount = int.MaxValue;

            for (int i = 0; i < S.Length; i++)
            {
                if(S[i] < target)
                {
                    int currCount = minCoinRecursive(S, target - S[i]);
                    if (currCount != int.MaxValue && currCount <= minCount)
                        minCount++;
                }
            }
            return (minCount == int.MaxValue) ? -1 : minCount;
        }

        public int minCoinDP(int[] S, int target)
        {
            if (target == 0)
            {
                return 0;
            }
            // `T[i]` stores the minimum number of coins needed to get a total of `i`
            int[] T = new int[target + 1];
            T[0] = 0;

            for (int i = 0; i < target; i++)
            {
                T[i] = int.MaxValue;
            }

            for (int i = 1; i < target; i++)
            {
                for (int j = 0; j < S.Length; j++)
                {
                    if(S[j] <=i)
                    {
                        int currCount = S[i - S[j]];
                        if (currCount != int.MaxValue && currCount + 1 < T[i])
                            T[i] = currCount++;
                    }
                }
            }

            if (T[target] == int.MaxValue)
                return -1;
            else
                return T[target];

        }


        public int findMinCoins(int[] S, int target)
        {
            // if the total is 0, no coins are needed
            if (target == 0)
            {
                return 0;
            }

            // `T[i]` stores the minimum number of coins needed to get a total of `i`
            int[] T = new int[target + 1];

            T[0] = 0;

            for (int i = 0; i <= target; i++)
            {
                // initialize the minimum number of coins needed to infinity
                T[i] = int.MaxValue;
                int result = int.MaxValue;

                foreach (var c in S)
                {
                    // check if the index doesn't become negative by including
                    // current coin `c`
                    if (i - c >= 0)
                    {
                        result = T[i - c];
                    }

                    if (result != int.MaxValue)
                    {
                        T[i] = Math.Min(T[i], result + 1);
                    }
                }

            }

            // `T[target]` stores the minimum number of coins needed to
            // get a total of `target`
            return T[target];
        }



    }
}
