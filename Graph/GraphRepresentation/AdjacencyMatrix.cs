using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.GraphRepresentation
{

    /*  The adjacency matrix representation is good if the graphs are dense. The matrix requires O(V2) bits of storage and O(V2) time for initialization. If the number of edges is proportional to V2
        , then there is no problem because V2 steps are required to read the edges. If the graph is sparse, the
        initialization of the matrix dominates the running time of the algorithm as it takes takes O(V2).
     */
    public class AdjacencyMatrix
    {
        private Boolean[,] _adjMatrix;
        private int _vertexCount;

        public AdjacencyMatrix(int vertexCount)
        {
            this._vertexCount = vertexCount;
            _adjMatrix = new Boolean[vertexCount, vertexCount];
        }

        public void addEdge(int i, int j)
        {
            if (i >= 0 && i < _vertexCount && j >= 0 && j < _vertexCount)
            {
                _adjMatrix[i, j] = true;
                _adjMatrix[j, i] = true;
            }
        }

        public void removeEdge(int i, int j)
        {
            if (i >= 0 && i < _vertexCount && j >= 0 && j < _vertexCount)
            {
                _adjMatrix[i, j] = false;
                _adjMatrix[j, i] = false;
            }
        }

        public bool isEdge(int i, int j)
        {
            if (i >= 0 && i < _vertexCount && j >= 0 && j < _vertexCount)
                return _adjMatrix[i, j];
            else
                return false;
        }

    }
}
