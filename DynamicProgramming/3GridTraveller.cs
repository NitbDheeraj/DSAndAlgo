using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // you have a traveller on a 2D grid. You begin on top left corner and your goal is to travel bottom right corner
    // You may only move down or right. 

    //In how many ways you can travel to the goal on the grid if you have dimension M*N
    public class GridTraveller
    {

        

        //Normal Recursion. The Time complexity here is O(2^M+N)
        public int GridTravellerWays(int m, int n)
        {
            //base case
            if (m == 1 && n == 1)
                return 1;

            if (m == 0 || n == 0)
                return 0;

            return GridTravellerWays(m - 1, n) + GridTravellerWays(m, n - 1);
        }


        //Using Memoization
        public long GridTravellerWaysDP(int m, int n)
        {
            Dictionary<string, long> memo = new Dictionary<string, long>();

            return GridTravellerHelper(m, n, memo);
        }

        private long GridTravellerHelper(int m, int n, Dictionary<string, long> memo)
        {
            string key = string.Format("{0}-{1}", m, n);


            if (memo.ContainsKey(key))
                return memo[key];
            //base case
            if (m == 1 && n == 1)
                return 1;

            if (m == 0 || n == 0)
                return 0;

            memo[key]= GridTravellerHelper(m - 1, n, memo) + GridTravellerHelper(m, n - 1, memo);

            return memo[key];
        }


        public long GridTravellerWaysBottomUp(int m, int n)
        {
            long[,] count = new long[m, n];

            for (int i = 0; i < m; i++)
                count[i, 0] = 1;

            for (int i = 0; i < n; i++)
                count[0, i] = 1;

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    count[i, j] = count[i - 1, j] + count[i, j - 1];

            return count[m - 1, n - 1];
        }
    }

}
