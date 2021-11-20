using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms.StringMatchingAlgorithms
{
    /*
     *  In this method, for each possible position in the text T we check whether the pattern P matches or
        not. Since the length of T is n, we have n – m + 1 possible choices for comparisons. This is
        because we do not need to check the last m – 1 locations of T as the pattern length is m. The
        following algorithm searches for the first occurrence of a pattern string P in a text string T..
    */

    // Complexity is O(n*m)
    public class BruteForce
    {
        public bool BruteForcePatternMatch(string Text, string Pattern)
        {
            int n = Text.Length;
            int m = Pattern.Length;

            for (int i = 0; i < n - m; i++)
            {
                int j = 0;

                while(j < m && Text[i + j] == Pattern[j])
                    j++;

                if (j == m - 1)
                    return true;
            }

            return false;
        }
    }
}
