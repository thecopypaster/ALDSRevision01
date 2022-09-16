using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0008.QueueLinkedList
{
    internal class DoubleEndedLinkedList
    {
        private Node front;
        private Node rear;

        public DoubleEndedLinkedList()
        {
            front = null;
            rear = null;
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

        public void Display()
        {
            if (front == null)
                Console.WriteLine("Queue is empty");

            Console.Write("The queue is: ");
            Node p = front;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
        }

        public int Size()
        {
            int count = 0;
            Node p = front;
            while (p != null)
            {
                count++;
                p = p.link;
            }

            return count;
        }

        public void Enqueue(int x)
        {
            Node temp = new Node(x);
            if (front == null)
                front = temp;
            else
                rear.link = temp;                       
            rear = temp;
        }

        public int Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty");

            int x = front.info;
            front = front.link;
            return x;
        }

        public int Peek()
        {
            if(front == null)
                throw new InvalidOperationException("Queue is empty");
            return front.info;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
