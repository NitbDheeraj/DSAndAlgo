using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.AVLTrees.Rotations
{
    /*
        Right Right Case 

          z                                y
         /  \                            /   \ 
        T1   y     Left Rotate(z)       z      x
            /  \   - - - - - - - ->    / \    / \
           T2   x                     T1  T2 T3  T4
               / \
             T3  T4
    */
    public class AVLTreeLeftRotation
    {
        public AVLTreeNode<int> LeftRotation(AVLTreeNode<int> Z)
        {
            AVLTreeNode<int> Y = Z.GetRight();
            AVLTreeNode<int> T2 = Y.GetLeft();

            //Perform rotation
            Y.SetLeft(Z);
            Z.SetRight(T2);

            //Update Heights
            Z.SetHeight(Math.Max(Z.GetLeft().GetHeight(), Z.GetRight().GetHeight()) + 1);
            Y.SetHeight(Math.Max(Y.GetLeft().GetHeight(), Y.GetRight().GetHeight()) + 1);

            return Y;
        }
    }
}
