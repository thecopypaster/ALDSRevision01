using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0050.ExpressionTreeStackNode
{
    internal class Node
    {
        public char info;
        public Node lchild;
        public Node rchild;

        public Node(char c)
        {
            info = c;
            lchild = null;
            rchild = null;
        }
    }
}
