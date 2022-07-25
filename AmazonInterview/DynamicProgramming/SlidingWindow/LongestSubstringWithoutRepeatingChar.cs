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

            int left = 0,  result = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];

                while (d.ContainsKey(c))
                {
                    d.Remove(s[left]);
                    left++;
                }

                d.Add(c, 1);

                result = Math.Max(right - left + 1, result);
            }
            return result;
        }

    }
}
