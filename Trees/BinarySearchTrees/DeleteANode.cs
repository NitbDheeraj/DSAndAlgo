using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class DeleteANode
    {

        public BSTNode<int> DeleteNode(BSTNode<int> root, BSTNode<int> node)
        {
            BSTNode<int> temp;

            if (root == null)
                Console.Write("Error!!");
            else if (root.Data < node.Data)
                root.Left = DeleteNode(root.Left, node);
            else if (root.Data > node.Data)
                root.Right = DeleteNode(root.Right, node);
            else
            {
                //Found Data to delete
                if(root.Left != null && root.Right != null)
                {
                    //Get max node in left sub tree
                    FindAnElementInBST findElement = new FindAnElementInBST();
                    temp = findElement.FindMaximum(root.Left);
                    root.SetData(temp.Data);
                    DeleteNode(root.Left, temp);
                }
                else
                {
                    //One child
                    temp = root;
                    if (root.Left != null)
                        root = root.Right;
                    if (root.Right != null)
                        root = root.Left;

                }
            }

            return root;
        }

    }
}
