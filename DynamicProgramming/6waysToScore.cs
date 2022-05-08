using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /// <summary>
    /// Consider a game where a player can score 3,5,10 points in one move
    /// Given a total score of N, find total number of ways to reach a unique score of N
    /// for example If N = 13 the return value should be 5
    /// (3, 10), (3, 5, 5), (5,3,5), (5,5,3), (10,3)
    /// </summary>
    public class WaysToScore
    {

        //Simple recursion time complexity o(N3)
        public int waysToscoreRecursion(int N)
        {
            //Base case
            if (N < 0) return 0;
            if (N == 0) return 1;

            return waysToscoreRecursion(N - 10) + waysToscoreRecursion(N - 5) + waysToscoreRecursion(N - 3);
        }


        // Memoization
        static int N = 100;
        int[] memo = new int[N];
        public int waysToscoreMemoization(int N)
        {
            //Base case
            if (N < 0) return 0;
            if (N == 0) return 1;

            if (memo[N] != 0)
                return memo[N];

            memo[N] = waysToscoreRecursion(N - 10) + waysToscoreRecursion(N - 5) + waysToscoreRecursion(N - 3);

            return memo[N];
        }


        //Dynamic Programming
        public int waysToScore(int n)
        {
            int[] dp = new int[n];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i - 3 >= 0)
                    dp[i] += dp[i - 3];
                if (i - 5 >= 0)
                    dp[i] += dp[i - 5];
                if (i - 10 >= 0)
                    dp[i] += dp[i - 10];
            }

            return dp[n];
        }
        

    }
}
