using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.DoubleLinkedList
{
    internal class DoubleLinkedList
    {
        Node start;

        public DoubleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            int n, x;
            Console.WriteLine("Enter the number of nodes in list: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the element at position " + i);
                x = Convert.ToInt32(Console.ReadLine());
                InsertNodeAtEnd(x);
            }
            Console.WriteLine();
            DisplayList();
        }

        public void InsertNodeAtEnd(int x)
        {
            Node temp = new Node(x);
            if(start == null)
            {
                start = temp;
                return;
            }

            Node p = start;
            while (p.next != null)
            {
                p.next.prev = p;
                p = p.next;               
            }

            p.next = temp;
            temp.prev = p;
        }

        public void DisplayList()
        {
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.Write("The Double linked list is: ");

            Node p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
        }

        public void Count()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int count = 0;

            Node p = start;
            while (p != null)
            {
                count++;
                p = p.next;
            }

            Console.WriteLine("The number of nodes in the list is: " + count);
        }

        public void Search(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            int count = 0;
            Node p = start;
            while (p != null)
            {
                count++;
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine("Node with value " + x + " is not found in the list");
            else
                Console.WriteLine("Node with value " + x + " is found at position " + count + " in the list");
        }

        public void InsertNodeAtBeginning(int x)
        {
            Node temp = new Node(x);
            temp.next = start;
            start = temp;
        }

        public void InsertNodeAfterNode(int x, int k)
        {
            Node temp = new Node(x);
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            Node p = start;
            while (p != null)
            {
                if (p.info == k)
                    break;                
                p = p.next;
            }

            if (p == null) { 
                Console.WriteLine("Node with value " + k + "  is not found in the list");
            }
            else
            {
                temp.next = p.next;
                temp.prev = p;
                p.next = temp;
            }            
        }

        public void InsertNodeBeforeNode(int x, int k)
        {
            Node temp = new Node(x);
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            if(start.info == k)
            {
                temp.next = start;
                start = temp;
                return;
            }

            Node p = start;
            while (p.next != null)
            {
                if (p.next.info == k)
                    break;
                p = p.next;
            }

            if (p.next == null)
            {
                Console.WriteLine("Node with value " + k + "  is not found in the list");
            }
            else
            {
                temp.next = p.next;
                temp.prev = p;
                p.next = temp;
            }
        }

        public void DeleteNodeAtEnd() 
        {
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            if (start.next == null)
            {
                start = null;
                return;
            }
                

            Node p = start;
            while (p.next != null)
                p = p.next;

            p.prev.next = null;
            p.prev = null;
        }
        public void DeleteNodeAtBeginning()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            if (start.next == null)
                start = null;

            start.next.prev = null;
            start = start.next;
        }

        public void ReverseLinkedList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            if (start.next == null) {
                return;
            }

            Node p = start, temp;
            while (p.next != null)
            {
                temp = p.next;
                p.next = p.prev;
                p.prev = temp;
                p = p.prev;
            }

            p.next = p.prev;
            p.prev = null;
            start = p;
        }

        public void DeleteNodeWithValue(int x) 
        {
            if (start == null)
            {
                Console.WriteLine("List is empty. Node cannot be inserted");
                return;
            }

            if (start.next == null) {
                if (start.info == x)
                    start = null;
                else 
                    Console.WriteLine("Node with value " + x + " is not present in the list");
                return;
            }

            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine("Node with value " + x + " is not present in the list");                
            }
            else
            {
                p.prev.next = p.next;

                if(p.next != null)
                    p.next.prev = p.prev;
            }
        }
    }
}
