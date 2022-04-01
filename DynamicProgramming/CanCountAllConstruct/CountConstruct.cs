using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.CanCountConstruct
{
    //Given a target string and an array of strings (wordbank), write a function that returns a number indicating 
    // number of times the target can be constructed using elements of word bank array.
    //you may reuse elements of wordbank as many times as needed.
    public class CountConstruct
    {
        //Basic Recursion
        public int countConstruct(string target, string[] wordbank)
        {
            if (string.IsNullOrEmpty(target))
                return 1;

            var totalCount = 0;

            foreach (var item in wordbank)
            {
                if(target.IndexOf(item) == 0)
                {
                    var len = target.Length - item.Length;
                    var remainder = target.Substring(item.Length, len);
                    var remaindercount = countConstruct(remainder, wordbank);
                    totalCount += remaindercount;
                }
            }

            return totalCount;
        }

        public int countConstructDP(string target, string[] wordbank)
        {
            Dictionary<string, int> memo = new Dictionary<string, int>();
            return countConstructHelper(target, wordbank, memo);
        }

        private int countConstructHelper(string target, string[] wordbank, Dictionary<string, int> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (string.IsNullOrEmpty(target))
                return 1;

            var totalCount = 0;

            foreach (var item in wordbank)
            {
                if(target.IndexOf(item) == 0)
                {
                    var len = target.Length - item.Length;
                    var remainder = target.Substring(item.Length, len);
                    var remaindercount = countConstructHelper(remainder, wordbank, memo);
                    totalCount += remaindercount;
                    memo[target] = totalCount;
                }
            }

            memo[target] = totalCount;
            return totalCount;
        }
    }
}
