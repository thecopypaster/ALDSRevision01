using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012.PriorityQueueLinkedList
{
    internal class PriorityQueueLL
    {
        private Node front;

        public PriorityQueueLL()
        {
            front = null;
        }

        public void Insert(int x, int elementPriority)
        {
            Node temp = new Node(x, elementPriority);
            if(IsEmpty() || elementPriority < front.priority)
            {
                temp.link = front;
                front = temp;
                return;
            }               

            Node p = front;
            while (p.link != null && p.link.priority <= elementPriority)
                p = p.link;

            temp.link = p.link;
            p.link = temp;
        }

        public int Delete()
        {
            int element;
            if (IsEmpty())
                throw new InvalidOperationException("Queue underflow");

            element = front.info;
            front = front.link;
            return element;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.WriteLine("The priority queue with priority is: ");
            Node p = front;
            while (p != null)
            {
                Console.WriteLine(p.info + " " + p.priority);
                p = p.link;
            }

            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
