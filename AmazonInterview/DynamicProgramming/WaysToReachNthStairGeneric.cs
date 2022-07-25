using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    /*  How to count the number of ways if the person can climb up to m stairs for a given value m. 
     *  For example, if m is 4, the person can climb 1 stair or 2 stairs or 3 stairs or 4 stairs at a time.

        Approach: For the generalization of above approach the following recursive relation can be used. 

        ways(n, m) = ways(n-1, m) + ways(n-2, m) + ... ways(n-m, m) 
        In this approach to reach nth stair, 
        try climbing all possible number of stairs lesser than equal to n from present stair.
     */
    public class WaysToReachNthStairGeneric
    {
        public int NumWays(int N, int m)
        {
            if (N == 0)
                return 1;
            var total = 0;
            for (int i = 0; i < m; i++)
            {
                if (N - i > 0)
                    total += NumWays(N - i, m);
                       
            }
            return total;
        }


        public int NumWays_BottomUp(int N, int m)
        {
            if (N == 0)
                return 1;

            int[] nums = new int[N + 1];

            for (int i = 1; i < N; i++)
            {
                var total = 0;
                for (int j = 0; j < m; j++)
                {
                    if (i - j > 0)
                        total += nums[i - j];
                }
                nums[i] = total;
            }
            return nums[N];
        }
    }
}
