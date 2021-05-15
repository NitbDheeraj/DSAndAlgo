using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.AVLTrees.Rotations
{
    public class RightLeftRotations
    {
        public AVLTreeNode<int> RightLeftRotation(AVLTreeNode<int> Z)
        {
            AVLTreeRightRotation RightRotation = new AVLTreeRightRotation();
            AVLTreeLeftRotation LeftRotation = new AVLTreeLeftRotation();

            Z.SetRight(LeftRotation.LeftRotation(Z.GetRight()));
            return RightRotation.RightRotation(Z);
        }
    }
}
