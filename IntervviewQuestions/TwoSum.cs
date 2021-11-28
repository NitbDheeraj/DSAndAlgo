using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{
    /*
     *  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.
     * 
     * Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Output: Because nums[0] + nums[1] == 9, we return [0, 1].

        Input: nums = [3,2,4], target = 6
        Output: [1,2]

        Input: nums = [3,3], target = 6
        Output: [0,1]

        This algorithm can be broken up into two stages:

        Create a dictionary of value->index for all index, value pairs in nums. 
        Note that you can have multiple values with different indices. In this case, 
        the highest index will be stored in the dictionary and lower indexes will be overwritten. 
        This behavior can be modified, of course, but I don't believe it needs to be for this problem because part of the problem statement is this: 
         "You may assume that each input would have exactly one solution." Thus, each input has a single unique output so we never have to worry about returning a "wrong-pair" of indices.

        Loop through the enumeration of nums, getting i as index, and v as value. 
        Check if target-v is a key in the dictionary we created, and simultaneously assert that the value pointed to by that key is not i. 
        If this is ever true, return the tuple i+1, lookup.get(target-v)+1.
     * */

    public class TwoSumProblem
    {

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            //Make sure the dictionary has the highest index in case of repeating numbers
            for (int i = 0; i < nums.Length; i++)
            {
                if (!d.ContainsKey(nums[i]))
                    d.Add(nums[i], i);
                else
                    d[nums[i]] = i;
            }

            //while checking the numbers check if index found is greater then current index
            for (int i = 0; i < nums.Length; i++)
            {
                int t = target - nums[i];
                if (d.ContainsKey(t) && d[t] > i)
                    return (new int[2] { i, d[t] });
            }

            return new int[2] { -1, -1 };

        }
    }
}
