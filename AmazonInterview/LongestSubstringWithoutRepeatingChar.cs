using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class LongestSubstringWithoutRepeatingChar
    {
        public int LongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            Dictionary<char, int> d = new Dictionary<char, int>();

            int left = 0, right = 0, result = 0;

            while(right < s.Length)
            {
                char c = s[right];

                if (d.ContainsKey(c))
                {
                    d.Remove(s[left]);
                    left++;
                }
                else
                    d.Add(c, 1);

                result = Math.Max(right - left + 1, result);
                right++;
            }

            return result;
        }

    }
}
