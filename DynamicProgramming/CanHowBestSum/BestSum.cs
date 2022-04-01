using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // given an array of numbers as an argument,  is it possible to generate target sum using numbers only from the given array
    // You can use the numbers as many times as you want and you can assume that all of the numbers are non negative
    // The function should return an array containing shortest combination of numbers that add up to exactaly the target sum
    // If there is any tie for sortest combination, you may return any one of the sortest.

    public class BestSum
    {

        //Recursive version
        public List<int> bestSum(int target, int[] numbers)
        {
            if (target == 0)
                return new List<int>();

            if (target < 0)
                return null;

            List<int> shortestLength = null;

            foreach (var item in numbers)
            {
                var remainder = target - item;
                var remResult = bestSum(remainder, numbers);
                if (remResult != null)
                {
                    remResult.Add(item);
                    //return remResult;
                    if (shortestLength == null || shortestLength.Count() > remResult.Count())
                        shortestLength = remResult;
                }
            }

            return shortestLength;

        }

        public List<int> bestSumDP(int target, int[] numbers)
        {
            Dictionary<int, List<int>> memo = new Dictionary<int, List<int>>();
            return bestSumHelper(target, numbers, memo);

        }

        //Doesnot work...try again later

        private List<int> bestSumHelper(int target, int[] numbers, Dictionary<int, List<int>> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (target == 0)
                return new List<int>();

            if (target < 0)
                return null;

            List<int> shortestNums = null;

            foreach (var item in numbers)
            {
                var remainder = target - item;
                var remResult = bestSumHelper(remainder, numbers, memo);
                if(remResult != null)
                {
                    remResult.Add(item);
                    memo[target] = remResult;
                    if (shortestNums == null || shortestNums.Count() > remResult.Count())
                    {
                        shortestNums = remResult;
                    }
                }
            }
            memo[target] = shortestNums;
            return shortestNums;
        }
    }
}
