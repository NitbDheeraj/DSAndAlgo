using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /*
     * JOKER is preparing to dive into the acid bath with Harley but our so called hero Batman
     * somehow gets this info and decides to revenge him for killing Rachel . 
     * For this Batman should reach the top floor. The building has a number of staircases and he likes to climb each staircase 1, 2, or 3 steps at a time . 
     * But still, he wonders how many ways there are to reach the top of the staircase.

        Given the respective heights for each of the s staircases in his house, 
        find and print the number of ways he can climb each staircase, on a new line.

        For example, There is s = 1 staircase in the house, that is n = 5 steps high. 
        Batman can step on the following sequences of steps:

        1 1 1 1 1
        1 1 1 2
        1 1 2 1
        1 2 1 1
        2 1 1 1
        1 2 2
        2 2 1
        2 1 2
        1 1 3
        1 3 1
        3 1 1
        2 3
        3 2

        There are 13 possible ways he can take 5 steps.
        
        

     * */

    public class DarkKnightClimbStairs1
    {

        static Dictionary<int, int> memo = new Dictionary<int, int>();
        public static void Main()
        {
            // your code goes here
            string val = Console.ReadLine();
            int t = Convert.ToInt32(val);

            int[] heights = new int[t];

            for (int i = 0; i < t; i++)
                heights[i] = Convert.ToInt32(Console.ReadLine());

            foreach (int height in heights)
            {
                Console.WriteLine(CountWays(height));
            }

        }

        public static int CountWays(int height)
        {
            if (memo.ContainsKey(height))
                return memo[height];

            if (height == 0)
                return 1;

            int ways = 0;

            if (height - 1 >= 0)
                ways += CountWays(height - 1);

            if (height - 2 >= 0)
                ways += CountWays(height - 2);

            if (height - 3 >= 0)
                ways += CountWays(height - 3);

            memo.Add(height, ways);

            return ways;

        }

    }


    public class DarkKnightClimbStairs
    {
        public static void Main()
        {
            // your code goes here
            string val = Console.ReadLine();
            int t = Convert.ToInt32(val);
            while (t-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine()), i;
                long[] a = new long[1000000];
                a[1] = 1;
                a[2] = 2;
                a[3] = 4;
                if (n > 3)
                {
                    for (i = 4; i <= n; i++)
                        a[i] = a[i - 1] + a[i - 2] + a[i - 3];
                }
                Console.WriteLine(a[n]);
            }

        }



    }
}
