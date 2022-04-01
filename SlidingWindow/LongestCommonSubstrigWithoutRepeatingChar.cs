using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    public class LongestCommonSubstrigWithoutRepeatingChar
    {

        // Time complexity = O(N)
        public int FindLength(string s)
        {
            // Validation
            if (string.IsNullOrEmpty(s) || s.Length == 0)
                return 0;

            //Variables
            int i = 0, j = 0, max = 0;
            HashSet<char> set = new HashSet<char>();

            while(i < s.Length)
            {
                char c = s[i];
                while(set.Contains(c))
                {
                    set.Remove(s[j]);
                    ++j;
                }
                set.Add(c);
                max = Math.Max(max, i - j + 1);
                ++i;
            }
            return max;
        }

    }
}
