using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.DoubleLinkedList
{
    internal class Node
    {
        public int info;
        public Node prev;
        public Node next;

        public Node(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
