using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class FindCousins
    {
        public void PrintCousins(Node root, Node node_to_find)
        {
            if (root == node_to_find)
                Console.WriteLine("No Cousins");

            Queue<Node> q = new Queue<Node>();
            int size = 0;
            q.Enqueue(root);

            bool levelFound = false;

            //Normal level order traversal
            while(q.Count() > 0 && !levelFound)
            {
                size = q.Count();
                while (size-- > 0)
                {
                    var temp = q.Dequeue();

                    if (temp.left.data == node_to_find.data || temp.right.data == node_to_find.data)
                        levelFound = true;
                    else
                    {
                        if (temp.left != null)
                            q.Enqueue(temp.left);
                        if (temp.right != null)
                            q.Enqueue(temp.right);
                    }
                }
            }

            //If found == true then level will have cousins of the node

            if(levelFound)
            {
                size = q.Count();

                if(size == 0)
                    Console.WriteLine("No Cousins");

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(q.Dequeue().data);
                }
            }

        }
    }

    public class CousinsTest
    {
        public void FindCousinsTest()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.left.right.right = new Node(15);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.right.left.right = new Node(8);

            //Node x = new Node(43);

            //printCousins(root, x);

            FindCousins fc = new FindCousins();
            fc.PrintCousins(root, root.left.right);
        }
    }

}
