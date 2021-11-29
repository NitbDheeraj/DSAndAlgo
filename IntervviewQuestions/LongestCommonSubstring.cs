using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{
    public class LongestCommonSubstring
    {
        /*Given a string s, find the length of the longest substring without repeating characters.

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
         */

        public int longestSubstringWithDistinctcharacters(string s)
        {
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;

            HashSet<char> set = new HashSet<char>();

            while(b_pointer < s.Length)
            {
                if (!set.Contains(s[b_pointer]))
                {
                    set.Add(s[b_pointer]);
                    b_pointer++;
                    max = Math.Max(set.Count(), max);
                }
                else
                {
                    set.Remove(s[a_pointer]);
                    a_pointer++;
                }
            }

            return max; 
        }
    }
}
