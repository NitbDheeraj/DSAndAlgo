using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.DynamicProgramming.SlidingWindow
{
    /// <summary>
    /// Given a binary array, find the maximum sequence of continuous 1’s that can be formed by replacing at most k zeroes by ones.
    /// </summary>

    /*
     * We can solve this problem by using the sliding window technique. 
     * The idea is to maintain a window containing at most k zeroes at any point. 
     * Add elements to the window from the right until it becomes unstable. 
     * The window becomes unstable if the total number of zeros in it becomes more than k. 
     * If the window becomes unstable, remove elements from its left till it becomes stable again (by removing leftmost zero). 
     * If the window is stable and the current window length is more than the maximum window found so far, 
     * set the maximum window size to the current window size.
     */
    public class MaximumSequenceOfOnesByReplacing0
    {
        public int FindLongestSequence(int[] arr, int k)
        {
            if (arr.Length == 0)
                return 0;

            int left = 0;
            int countOfZero = 0;
            int result = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                if (arr[right] == 0)
                    countOfZero++;

                while(countOfZero < k)
                {
                    if (arr[left] == 0)
                        countOfZero--;

                    left++;
                }

                result = Math.Max(result, right - left + 1);
                //you can also print subarray here using if condition instead of Math.Max
            }

            return result;
        }

    }
}
