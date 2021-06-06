using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{

    // Given two arrays of unordered numbers, check whether both arrays have the same
    // set of numbers?
    public class Check2ArraysForSameSet
    {
        /*  • Construct the hash table with array A elements as keys.
            • While inserting the elements, keep track of the number frequency for each number.
              That means, if there are duplicates, then increment the counter of that corresponding key.
            • After constructing the hash table for A’s elements, now scan the array B.
            • For each occurrence of B’s elements reduce the corresponding counter values.
            • At the end, check whether all counters are zero or not.
            • If all counters are zero, then both arrays are the same otherwise the arrays are different.
        */

        public bool Check2ArrayForSameSet(int[] a, int[] b)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (d.ContainsKey(a[i]))
                    d[a[i]]++;
                else
                    d.Add(a[i], 1);
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (d.ContainsKey(b[i]))
                    d[b[i]]--;
                else
                    return false;
            }

            foreach (KeyValuePair<int, int> item in d)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }
    }
}
