using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    //Given a target string and an array of strings (wordbank), write a function that returns a boolean indicating 
    // if the target can be constructed using elements of word bank array.

    //you may reuse elements of wordbank as many times as needed.
    public class CanConstruct
    {
        //Recursive approach
        public bool canConstruct(string target, string[] wordbank)
        {
            if (string.IsNullOrEmpty(target))
                return true;

            foreach (var item in wordbank)
            {
                if(target.IndexOf(item) == 0)
                {
                    var len = target.Length - item.Length;
                    string remainder = target.Substring(item.Length, len);
                    if (canConstruct(remainder, wordbank))
                        return true;
                }
            }

            return false;
        }

        public bool canConstructDP(string target, string[] wordbank)
        {
            Dictionary<string, bool> memo = new Dictionary<string, bool>();
            return canConstructHelper(target, wordbank, memo);
        }

        private bool canConstructHelper(string target, string[] wordbank, Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (string.IsNullOrEmpty(target))
                return true;

            foreach (var item in wordbank)
            {
                if (target.IndexOf(item) == 0)
                {
                    var len = target.Length - item.Length;
                    string remainder = target.Substring(item.Length, len);
                    if (canConstructHelper(remainder, wordbank, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
            }
            memo[target] = false;
            return false;
        }
    }
}
