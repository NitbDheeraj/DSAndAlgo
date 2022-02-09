using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{
    public class CheckPalindrome
    {
        /*
        When the number of digits of that number exceeds 1018, 
        we can’t take that number as an integer since the range of long long int doesn’t satisfy the given number.
        
        So take input as a string, Run a loop from starting to length/2 and
        check the first character(numeric) to the last character of the string and
        second to second last one, and so on ….If any character mismatches, the string wouldn’t be a palindrome.

        */
        public bool IsPalindrome(string s)
        {
            // Calculating string length
            int len = s.Length;

            for (int i = 0; i < len/2; i++)
            {
                if (s[i] != s[len - i - 1])
                    return false;
            }

            return true;
        }
    }
}
