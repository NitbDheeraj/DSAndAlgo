using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{

    /*  Given an n * m grid, where each element can contain one of the 3 given values, 

        0       represents an empty cell.
        1       represents a cell containing fresh orange.
        2       represents a cell containing rotten orange.
        Every day, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

        Return the minimum number of days that must elapse until no cell has a fresh orange. 
        If this is impossible, return -1.
    */

    /*  We can solve this problem optimally using the “Multisource BFS” algorithm on a grid. 
     *  The key observation is that fresh oranges adjacent to rotten oranges are rotten on day 1, 
     *  those adjacent to those oranges are rotten on day 2, and so on. 
     *  The phenomenon is similar to a level order traversal on a graph, 
     *  where all the initial rotten oranges act as root nodes.

        We can just push all these root nodes into a queue and perform BFS on a grid algorithm, 
        to calculate the total time taken to rot all the oranges. 
        If all oranges are not rotten before our algorithm terminates, we will return -1.
     */
    public class RottenOranges
    {
        private int[] dx = new int[4] { 1, 0, -1, 0 };
        private int[] dy = new int[4] { 0, 1, 0, -1 };

        public int NumberOfDays(int[,] graph)
        {
            int r = graph.GetLength(0);
            int c = graph.GetLength(1);
            int days = 0, countOfOnes = 0;

            Queue<int[]> q = new Queue<int[]>();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(graph[i,j] == 2)
                        q.Enqueue(new int[2] { i, j });
                    if (graph[i, j] == 1)
                        countOfOnes++;
                }
            }

            if (countOfOnes == 0)
                return 0;

            while(q.Count() > 0)
            {
                var qSize = q.Count();
                while(qSize -- > 0)
                {
                    var temp = q.Dequeue();
                    int x = temp[0], y = temp[1];

                    for (int i = 0; i < 4; i++)
                    {
                        int nx = x + dx[i], ny = y + dy[i];
                        if (nx < 0 || ny < 0 || nx == r || ny == c)
                            continue;

                        if(graph[nx, ny] == 1)
                        {
                            graph[nx, ny] = 2;
                            countOfOnes--;
                            q.Enqueue(new int[2] { nx, ny });
                        }
                    }
                }
                if (qSize > 0)
                    days += 1;
            }

            return countOfOnes > 0 ? -1 : days;
        }
    }
}
