using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.SimpleTraversal
{
    class AdjacencyMatrixTraversal
    {
        public void GetTraversal()
        {
            //Create a graph
            //      A(0)
            //      |
            //      |
            //      B(1)------H(7)
            //      |         |
            //      |         |
            //      C(2)------E(4)------G(6)
            //      |         |
            //      |         |
            //      D(3)      F(5)

            Vertex A = new Vertex('A');
            Vertex B = new Vertex('B');
            Vertex C = new Vertex('C');
            Vertex D = new Vertex('D');
            Vertex E = new Vertex('E');
            Vertex F = new Vertex('F');
            Vertex G = new Vertex('G');
            Vertex H = new Vertex('H');
            Vertex[] vertexList = new Vertex[8] { A, B, C, D, E, F, G, H };

            Graph g = new Graph(vertexList);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(1, 7);
            g.AddEdge(2, 4);
            g.AddEdge(7, 4);
            g.AddEdge(4, 6);
            g.AddEdge(2, 3);
            g.AddEdge(4, 5);


            //g.DFS();
            g.BFS();

            Console.ReadLine();
        }

    }

    public class Graph
    {
        private Boolean[,] _adjMatrix;
        private Vertex[] _vertexList;
        private int _vertexCount;

        public Graph(Vertex[] vertexList)
        {
            _vertexCount = vertexList.Length;
            this._adjMatrix = new Boolean[_vertexCount, _vertexCount];
            _vertexList = vertexList;

            //Stack and Queue are for DFS and BFS
            _stack = new Stack<int>();
            _queue = new Queue<int>();
        }

        public void AddEdge(int to, int from)
        {
            _adjMatrix[to, from] = true;
            _adjMatrix[from, to] = true;
        }

        public bool IsEdge(int to, int from)
        {
            return _adjMatrix[to, from];
        }

        public void DisplayVertex(Vertex v)
        {
            Console.WriteLine(v.label);
        }

        private int GetUnvisitedAdjVertex(int v)
        {
            for (int i = 0; i < _vertexCount; i++)
            {
                if (IsEdge(v, i) && _vertexList[i].Visited == false)
                    return i;
            }
            return -1;
        }

        // DFS

        private Stack<int> _stack;

        public void DFS()
        {
            _vertexList[0].Visited = true;
            DisplayVertex(_vertexList[0]);
            _stack.Push(0);
            while (_stack.Count() > 0)
            {
                int v = GetUnvisitedAdjVertex(_stack.Peek());
                if (v == -1)
                {
                    _stack.Pop();
                }
                else
                {
                    _vertexList[v].Visited = true;
                    DisplayVertex(_vertexList[v]);
                    _stack.Push(v);
                }
            }
        }



        //BFS

        Queue<int> _queue;


        public void BFS()
        {
            _vertexList[0].Visited = true;
            //DisplayVertex
            DisplayVertex(_vertexList[0]);
            _queue.Enqueue(0);
            int v2;
            while (_queue.Count() > 0)
            {
                var v1 = _queue.Dequeue();
                while ((v2 = GetUnvisitedAdjVertex(v1)) != -1)
                {
                    _vertexList[v2].Visited = true;
                    //DisplayVertex;
                    DisplayVertex(_vertexList[v2]);
                    _queue.Enqueue(v2);
                }

            }
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
