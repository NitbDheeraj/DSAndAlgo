using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaxProductSubarray mp = new MaxProductSubarray();
            //mp.testMaxProduct();

            //LongestSubstringWithKUniqueChar l = new LongestSubstringWithKUniqueChar();
            //Console.WriteLine(l.LongestSubstringWithKChar("aabacbebebe", 3));

            LongestSubstringWithoutRepeatingChar l = new LongestSubstringWithoutRepeatingChar();
            Console.WriteLine(l.LongestSubstring("GEEKSFORGEEKS"));

            Console.ReadLine();
        }
    }
}
