﻿using System;
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
