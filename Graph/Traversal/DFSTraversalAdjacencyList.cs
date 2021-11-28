using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    //time complexity of DFS is O(V + E) if adjacency list is used
    public class DFSTraversalAdjacencyList
    {
        private int _v;
        private List<int>[] _adj;
        
        public DFSTraversalAdjacencyList(int v)
        {
            _v = v;
            _adj = new List<int>[v];
            for (int i = 0; i < v; i++)
                _adj[i] = new List<int>();
        }

        public void AddEdge(int u, int w)
        {
            _adj[u].Add(w);
        }

        public void DFS(int s)
        {
            bool[] _visited = new bool[_v];

            DFSUtil(s, _visited);
        }

        private void DFSUtil(int s, bool[] visited)
        {
            visited[s] = true;
            Console.Write(s);

            foreach (var item in _adj[s])
            {
                if (!visited[item])
                    DFSUtil(item, visited);
            }

        }
    }


    public class DFSAdjacencyListForDisconnectedGraph
    {
        private int _v;
        private List<int>[] _adj;

        public DFSAdjacencyListForDisconnectedGraph(int v)
        {
            _v = v;
            _adj = new List<int>[v];
            for (int i = 0; i < v; i++)
                _adj[i] = new List<int>();
        }

        public void AddEdge(int u, int w)
        {
            _adj[u].Add(w);
        }

        public void DFS(int s)
        {
            bool[] _visited = new bool[_v];

            for (int i = 0; i < _v; ++i)
                if (!_visited[i])
                    DFSUtil(i, _visited);
        }

        private void DFSUtil(int s, bool[] visited)
        {
            visited[s] = true;
            Console.Write(s);

            foreach (var item in _adj[s])
            {
                if (!visited[item])
                    DFSUtil(item, visited);
            }

        }
    }

}
