using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class VerticalSum
    {
        public void PrintVerticalSum(Node root)
        {
            // create a dictionary where key —> relative horizontal distance of the node from the root node, and
            // value —> sum of all nodes present at the same horizontal distance
            Dictionary<int, int> map = new Dictionary<int, int>();

            // perform preorder traversal on the tree and fill the map
            PrintVerticalSum(root, 0, map);

            Console.WriteLine(map.Values);
        }

        public void PrintVerticalSum(Node node, int dist, Dictionary<int, int> map)
        {
            //Base Case
            if (node == null)
                return;

            //Update the map
            if (map.ContainsKey(dist))
                map[dist] += node.data;
            else
                map.Add(dist, 0);

            // recur for the left subtree by decreasing horizontal distance by 1
            PrintVerticalSum(node.left, dist - 1, map);

            // recur for the right subtree by increasing horizontal distance by 1
            PrintVerticalSum(node.right, dist + 1, map);
        }

    }
}
