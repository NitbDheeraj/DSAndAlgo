using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    /*  DFS algorithm works in a manner similar to preorder traversal of the trees. Like preorder traversal, internally this algorithm also uses stack.
    The time complexity of DFS is O(V + E), if we use adjacency lists for representing the graphs.
    This is because we are starting at a vertex and processing the adjacent nodes only if they are not
    visited. Similarly, if an adjacency matrix is used for a graph representation, then all edges
    adjacent to a vertex can’t be found efficiently, and this gives O(V2) complexity
 */
    public class Graph : Common
    {
        public void DFS()
        {
            _vertexList[0].visited = true;
            DisplayVertex(0);
            _theStack.Push(0);
            while (_theStack.Count() > 0)
            {
                //Get an unvisited vertex adjacent to stack top
                int v = GetUnvisitedAdjVertex(_theStack.Peek());
                if (v == -1)
                    _theStack.Pop();
                else
                {
                    _vertexList[v].visited = true;
                    DisplayVertex(v);
                    _theStack.Push(v);
                }
            }
            for (int j = 0; j < _vertexCount; j++)
            {
                _vertexList[j].visited = false;
            }
        }

    }

}
