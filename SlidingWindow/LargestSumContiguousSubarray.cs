using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    /* Write an efficient program to find the sum of contiguous subarray within 
     * a one-dimensional array of numbers that has the largest sum. 
     */

    /*
     * Kadane’s Algorithm:
     * Initialize:
        max_so_far = INT_MIN
        max_ending_here = 0

            Loop for each element of the array
                (a) max_ending_here = max_ending_here + a[i]
                (b) if(max_so_far < max_ending_here)
                        max_so_far = max_ending_here
                (c) if(max_ending_here < 0)
                        max_ending_here = 0
        return max_so_far
     */
    public class LargestSumContiguousSubarray
    {

        public int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue, max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }

        public void TestCase()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.Write("Maximum contiguous sum is " + maxSubArraySum(a));
        }
    }
}
