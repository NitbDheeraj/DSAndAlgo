using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Traversal;

namespace Trees
{
    public static class AllTraversal
    {
        // binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / \
        //          4  5 6  7
        public static void AllTraversals(BinaryTreeNode<int> binaryTree)
        {
            // Preorder Traversal should print 1245367
            Console.WriteLine("Pre order traversal in recursive manner!");
            PreOrderTraversal<int> pOT = new PreOrderTraversal<int>();
            pOT.PreOrder(binaryTree);
            Console.WriteLine("\nWriting in Iterative manner!");
            pOT.IterativePreOrder(binaryTree);
            Console.WriteLine("\n");


            // Inorder Traversal should print 4251637
            Console.WriteLine("\nIn order traversal in recursive manner!");
            InOrderTraversal<int> iOT = new InOrderTraversal<int>();
            iOT.InOrder(binaryTree);
            Console.WriteLine("\nWriting in Iterative manner!");
            iOT.IterativeInOrder(binaryTree);
            Console.WriteLine("\n");

            // Post order traversal should print 4526731
            Console.WriteLine("\nPost order traversal in recursive manner!");
            PostOrderTraversal<int> poOT = new PostOrderTraversal<int>();
            poOT.PostOrder(binaryTree);
            Console.WriteLine("\nWriting in Iterative manner!");
            poOT.IterativePostOrder(binaryTree);
            Console.WriteLine("\n");

            //Level order traversal should be 1234567
            Console.WriteLine("\nLevel order traversal!");
            LevelOrderTraversal<int> lOT = new LevelOrderTraversal<int>();
            lOT.LevelOrder(binaryTree);
        }

    }
}
