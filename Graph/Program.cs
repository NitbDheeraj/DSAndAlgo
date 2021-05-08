using Graph.GraphRepresentation;
using Graph.Traversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
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
        static void Main(string[] args)
        {
            AdjacencyMatrix aM = new AdjacencyMatrix(8);
            aM.addEdge(0, 1);
            aM.addEdge(1, 2);
            aM.addEdge(1, 7);
            aM.addEdge(2, 4);
            aM.addEdge(7, 4);
            aM.addEdge(4, 6);
            aM.addEdge(2, 3);
            aM.addEdge(4, 5);

            Vertex A = new Vertex('A');
            Vertex B = new Vertex('B');
            Vertex C = new Vertex('C');
            Vertex D = new Vertex('D');
            Vertex E = new Vertex('E');
            Vertex F = new Vertex('F');
            Vertex G = new Vertex('G');
            Vertex H = new Vertex('H');
            Vertex[] vertexList = new Vertex[8] { A,B,C,D,E,F,G,H};

            //CommonGraph cG = new CommonGraph(aM, vertexList, 8);
            TraversalHelper.AllTraversal(aM, vertexList, 8);

                //    5         4
                //   / \       / \
                //  /   \     /   \
                // v     v   v     v
                //2        0        1
                // \               ^
                //  \             /
                //   \           /
                //     \        /
                //       \     /
                //        v   /
                //          3

            // Create a graph given
            // in the above diagram
            TopologicalSort g = new TopologicalSort(6);
            g.AddEdge(5, 2);
            g.AddEdge(5, 0);
            g.AddEdge(4, 0);
            g.AddEdge(4, 1);
            g.AddEdge(2, 3);
            g.AddEdge(3, 1);

            Console.WriteLine("Following is a Topological "
                              + "sort of the given graph");

            // Function Call
            g.TopologicalSorting();

            Console.ReadLine();
        }
    }
}
