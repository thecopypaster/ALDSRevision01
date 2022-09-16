using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0047.SeperateChainingHashWithLinkedList
{
    internal class SingleLinkedList
    {
        public Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void InsertInTheBeginning(KeyValueRecord newRecord)
        {
            Node temp = new Node(newRecord);
            temp.link = start;
            start = temp;
        }

        public void DeleteFromLinkedList(int key)
        {
            if (start == null)
            {
                Console.WriteLine(" Key " + key + " not found in the list");
                return;
            }
            else if (start.record.getKey() == key)
            {
                start = null;
                return;
            }                

            Node p = start;
            while (p.link != null)
            {
                if (p.link.record.getKey() == key)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(" Key " + key + " not found in the list");
            else
                p.link = p.link.link;
        }

        public KeyValueRecord Search(int key)
        {
            Node p = start;
            while (p != null)
            {
                if (p.record.getKey() == key)
                    break;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("Key is not found in the list");
                return null;
            }
            else                
                return p.record;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("____");
                return;
            }

            p = start;
            while (p != null)
            {
                Console.Write(p.record.toString() + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
    }
}
