using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0035.BinaryTreeLinkedListSort
{
    internal class TreeNode
    {
        public TreeNode lchild;
        public TreeNode rchild;
        public int info;

        public TreeNode(int i)
        {
            info = i;
            lchild = null;
            rchild = null;
        }
    }
}
