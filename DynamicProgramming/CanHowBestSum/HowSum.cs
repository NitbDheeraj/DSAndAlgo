using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // given an array of numbers as an argument,
    // is it possible to generate target sum using numbers only from the given array
    // if Yes, return the answer as an array of integer
    // You can use the numbers as many times as you want and you can assume that all of the numbers are non negative
    public class HowSum
    {
        //Recursive
        public List<int> howSum(int target, int[] numbers)
        {
            if (target == 0)
                return new List<int>();

            if (target < 0)
                return null;

            foreach (var item in numbers)
            {
                var remainder = target - item;
                var result = howSum(remainder, numbers);
                if (result != null)
                {
                    result.Add(item);
                    return result;

                }
            }

            return null;
        }

        //memoization
        public List<int> howSumDP(int target, int[] numbers)
        {
            Dictionary<int, List<int>> memo = new Dictionary<int, List<int>>();
            return howSumDPHelper(target, numbers, memo);
        }

        private List<int> howSumDPHelper(int target, int[] numbers, Dictionary<int, List<int>> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (target == 0)
                return new List<int>();

            if (target < 0)
                return null;

            foreach (var item in numbers)
            {
                var remainder = target - item;
                var result = howSumDPHelper(remainder, numbers, memo);
                if (result != null)
                {
                    result.Add(item);
                    memo[remainder] = result;
                    return result;

                }
            }

            memo[target] = null;
            return null;
        }
    }

}
