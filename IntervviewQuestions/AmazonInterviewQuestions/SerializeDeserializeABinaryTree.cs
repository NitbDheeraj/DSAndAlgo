using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions.AmazonInterviewQuestions
{
    //Serialization is to store the binary tree into a file
    //Deserialization is reading back

    //A simple solution is to store both Inorder and preorder traversal. This solution requires space twice the size of binary tree.
    // Save the space by storing preorder traversal and a markers for null pointers.
    
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int x)
        {
            val = x;
        }
    }
    
    public class SerializeDeserializeABinaryTree
    {
        /// <summary>
        /// storing preorder traversal and a markers for null pointers
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public string SerializeBT(TreeNode root)
        {
            if (root == null)
                return string.Empty;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            List<string> l = new List<string>();

            while(s.Count() > 0)
            {
                TreeNode t = s.Pop();
                //If current node is null, store the marker
                if (t == null)
                    l.Add("#");
                else
                {
                    l.Add("" +t.val);
                    s.Push(t.right);
                    s.Push(t.left);
                }
            }
            return String.Join(",", l);

        }

        private int t = 0;
        public TreeNode Deserialize(string data)
        {
            if (data == null)
                return null;
            string[] arr = data.Split(',');
            return Helper(arr);

        }

        private TreeNode Helper(string[] arr)
        {
            //Base condition
            if (arr[t].Equals('#'))
                return null;
            TreeNode root = new TreeNode(Convert.ToInt32(arr[t]));
            t++;
            root.left = Helper(arr);
            t++;
            root.right = Helper(arr);
            return root;
        }
    }

    public class SerializeAndDeserializeTest
    {
        public void TestSerializeDeseriaze()
        {
            TreeNode tree = new TreeNode(20);
            tree.left = new TreeNode(8);
            tree.right = new TreeNode(22);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(12);
            tree.right.left = new TreeNode(10);
            tree.right.right = new TreeNode(14);

            SerializeDeserializeABinaryTree s = new SerializeDeserializeABinaryTree();
            Console.WriteLine(s.SerializeBT(tree));
        }
    }
}
