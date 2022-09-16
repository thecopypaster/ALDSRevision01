using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0046.OpenAddressHashWithLinearProbing
{
    internal class HashTable
    {
        private KeyValueRecord[] keyValues;
        private int m; //Hashtable or array size
        int n; //number of records
        private int v;

        public HashTable() : this(11) { }

        public HashTable(int tableSize)
        {
            m = tableSize;
            n = 0;
            keyValues = new KeyValueRecord[m];
        }

        int Hash(int key)
        {
            return key % m;
        }

        public void Insert(KeyValueRecord newRecord)
        {
            int key = newRecord.getKey();
            int h = Hash(key);

            int location = h;
            for (int i = 1; i < m; i++)
            {
                if (keyValues[location] == null || keyValues[location].getKey() == -1)
                {
                    keyValues[location] = newRecord;
                    n++;
                    return;
                }

                if (keyValues[location].getKey() == key)
                    throw new InvalidOperationException("Duplicate key found");

                location = (h + i) % m; //Linear probing
            }
        }

        public KeyValueRecord Search(int key)
        {
            int h = Hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (keyValues[location] == null)
                    return null;    //empty location
                if(keyValues[location].getKey() == key)
                    return keyValues[location]; //search successful
                location = (h + i) % m;
            }

            return null; //search unsuccessful
        }

        public KeyValueRecord Delete(int key)
        {
            int h = Hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (keyValues[location].getKey() == key)
                {
                    KeyValueRecord temp = keyValues[location];
                    keyValues[location].setKey(-1);
                    n--;
                    return temp;
                }                   
                location = (h + i) % m;
            }
            return null;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("[ " + i + " ]");
                if (keyValues[i] != null && keyValues[i].getKey() != -1)
                    Console.WriteLine(keyValues[i].toString() + "  ");
                else
                    Console.WriteLine("____");
            }
        }

        public void InsertWithRehash(KeyValueRecord newRecord)
        {
            if(n >= m / 2)
            {
                Rehash(NextPrimeNumber(2 * m));
                Console.WriteLine("New table size is: " + m);
            }
        }

        private void Rehash(int newSize)
        {
            //create new hash table with new size
            HashTable temp = new HashTable(newSize);

            //Insert all elements from old hash table to new
            for (int i = 0; i < m; i++)
            {
                if (keyValues[i] != null && keyValues[i].getKey() != -1)
                    temp.InsertWithRehash(keyValues[i]);
            }

            //make key values array temp key values array
            keyValues = temp.keyValues;
            m = newSize;
        }

        private int NextPrimeNumber(int number)
        {
            while (!IsPrime(number))
                number++;
            return number;
        }

        bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
