using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    /*  Input : 
                        1
                      /   \
                     2     3
                    / \     \
                   4   5     6             
       Output : 1 2 4

       Input :
               1
             /   \
           2       3
             \   
               4  
                 \
                   5
                    \
                      6
       Output :1 2 4 5 6
    */

    /*
     * In this method, level order traversal based solution is discussed. 
     * If we observe carefully, we will see that our main task is to print the left most node of every level. 
     * So, we will do a level order traversal on the tree and print the leftmost node at every level. 
     * Below is the implementation of above approach:
     */
    public class LeftView
    {
        public int[] leftViewOfBT(Node root)
        {
            List<int> arr = new List<int>(); ;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count() > 0)
            {
                var size = q.Count();

                for (int i = 0; i < size; i++)
                {
                    var temp = q.Dequeue();
                    if (i == 0)
                        arr.Add(temp.data);

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }
            }
            return arr.ToArray();
        }

    }
}
