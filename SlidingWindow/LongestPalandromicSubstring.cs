using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    public class LongestPalandromicSubstring
    {
        // Function to find the longest palindromic substring in `O(n²)` time
        // and `O(1)` space
        public String findLongestPalindromicSubstring(String str)
        {
            // base case
            if (str == null || str.Length == 0)
            {
                return str;
            }

            // `max_str` stores the maximum length palindromic substring
            // found so far

            String max_str = "", curr_str;

            // `max_length` stores the maximum length of palindromic
            // substring found so far

            int max_length = 0, curr_length;

            // consider every character of the given string as a midpoint and expand
            // in both directions to find maximum length palindrome

            for (int i = 0; i < str.Length; i++)
            {
                // find the longest odd length palindrome with `str[i]` as a midpoint

                curr_str = expand(str, i, i);
                curr_length = curr_str.Length;


                // update maximum length palindromic substring if odd length
                // palindrome has a greater length

                if (curr_length > max_length)
                {
                    max_length = curr_length;
                    max_str = curr_str;
                }

                // Find the longest even length palindrome with str[i] and
                // str[i+1] as midpoints. Note that an even length palindrome
                // has two midpoints.

                curr_str = expand(str, i, i + 1);
                curr_length = curr_str.Length;

                // update maximum length palindromic substring if even length
                // palindrome has a greater length

                if (curr_length > max_length)
                {
                    max_length = curr_length;
                    max_str = curr_str;
                }
            }

            return max_str;
        }

        public String expand(String str, int low, int high)
        {
            // expand in both directions
            while (low >= 0 && high < str.Length &&
                    (str[low] == str[high]))
            {
                low--;
                high++;
            }

            // return palindromic substring
            return str.Substring(low + 1, high);
        }

    }
}
