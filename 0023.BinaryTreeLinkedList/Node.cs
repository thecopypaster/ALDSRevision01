using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023.BinaryTreeLinkedList
{
    internal class Node
    {
        public Node lchild;
        public Node rchild;
        public char info;

        public Node(char c)
        {
            lchild = null;
            rchild = null;
            info = c;
        }
    }
}
