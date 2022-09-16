using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    /// <summary>
    /// Convert given BST to Doubly Linked List (DLL) 
    /// Now iterate through every node of DLL and if the key of node is negative, 
    /// then find a pair in DLL with sum equal to key of current node multiplied by -1.
    /// </summary>
    public class BSTTripletAddingToZero
    {
        // A BST node has key, and left and right pointers
        public class node
        {
            public int key;
            public node left;
            public node right;
        };
        static node head;
        static node tail;
        // A function to convert given BST to Doubly
        // Linked List. left pointer is used
        // as previous pointer and right pointer
        // is used as next pointer. The function
        // sets *head to point to first and *tail
        // to point to last node of converted DLL

        static void convertBSTtoDLL(node root)
        {

            // Base case
            if (root == null)
                return;

            // First convert the left subtree
            if (root.left != null)
                convertBSTtoDLL(root.left);

            // Then change left of current root
            // as last node of left subtree
            root.left = tail;

            // If tail is not null, then set right
            // of tail as root, else current
            // node is head
            if (tail != null)
                (tail).right = root;
            else
                head = root;

            // Update tail
            tail = root;

            // Finally, convert right subtree
            if (root.right != null)
                convertBSTtoDLL(root.right);
        }


        // This function returns true if there
        // is pair in DLL with sum equal to given
        // sum. The algorithm is similar to hasArrayTwoCandidates()
        // in method 1 of http://tinyurl.com/dy6palr
        static bool isPresentInDLL(node head, node tail, int sum)
        {
            while (head != tail)
            {
                int curr = head.key + tail.key;
                if (curr == sum)
                    return true;
                else if (curr > sum)
                    tail = tail.left;
                else
                    head = head.right;
            }
            return false;
        }

        // The main function that returns
        // true if there is a 0 sum triplet in
        // BST otherwise returns false
        static bool isTripletPresent(node root)
        {

            // Check if the given BST is empty
            if (root == null)
                return false;

            // Convert given BST to doubly linked list. head and tail store the
            // pointers to first and last nodes in DLLL
            head = null;
            tail = null;
            convertBSTtoDLL(root);

            // Now iterate through every node and
            // find if there is a pair with sum
            // equal to -1 * head.key where head is current node
            while ((head.right != tail) && (head.key < 0))
            {
                // If there is a pair with sum
                // equal to -1*head.key, then return
                // true else move forward
                if (isPresentInDLL(head.right, tail, -1 * head.key))
                    return true;
                else
                    head = head.right;
            }

            // If we reach here, then
            // there was no 0 sum triplet
            return false;
        }


    }
}
