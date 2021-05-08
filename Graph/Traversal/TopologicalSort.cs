using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    /*      Topological sorting for Directed Acyclic Graph (DAG) is a linear ordering of vertices 
     *      such that for every directed edge u v, vertex u comes before v in the ordering. 
     *      Topological Sorting for a graph is not possible if the graph is not a DAG.
            For example, a topological sorting of the following graph is “5 4 2 3 1 0”. 
            There can be more than one topological sorting for a graph. 
            For example, another topological sorting of the following graph is “4 5 2 3 1 0”. 
            The first vertex in topological sorting is always a vertex with in-degree as 0 (a vertex with no incoming edges).

                //    5         4
                //   / \       / \
                //  /   \     /   \
                // v     v   v     v
                //2        0        1
                // \               ^
                //  \             /
                //   \           /
                //     \        /
                //       \     /
                //        v   /
                //          3
            
     * 
     */

    public class TopologicalSort
    {
        // No. of vertices
        private int V;

        // Adjacency List as ArrayList
        // of ArrayList's
        private List<List<int>> adj;

        //Constructor
        public TopologicalSort(int v)
        {
            V = v;
            adj = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adj.Add(new List<int>());
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w) { adj[v].Add(w); }

        // A recursive function used by topologicalSort
        void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
        {
            // Mark the current node as visited.
            visited[v] = true;

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (var vertex in adj[v])
            {
                if (!visited[vertex])
                    TopologicalSortUtil(vertex, visited, stack);
            }

            // Push current vertex to
            // stack which stores result
            stack.Push(v);
        }

        // The function to do Topological Sort.
        // It uses recursive topologicalSortUtil()
        public void TopologicalSorting()
        {
            Stack<int> stack = new Stack<int>();

            // Mark all the vertices as not visited
            var visited = new bool[V];

            // Call the recursive helper function
            // to store Topological Sort starting
            // from all vertices one by one
            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                    TopologicalSortUtil(i, visited, stack);
            }

            // Print contents of stack
            foreach (var vertex in stack)
            {
                Console.Write(vertex + " ");
            }
        }
    }
}
