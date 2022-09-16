using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    public class BottomView
    {
        public int[] BottomViewOfBT(Node root)
        {
            Dictionary<int, int[]> map = new Dictionary<int, int[]>();

            BottomViewOfBTUtil(root, map, 0, 0);

            List<int> res = new List<int>();
            foreach (var item in map)
                res.Add(item.Value[1]);

            return res.ToArray();
        }

        private void BottomViewOfBTUtil(Node root, Dictionary<int, int[]> map, int hd, int vd)
        {
            if (root == null)
                return;

            if (map.ContainsKey(hd))
                map[hd] = new int[2] { vd, root.data };
            else
                map.Add(hd, new int[2] { vd, root.data });

            BottomViewOfBTUtil(root.left, map, hd - 1, vd + 1);
            BottomViewOfBTUtil(root.right, map, hd + 1, vd + 1);
        }
    }
}
