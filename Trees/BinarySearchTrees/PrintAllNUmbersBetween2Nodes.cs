using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class PrintAllNUmbersBetween2Nodes
    {

        public void PrintNumbersBetween2Nodes(BSTNode<int> root, int K1, int K2)
        {
            if (root == null)
                return;

            if (root.Data >= K1)
                PrintNumbersBetween2Nodes(root.Left, K1, K2);

            if (root.Data >= K1 && root.Data <= K2)
                Console.Write(root.Data);

            if (root.Data <= K2)
                PrintNumbersBetween2Nodes(root.Right, K1, K2);
        }

        //Use level order traversal
        public void PrintNumbersBetween2NodesIteratively(BSTNode<int> root, int K1, int K2)
        {
            if (root == null)
                return;
            Queue<BSTNode<int>> q = new Queue<BSTNode<int>>();
            q.Enqueue(root);

            while(q.Count() > 0)
            {
                var temp = q.Dequeue();

                if (temp.Data >= K1 && temp.Data < K2)
                    Console.Write(temp.Data);

                if (temp.Left != null && temp.Left.Data >= K1)
                    q.Enqueue(temp.Left);

                if (temp.Right != null && temp.Right.Data <= K2)
                    q.Enqueue(temp.Right);

            }

        }

    }
}
