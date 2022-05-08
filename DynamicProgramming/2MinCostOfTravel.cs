using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    //There are N stations on route of a train.
    //The train goes from station 0 to N-1.
    //The ticket cost for all pair of stations (i, j) is given where j is greater than i.
    //Find the minimum cost to reach the destination.
    /*Input: 
    cost[N][N] = { {0, 15, 80, 90},
                { INF, 0, 40, 50},
                { INF, INF, 0, 70},
                { INF, INF, INF, 0}
                };
        There are 4 stations and cost[i][j] indicates cost to reach j 
        from i. The entries where j < i are meaningless.

        Output:
        The minimum cost is 65
        The minimum cost can be obtained by first going to station 1 
        from 0. Then from station 1 to station 3.
    */
    public class MinCostOfTravel
    {
        // Recursive Code

        // This function returns the smallest
        // possible cost to reach station N-1
        // from station 0. This function mainly
        // uses minCostRec().
        public int MinCost(int[,] cost, int N = 4)
        {
            return minCostRec(cost, 0, N - 1);
        }

        // A recursive function to find the
        // shortest path from source 's' to
        // destination 'd'. Time Complexity = O(N^3)
        public int minCostRec(int[,] cost, int s, int d)
        {

            // If source is same as destination
            // or destination is next to source
            if (s == d || s + 1 == d)
                return cost[s, d];

            // Initialize min cost as direct
            // ticket from source 's' to
            // destination 'd'.
            int min = cost[s, d];

            // Try every intermediate vertex to
            // find minimum
            for (int i = s + 1; i < d; i++)
            {
                int c = minCostRec(cost, s, i) +
                           minCostRec(cost, i, d);

                if (c < min)
                    min = c;
            }

            return min;
        }

        // Memoization (top down)
        public static int N = 4;
        
        public int[,] memo = new int[N, N];
        public int calculatMinCostMemoized(int[,] cost, int s, int d)
        {
            if (s == d || s == d - 1)
                return cost[s, d];

            // check if value is already calculated or not
            if(memo[s,d]== 0)
            {
                int minCost = memo[s, d];

                for (int i = s+1; i < d; i++)
                {
                    // Cost of going from s to i and then cost of going from i to d
                    int temp = calculatMinCostMemoized(cost, s, i) + calculatMinCostMemoized(cost, i, d);
                    if (temp < minCost)
                        minCost = temp;
                }

                // Stores the min cost in memo
                cost[s, d] = minCost;
            }
            return memo[s, d];
        }



        // Bottom Up Approach
        /*The idea in below code is to first calculate min cost for station 1, then for station 2, and so on. 
         * These costs are stored in an array dist[0…N-1].
            1) The min cost for station 0 is 0, i.e., dist[0] = 0
            2) The min cost for station 1 is cost[0][1], i.e., dist[1] = cost[0][1]
            3) The min cost for station 2 is minimum of following two. 
                a) dist[0] + cost[0][2] 
                b) dist[1] + cost[1][2]
            3) The min cost for station 3 is minimum of following three. 
                a) dist[0] + cost[0][3] 
                b) dist[1] + cost[1][3] 
                c) dist[2] + cost[2][3]
            Similarly, dist[4], dist[5], … dist[N-1] are calculated.
            Below is the implementation of above idea. 
          */

        static int minCost(int[,] cost)
        {

            // dist[i] stores minimum cost
            // to reach station i from
            // station 0.
            int[] dist = new int[N];

            for (int i = 0; i < N; i++)
                dist[i] = int.MaxValue;

            dist[0] = 0;
            dist[1] = cost[0, 1];

            // Go through every station and check
            // if using it as an intermediate
            // station gives better path
            for (int i = 2; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    if (dist[j] > dist[i] + cost[i, j])
                        dist[j] = dist[i] + cost[i, j];

            return dist[N - 1];
        }

    }
}
