using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class CountCovidClusters
    {
        // Below arrays detail all eight possible movements from a cell
        // (top, right, bottom, left, and four diagonal moves)
        private int[] row = new int[8] { -1, -1, -1, 0, 1, 0, 1, 1 };
        private int[] col = new int[8] { -1, 1, 0, -1, -1, 1, 0, 1 };


        /*  The solution is inspired by finding the total number of connected components in a graph problem. 
         *  The idea is to start Breadth–first search (BFS) from each unprocessed node and increment the island count.
         *  Each BFS traversal will mark all cells which make one island as processed. 
         *  So, the problem reduces to finding the total number of BFS calls.
         */
        public int CountIslands(int[,] graph)
        {
            if (graph == null || graph.Length == 0)
                return 0;

            int M = graph.GetLength(0);
            int N = graph.GetLength(1);

            bool[,] processed = new bool[M, N];

            int islands = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(graph[i,j] == 1 && !processed[i,j])
                    {
                        BFS(graph, processed, i, j);
                        islands++;
                    }
                }
            }

            return islands;
        }

        public class Node
        {
            public int x, y;

            public Node(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        private void BFS(int[,] graph, bool[,] processed, int x, int y)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(new Node(x, y));

            processed[x, y] = true;

            while(q.Count() > 0)
            {
                var n = q.Peek();

                var a = n.x;
                var b = n.y;

                q.Dequeue();

                for (int i = 0; i < 8; i++)
                {
                    if(IsSafe(graph, a + row[i], b + col[i], processed) )
                    {
                        processed[a + row[i], b + col[i]] = true;
                        q.Enqueue(new Node(a + row[i], b + col[i]));
                    }
                }

            }
        }

        public static bool IsSafe(int[,] mat, int x, int y, bool[,] processed)
        {
            return (x >= 0 && x < processed.GetLength(0)) && (y >= 0 && y < processed.GetLength(1))
                    && mat[x, y] == 1 && !processed[x, y];
        }

    }
}
