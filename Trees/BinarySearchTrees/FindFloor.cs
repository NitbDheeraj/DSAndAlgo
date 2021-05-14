using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    /*  If a given key is less than the key at the root of a BST then the
        floor of the key (the largest key in the BST less than or equal to the key) must be in the left
        subtree. If the key is greater than the key at the root, then the floor of the key could be in the
        right subtree, but only if there is a key smaller than or equal to the key in the right subtree;
        if not (or if the key is equal to the the key at the root) then the key at the root is the floor of
        the key. Finding the ceiling is similar, with interchanging right and left. For example, if the
        sorted with input array is {1, 2, 8, 10, 10, 12, 19}, then
        For x = 0: floor doesn’t exist in array, ceil = 1,
        For x = 1: floor = 1, ceil = 1
        For x = 5: floor =2, ceil =8,
        For x = 20: floor = 19, ceil doesn’t exist in array
     */

    public class FindFloor
    {
        public int FindBSTFloor(BSTNode<int> root, BSTNode<int> Key)
        {
            return FindBSTFloorUtil(root, Key, int.MinValue);
        }

        private int FindBSTFloorUtil(BSTNode<int> root, BSTNode<int> key, int Prev)
        {
            if (root == null)
                return 0;

            FindBSTFloorUtil(root.Left, key, Prev);
            //Current Data
            if (root.Data == key.Data)
                return root.Data;

            if (Prev < key.Data && root.Data > key.Data)
                return Prev;

            Prev = root.Data;
            
            return FindBSTFloorUtil(root.Right, key, Prev);
        }
    }
}
