using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    /*  There are a total of n courses you have to take, labeled from 0 to n-1. 
     *  Some courses may have prerequisites, for example to take course 0 you have to first take course 1, 
     *  which is expressed as a pair: 0,1 Given the total number of courses and a list of prerequisite pairs, 
     *  return the ordering of courses you should take to finish all courses. 
     *  There may be multiple correct orders, you just need to return one of them. 
     *  If it is impossible to finish all courses, return an empty array.
     */
    public class CourseScheduling
    {
        // No. of vertices
        private int V;

        // Adjacency List as ArrayList
        // of ArrayList's
        private List<List<int>> adj;

        public CourseScheduling(int v)
        {
            V = v;
            adj = new List<List<int>>(v);
            for (int i = 0; i < v; i++)
                adj.Add(new List<int>());
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w) { adj[v].Add(w); }

        // A recursive function used by topologicalSort
        void CourseSchedulingUtil(int v, bool[] visited, Stack<int> stack)
        {
            // Mark the current node as visited.
            visited[v] = true;

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (var vertex in adj[v])
            {
                if (!visited[vertex])
                    CourseSchedulingUtil(vertex, visited, stack);
            }

            // Push current vertex to
            // stack which stores result
            stack.Push(v);
        }

        // The function to do Topological Sort.
        // It uses recursive topologicalSortUtil()
        public void CourseSchedulingAlgo()
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
                    CourseSchedulingUtil(i, visited, stack);
            }

            // Print contents of stack
            foreach (var vertex in stack)
            {
                Console.Write(vertex + " ");
            }
        }

    }
}
