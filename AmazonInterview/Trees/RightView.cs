using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    public class RightView
    {
        public int[] rightViewOfBT(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            List<int> res = new List<int>();

            while(q.Count() > 0)
            {
                var size = q.Count();
                for (int i = 0; i < size; i++)
                {
                    var temp = q.Dequeue();

                    if (i == size - 1)
                        res.Add(temp.data);

                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }
            }

            return res.ToArray();
        }

    }
}
