using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0047.SeperateChainingHashWithLinkedList
{
    internal class HashTable
    {
        private SingleLinkedList[] array;
        private int m;
        int n;

        public HashTable(int tableSize)
        {
            m = tableSize;
            array = new SingleLinkedList[m];
            n = 0;
        }

        public int Hash(int key)
        {
            return key % m;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("[" + i + "]");
                if (array[i] != null)
                    array[i].DisplayList();
                else
                    Console.Write("____");
            }
        }

        public KeyValueRecord Search(int key)
        {
            int h = Hash(key);
            if (array[h] != null)
                return array[h].Search(key);
            return null;              
        }

        public void Insert(KeyValueRecord newRecord)
        {
            int key = newRecord.getKey();
            int h = Hash(key);

            if (array[h] == null)
                array[h] = new SingleLinkedList();
            array[h].InsertInTheBeginning(newRecord);
            n++;
        }

        public void Delete(int key)
        {
            int h = Hash(key);
            if (array[h] != null)
            {
                array[h].DeleteFromLinkedList(key);
                n--;
            }
            else
                Console.WriteLine("key " + key + " is not present in the list");
        }
    }
}
