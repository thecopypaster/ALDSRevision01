using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0009.QueueCircularLinkedList
{
    internal class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void CreateList()
        {
            int n, x;
            Console.Write("Enter number of elements in the Linked List: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the element at " + i + " : ");
                x = Convert.ToInt32(Console.ReadLine());
                Enqueue(x);
            }
        }

        public void Enqueue(int x)
        {
            Node temp = new Node(x);
            if(last == null)
            {   
                last = temp;
                last.link = temp;
            }

            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public int Dequeue()
        {
            if (last == null)
                throw new InvalidOperationException("Queue underflow");

            int x = last.link.info;
            last.link = last.link.link;
            return x;
        }

        public int Peek()
        {
            if (last == null)
                throw new InvalidOperationException("Queue underflow");

            return last.link.info;
        }

        public bool IsEmpty()
        {
            return last == null;
        }

        public int Size()
        {            
            if (IsEmpty())
                return 0;
            int count = 0;
            Node p = last;
            do
            {
                count++;
                p = p.link;
            } while (p != last);

            return count;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Console.Write("The queue is: ");
            Node p = last.link;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            while (p != last.link);           

        }
    }
}
