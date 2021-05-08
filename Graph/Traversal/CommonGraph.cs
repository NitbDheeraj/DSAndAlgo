using Graph.GraphRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    public class CommonGraph
    {
        private const int _maxVertices = 20;
        private Vertex[] _vertexList;
        private AdjacencyMatrix _adjMatrix;
        private int _vertexCount;
        private Stack<int> _theStack;
        private Queue<int> _theQueue;

        public CommonGraph(AdjacencyMatrix adjMat, Vertex[] vertex, int vertexCount)
        {
            _vertexList = vertex;
            _adjMatrix = adjMat;
            _vertexCount = vertexCount;
            _theStack = new Stack<int>();
            _theQueue = new Queue<int>();
        }

        private void addVertex(char lab)
        {
            _vertexList[_vertexCount++] = new Vertex(lab);
        }

        private void addEdge(int start, int end)
        {
            _adjMatrix.addEdge(start, end);
            _adjMatrix.addEdge(end, start);
        }

        public void DisplayVertex(int v)
        {
            Console.Write(_vertexList[v].label);
        }

        public int GetUnvisitedAdjVertex(int v)
        {
            for (int i = 0; i < _vertexCount; i++)
            {
                if (_adjMatrix.isEdge(v,i) && !_vertexList[i].Visited)
                    return i;

            }
            return -1;
        }
    }

    public class Vertex
    {
        public char label;
        private Boolean _visited;

        public Boolean Visited
        {
            get { return _visited; }   // get method
            set { _visited = value; }  // set method
        }

        public Vertex(char lab)
        {
            label = lab;
            _visited = false;
        }
    }
}
