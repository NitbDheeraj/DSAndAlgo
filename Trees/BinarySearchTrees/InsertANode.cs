using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class InsertANode
    {
        public BSTNode<int> InsertANodeInBST(BSTNode<int> bST, BSTNode<int> node)
        {
            if (bST == null)
            {
                bST = node;
                bST.SetData(node.Data);
                Console.Write("Node Inserted Successfully");
                return bST;
            }
            else
            {
                if (node.Data < bST.Data)
                    bST.Left = InsertANodeInBST(bST.Left, node);
                else if(node.Data > bST.Data)
                    bST.Right = InsertANodeInBST(bST.Right, node);
            }
            return bST;
        }


    }
}
