using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    public class Common
    {
        public int _maxVertices = 20;
        public Vertex[] _vertexList;
        public int[,] _adjMatrix;
        public int _vertexCount;
        public Stack<int> _theStack;
        public Queue<int> _theQueue;

        public Common()
        {
            _vertexList = new Vertex[_maxVertices];
            _adjMatrix = new int[_maxVertices, _maxVertices];
            _vertexCount = 0;
            for (int i = 0; i < _maxVertices; i++)
            {
                for (int j = 0; j < _maxVertices; j++)
                {
                    _adjMatrix[i, j] = 0;
                }
            }
            _theStack = new Stack<int>();
            _theQueue = new Queue<int>();
        }

        private void addVertex(char lab)
        {
            _vertexList[_vertexCount++] = new Vertex(lab);
        }

        private void addEdge(int start, int end)
        {
            _adjMatrix[start, end] = 1;
            _adjMatrix[end, start] = 1;
        }

        public void DisplayVertex(int v)
        {
            Console.Write(_vertexList[v].label);
        }

        public int GetUnvisitedAdjVertex(int v)
        {
            for (int i = 0; i < _vertexCount; i++)
            {
                if (_adjMatrix[v, i] == 0 && _vertexList[v].visited == false)
                    return i;

            }
            return -1;
        }
    }

    public class Vertex
    {
        public char label;
        public Boolean visited;
        public Vertex(char lab)
        {
            label = lab;
            visited = false;
        }
    }
}
