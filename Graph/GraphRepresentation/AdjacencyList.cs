using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.GraphRepresentation
{

    /*  The Adjacency List is an array of LinkedList<>, where each element is a Tuple<>. This Tuple stores two values, the destination vertex, (V2 in an edge V1 → V2) and the weight of the edge.
     *  For adding an edge, we can call –
            void addEdgeAtEnd(int startVertex, int endVertex, int weight) – To append an edge to the linked list.
            void addEdgeAtBegin(int startVertex, int endVertex, int weight) – To add an edge at the beginning of the linked list.
     *  Methods have been provided to return the number of vertices.
     *  An Indexer has been provided to help in retrieving the edges from a vertex. We can use Count property on this, to get the number of edges from a vertex.
     *  bool removeEdge(int startVertex, int endVertex, int weight) – Tries to remove the first occurrence an edge from the adjacency list. Returns true if successfull.
     */
    public class AdjacencyList
    {
        LinkedList<Tuple<int, int>>[] _adjacencyList;

        //Constructor creates an empty adjacency list
        public AdjacencyList(int vertices)
        {
            _adjacencyList = new LinkedList<Tuple<int, int>>[vertices];
            for (int i = 0; i < _adjacencyList.Length; i++)
            {
                _adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        // Appends a new Edge to the linked list
        public void addEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            _adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }

        // Adds a new Edge to the linked list from the front
        public void addEdgeAtBegining(int startVertex, int endVertex, int weight)
        {
            _adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }

        // Returns number of vertices
        // Does not change for an object
        public int GetNumberOfVertices()
        {
            return _adjacencyList.Length;
        }

        // Returns a copy of the Linked List of outward edges from a vertex
        public LinkedList<Tuple<int, int>> this[int index]
        {
            get
            {
                LinkedList<Tuple<int, int>> edgeList = new LinkedList<Tuple<int, int>>(_adjacencyList[index]);
                return edgeList;
            }
        }

        // Print Adjacency List 
        public void printAdjacencyList()
        {
            int i = 0;
            foreach (var item in _adjacencyList)
            {
                Console.Write("adjacencyList[" + i + "] -> ");
                foreach (Tuple<int, int> edge in item)
                {
                    Console.Write(edge.Item1 + "(" + edge.Item2 + ")");
                }

                ++i;
                Console.WriteLine();
            }
        }

        // Removes the first occurence of an edge and returns true
        // if there was any change in the collection, else false
        public bool removeEdge(int startVertex, int endVertex, int weight)
        {
            Tuple<int, int> edge = new Tuple<int, int>(endVertex, weight);

            return _adjacencyList[startVertex].Remove(edge);
        }

    }
}
