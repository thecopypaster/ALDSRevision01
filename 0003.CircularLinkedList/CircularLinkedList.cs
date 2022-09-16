using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003.CircularLinkedList
{
    internal class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList() 
        {
            last = null;
        }

        public void CreateLinkedList()
        {
            int n, x;
            Console.Write("Enter the number of nodes in the circular linked list: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the node value at position " + i + " : ");
                x = Convert.ToInt32(Console.ReadLine());
                InsertAtTheEnd(x);
            }

            DisplayList();
        }

        public void InsertAtTheEnd(int x)
        {
            Node temp = new Node(x);
            if(last == null)
            {
                last = temp;
                last.link = last;
                return;
            }

            temp.link = last.link;
            last.link = temp;
            last = temp;                  
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("The circular linked list is: ");

            if(last.link == last)
            {
                Console.Write(last.info + " ");
                return;
            }

            Node p = last;
            do
            {
                Console.Write(p.info + " ");
                p = p.link;
            }while(p != last);
        }

        public void InsertInTheBeginning(int x)
        {
            Node temp = new Node(x);
            if (last == null)
            {
                last = temp;
                last.link = last;
                return;
            }

            temp.link = last.link;
            last.link= temp;
        }

        public void InsertNodeAfterNode(int x, int k)
        {

            if (last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = new Node(x);
            //if afternode is 1ast node
            if(last.info == k)
            {
                temp.link = last.link;
                last.link = temp;
                last = temp;
                return;
            }
            
            Node p = last.link;
            while (p != last)
            {
                if (p.info == k)
                    break;
                p = p.link;
            }

            if(p == last)
            {
                Console.WriteLine("Node with value " + k + " is not found in the list");
            }
            else
            {
                temp.link = p.link;
                p.link = temp;
            }        
        }

        public void DeleteNodeWithValue(int k)
        {
            if (last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //delete only element
            if(last.info == k && last.link == last)
            {
                last = null;
                return;
            }

            //delete first element
            if(last.link.info == k)
            {
                last.link = last.link.link;
                return;
            }


            //delete last element
            Node p = last;
            while (p.link != last)
            {
                if (p.link.info == k)
                    break;
                p = p.link;
            }

            if(p.link == last)
            {
                if(last.info == k)
                {
                    p.link = last.link;
                    last = p;
                }
            }
            else
                p.link = p.link.link;

        }

        public void DeleteNodeAtTheEnd()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //delete only element
            if (last.link == last)
            {
                last = null;
                return;
            }

            Node p = last;
            while (p.link != last)
            {
                p = p.link;
            }

            p.link = last.link;
            last = p;
        }

        public void DeleteNodeAtTheBeginning()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //delete only element
            if (last.link == last)
            {
                last = null;
                return;
            }

            last.link = last.link.link; 
        }

        public void ConcatenateLists(CircularLinkedList list2)
        {
            Node temp = last.link;
            last.link = list2.last.link;
            list2.last.link = temp;
            last = list2.last;
        }
    }
}
