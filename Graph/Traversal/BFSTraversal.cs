using Graph.GraphRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    /*  The BFS algorithm works similar to level – order traversal of the trees. Like level – order
        traversal, BFS also uses queues. In fact, level – order traversal got inspired from BFS. BFS
        works level by level. Initially, BFS starts at a given vertex, which is at level 0. In the first stage it
        visits all vertices at level 1 (that means, vertices whose distance is 1 from the start vertex of the
        graph). In the second stage, it visits all vertices at the second level. These new vertices are the
        ones which are adjacent to level 1 vertices. BFS continues this process until all the levels of the
        graph are completed. Generally queue data structure is used for storing the vertices of a level.
        As similar to DFS, assume that initially all vertices are marked unvisited (false). Vertices that
        have been processed and removed from the queue are marked visited (true). We use a queue to
        represent the visited set as it will keep the vertices in the order of when they were first visited.
        The implementation for the above discussion can be given as
     */
    public class BFSTraversal : CommonGraph
    {
        private Vertex[] _vertexList;
        private Queue<int> _theQueue;
        private int _vertexCount;
        private AdjacencyMatrix _adjacencyMatrix;

        public BFSTraversal(AdjacencyMatrix adjacencyMatrix, Vertex[] vertexList, int vertexCount) :
            base(adjacencyMatrix, vertexList, vertexCount)
        {
            _vertexList = vertexList;
            _theQueue = new Queue<int>(); ;
            _vertexCount = vertexCount;
            _adjacencyMatrix = adjacencyMatrix;
        }

        public void BFS()
        {
            _vertexList[0].Visited = true;
            DisplayVertex(0);
            _theQueue.Enqueue(0);
            int v2;
            while (_theQueue.Count() > 0)
            {
                int v1 = _theQueue.Dequeue();
                while ((v2 = GetUnvisitedAdjVertex(v1)) != -1)
                {
                    _vertexList[v2].Visited = true;
                    DisplayVertex(v2);
                    _theQueue.Enqueue(v2);
                }
            }

            for (int i = 0; i < _vertexCount; i++)
                _vertexList[i].Visited = false;

        }

    }
}
