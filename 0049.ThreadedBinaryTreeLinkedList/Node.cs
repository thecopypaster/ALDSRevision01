using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0049.ThreadedBinaryTreeLinkedList
{
    internal class Node
    {
        public Node left;
        public Node right;
        public bool leftThread;
        public bool rightThread;
        public int info;

        public Node(int i)
        {
            left = null;
            right = null;
            leftThread = true;
            rightThread = true;
            info = i;
        }
    }
}
