using Graph.GraphRepresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Traversal
{
    public static class TraversalHelper
    {
        public static void AllTraversal(AdjacencyMatrix aM, Vertex[] vertexList, int vertexCount)
        {
            Console.WriteLine("BFS traversal for the given matrix!");
            BFSTraversal bFS = new BFSTraversal(aM, vertexList, vertexCount);
            bFS.BFS();
            Console.WriteLine("\n");

            Console.WriteLine("DFS traversal for the given matrix!");
            DFSTraversal dFS = new DFSTraversal(aM, vertexList, vertexCount);
            dFS.DFS();
            Console.WriteLine("\n");
        }
        

    }
}
