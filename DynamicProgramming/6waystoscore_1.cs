using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /// <summary>
    /// Consider a game where a player can score 3 or 5 or 10 points in a move. 
    /// Given a total score n, find number of ways to reach the given score.
    /// Input: n = 13
    /// Output: 2
    /// There are following 2 ways to reach 13
    /// (3, 5, 5)
    /// (3, 10)
    /// </summary>
    public class DistinctWaysToScore
    {
        public int distinctWaystoScore(int N)
        {
            int[] scoreArr = new int[N + 1];

            for (int i = 0; i < N + 1; i++)
            {
                scoreArr[i] = 0;
            }

            scoreArr[0] = 1;

            for (int i = 3; i <= N; i++)
            {
                scoreArr[i] += scoreArr[i - 3];
            }

            for (int i = 5; i <= N; i++)
            {
                scoreArr[i] += scoreArr[i - 5];
            }

            for (int i = 10; i <= N; i++)
            {
                scoreArr[i] += scoreArr[i - 5];
            }

            return scoreArr[N];
        }
    }
}
