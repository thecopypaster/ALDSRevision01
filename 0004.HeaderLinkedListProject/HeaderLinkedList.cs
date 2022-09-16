using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0004.HeaderLinkedListProject
{
    internal class HeaderLinkedList
    {
        private Node head;
        
        public HeaderLinkedList()
        {
            head = new Node(0);
        }

        public void CreateList()
        {
            int n, x;
            Console.Write("Enter the number of nodes in the list: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the node value at position " + i + " : ");
                x = Convert.ToInt32(Console.ReadLine());
                InsertAtTheEnd(x);
            }

            DisplayList();
        }

        public void InsertAtTheEnd(int x)
        {
            Node p = head;
            while (p.link != null)
            {
                p = p.link;
            }

            p.link = new Node(x);
        }

        public void DisplayList()
        {
            Console.Write("The linked list is: ");

            Node p = head;
            while (p.link != null)
            {                
                p = p.link;
                Console.Write(p.info + " ");
            }
        }

        public void InsertNodeBeforeNode(int x, int k)
        {
            Node temp = new Node(x);
            Node p = head;

            while (p.link != null)
            {
                if (p.link.info == k)
                    break;
                p = p.link;                
            }

            if (p.link == null)
                Console.WriteLine("Node cannot be inserted.");
            else
            {
                temp.link = p.link;
                p.link = temp;
            }           
        }

        public void InsertNodeAtPosition(int x, int k)
        {
            Node temp = new Node(x);
            Node p = head;

            int position = 0;
            while (p.link != null)
            {
                position++;
                if (position == k)
                    break;
                p = p.link;                
            }

            if (p.link == null)
                Console.WriteLine("Node cannot be inserted.");
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteNodeWithValue(int k)
        {
            Node p = head;

            while (p.link != null)
            {
                if (p.link.info == k)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Node cannot be deleted. Not found or list empty.");
            else
            {
                p.link = p.link.link;
            }            
        }

        public void ReverseList()
        {
            Node prev, p, next;

            p = head.link; prev = null;
            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }

            head.link = prev;
        }
    }
}
