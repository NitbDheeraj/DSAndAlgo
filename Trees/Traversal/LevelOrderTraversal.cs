using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Traversal
{
    /// <summary>
    /// • Visit the root.
    /// • While traversing level 1, keep all the elements at level 1+1 in queue.
    /// • Go to the next level and visit all the nodes at that level.
    /// • Repeat this until all levels are completed.
    /// </summary>
    public class LevelOrderTraversal<T>
    {
        public void LevelOrder(BinaryTreeNode<T> root)
        {
            List<T> curr = new List<T>();
            if (root == null)
                return;

            Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();
            q.Enqueue(root);

            while(q.Count() > 0)
            {
                BinaryTreeNode<T> temp = q.Dequeue();
                if(temp != null)
                {
                    curr.Add(temp.Data);
                    if (temp.Left != null)
                        q.Enqueue(temp.Left);
                    if (temp.Right != null)
                        q.Enqueue(temp.Right);
                }

            }

            curr.ForEach(x => Console.Write(x.ToString()));   
        }
    }
}
