using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    /* There are n stairs, a person standing at the bottom wants to reach the top. 
     * The person can climb either 1 stair or 2 stairs at a time. 
     * Count the number of ways, the person can reach the top.
     * 
     * ways(n) = ways(n-1) + ways(n-2)
     * 
     * This is like fibonacci series
     */
    public class WaysToReachNthStair
    {
        // Returns number of ways to reach s'th stair
        public int countWays(int N)
        {
            int[] dp = new int[N + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[N];
        }
    }
}
