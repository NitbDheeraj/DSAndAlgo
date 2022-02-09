using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // given an array of numbers as an argument,  is it possible to generate target sum using numbers only from the given array
    // You can use the numbers as many times as you want and you can assume that all of the numbers are non negative
    public class CanSum
    {

        //Recursive solution
        public bool canSum(int targetNumber, int[] numbers)
        {
            if (targetNumber == 0)
                return true;

            if (targetNumber < 0)
                return false;

            foreach (var item in numbers)
            {
                var remainder = targetNumber - item;
                if (canSum(remainder, numbers))
                {
                    return true;
                }
            }

            return false;
        }

        public bool canSumDP(int targetNumber, int[] numbers)
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>();

            return canSumDPHelper(targetNumber, numbers, memo);
        }

        private bool canSumDPHelper(int targetNumber, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(targetNumber))
                return memo[targetNumber];

            if (targetNumber == 0)
                return true;

            if (targetNumber < 0)
                return false;

            foreach (var item in numbers)
            {
                var remainder = targetNumber - item;
                if (canSumDPHelper(remainder, numbers, memo))
                {
                    memo[remainder] = true;
                    return true;
                }
            }

            memo[targetNumber] = false;
            return false;
        }
    }
}
