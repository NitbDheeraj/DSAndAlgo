using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.AVLTrees.Rotations
{
    /*      LeftLeftCase
             T1, T2, T3 and T4 are subtrees.
                 z                                      y 
                / \                                   /   \
               y   T4      Right Rotate (z)          x      z
              / \          - - - - - - - - ->      /  \    /  \ 
             x   T3                               T1  T2  T3  T4
            / \
          T1   T2
    */
    public class AVLTreeRightRotation
    {
        public AVLTreeNode<int> RightRotation(AVLTreeNode<int> Z)
        {
            AVLTreeNode<int> Y = Z.GetLeft();
            AVLTreeNode<int> T3 = Y.GetRight();

            //Perform Rotation
            Y.SetRight(Z);
            Z.SetLeft(T3);

            //Update Height
            Z.SetHeight(Math.Max(Z.GetLeft().GetHeight(), Z.GetRight().GetHeight()) + 1);
            Y.SetHeight(Math.Max(Y.GetLeft().GetHeight(), Y.GetRight().GetHeight()) + 1);

            return Y;
        }
    }
}
