using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class MaximumSumSubarray
    {

        public int LargestSumSubarray(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            int max_so_far = int.MinValue;
            int max_ending_here = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here += arr[i];

                if (max_ending_here > max_so_far)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
    }
}
