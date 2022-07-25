using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class MaxProductSubarray
    {

        public long MaxProduct(int[] arr)
        {
            int maxSoFar = 1;
            int minSoFar = 1;
            long result = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    maxSoFar = 1;
                    minSoFar = 1;
                    continue;
                }
                var t1 = arr[i] * maxSoFar;
                var t2 = arr[i] * minSoFar;
                maxSoFar = Math.Max(t1, Math.Max(t2, arr[i]));
                minSoFar = Math.Min(t1, Math.Min(t2, arr[i]));

                result = Math.Max(maxSoFar, result);

            }
            return result;
        }

        public void testMaxProduct()
        {
            int[] arr = { 1, -2, -3, 0, 7, -8, -2 };
            Console.WriteLine(MaxProduct(arr));
            Console.ReadLine();

        }
    }
}
