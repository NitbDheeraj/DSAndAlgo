using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class SmallestSumContineousSubarray
    {
        //Kadens algorithm
        public int MinimumSumSubarray(int[] arr)
        {
            int min_ending_here = int.MinValue;
            int min_so_far = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min_ending_here > 0)
                    min_ending_here = arr[i];
                else
                    min_ending_here += arr[i];

                min_so_far = Math.Min(min_so_far, min_ending_here);
            }

            return min_so_far;
        }
    }
}
