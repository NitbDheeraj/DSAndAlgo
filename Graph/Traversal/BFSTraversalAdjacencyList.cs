using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    public class BFSTraversalAdjacencyList
    {
        private int _V;
        List<int>[] _adj;

        public BFSTraversalAdjacencyList(int V)
        {
            _V = V;
            _adj = new List<int>[V];
            for (int i = 0; i < V; i++)
                _adj[i] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            _adj[v].Add(w);
        }
        //s is starting vertex
        public void BFS(int s)
        {
            bool[] _visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                _visited[i] = false;

            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            _visited[s] = true;

            while(q.Count() > 0)
            {
                int first = q.Dequeue();
                Console.Write(s);
                List<int> l = _adj[s];
                foreach (var item in l)
                {
                    if(!_visited[item])
                    {
                        _visited[item] = true;
                        Console.Write(item);
                        q.Enqueue(item);

                    }
                }

            }

        }

    }
}
