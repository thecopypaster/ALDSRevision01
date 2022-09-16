using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012.PriorityQueueLinkedList
{
    internal class Node
    {
        public int info;
        public int priority;
        public Node link;

        public Node(int i, int pr)
        {
            info = i;
            priority = pr;
            link = null;
        }

    }
}
