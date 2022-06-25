using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.GraphRepresentation
{
    public class SimpleAdjacencyList
    {
        public int _vertexCount;
        public List<List<int>> _adjList;

        public SimpleAdjacencyList(int vertexCount)
        {
            _vertexCount = vertexCount;
            _adjList = new List<List<int>>(vertexCount);

            for (int i = 0; i < _vertexCount; i++)
            {
                _adjList.Add(new List<int>());
            }
        }

        public void addEdge(int u, int v)
        {
            if (u >= 0 && u < _vertexCount && v >= 0 && v < _vertexCount)
                _adjList[u].Add(v);
        }

    }
}
