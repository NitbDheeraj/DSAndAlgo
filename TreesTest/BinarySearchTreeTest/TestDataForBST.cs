using Trees.BinarySearchTrees;

namespace TreesTest.BinarySearchTreeTest
{
    public static class TestDataForBST
    {
        //  Create a binary tree
        //              7
        //             / \
        //            4   9
        //           / \ / \
        //          2  5 8  10 
        public static BSTNode<int> CreateBinaryTree()
        {
            BSTNode<int> binaryTree = new BSTNode<int>(7);

            BSTNode<int> leftNode = new BSTNode<int>(4);
            BSTNode<int> leftLeftChild = new BSTNode<int>(2);
            BSTNode<int> leftRightChild = new BSTNode<int>(5);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BSTNode<int> rightNode = new BSTNode<int>(9);
            BSTNode<int> rightLeftChild = new BSTNode<int>(8);
            BSTNode<int> rightRightChild = new BSTNode<int>(10);
            rightNode.SetLeft(rightLeftChild);
            rightNode.SetRight(rightRightChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }

        //  Create a binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / \
        //          4  5 6  7 
        public static BSTNode<int> CreateNonBST()
        {
            BSTNode<int> binaryTree = new BSTNode<int>(1);

            BSTNode<int> leftNode = new BSTNode<int>(2);
            BSTNode<int> leftLeftChild = new BSTNode<int>(4);
            BSTNode<int> leftRightChild = new BSTNode<int>(5);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BSTNode<int> rightNode = new BSTNode<int>(3);
            BSTNode<int> rightLeftChild = new BSTNode<int>(6);
            BSTNode<int> rightRightChild = new BSTNode<int>(7);
            rightNode.SetLeft(rightLeftChild);
            rightNode.SetRight(rightRightChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }

    }
}
