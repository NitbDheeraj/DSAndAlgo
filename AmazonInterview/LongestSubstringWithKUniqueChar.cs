using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class LongestSubstringWithKUniqueChar
    {
        public int LongestSubstringWithKChar(string s, int k)
        {

            if (string.IsNullOrEmpty(s) || k == 0)
                return 0;

            int slow = 0, fast = 0, result = 0;

            Dictionary<char, int> d = new Dictionary<char, int>();

            while(fast < s.Length)
            {
                char c = s[fast];

                if (!d.ContainsKey(c))
                    d.Add(c, 1);
                else
                    d[c] += 1;

                while(d.Count() >= k)
                {
                    char c1 = s[slow];

                    if (d[c1] == 1)
                        d.Remove(c1);
                    else
                        d[c1] -= 1;
                    slow++;
                }
                result = Math.Max(result, fast - slow + 1);
                fast++;
            }
            return result;

        }
    }
}
