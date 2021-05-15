using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.AVLTrees.Rotations
{
    /*Left Right Case 

             z                               z                           x
            / \                            /   \                        /  \ 
           y   T4  Left Rotate (y)        x    T4  Right Rotate(z)    y      z
          / \      - - - - - - - - ->    /  \      - - - - - - - ->  / \    / \
        T1   x                          y    T3                    T1  T2 T3  T4
            / \                        / \
          T2   T3                    T1   T2
    */

    public class LeftRightRotations
    {
        public AVLTreeNode<int> LeftRightRotation(AVLTreeNode<int> Z)
        {
            AVLTreeRightRotation RightRotation = new AVLTreeRightRotation();
            AVLTreeLeftRotation LeftRotation = new AVLTreeLeftRotation();

            Z.SetLeft(RightRotation.RightRotation(Z.GetLeft()));
            return LeftRotation.LeftRotation(Z);
        }

    }
}
