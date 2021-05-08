using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    public class BFS : Common
    {
        public BFS()
        {
            _vertexList[0].visited = true;
            DisplayVertex(0);
            _theQueue.Enqueue(0);
            int v2;
            while (_theQueue.Count() > 0)
            {
                int v1 = _theQueue.Dequeue();
                v2 = GetUnvisitedAdjVertex(v1);
                while (v2 != -1)
                {
                    _vertexList[v2].visited = true;
                    DisplayVertex(v2);
                    _theQueue.Enqueue(v2);
                }
            }

            for (int i = 0; i < _vertexCount; i++)
                _vertexList[i].visited = false;

        }

    }
}
