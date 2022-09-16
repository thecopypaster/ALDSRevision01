using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0047.SeperateChainingHashWithLinkedList
{
    internal class KeyValueRecord
    {
        private int key;
        private string value;               

        public KeyValueRecord(int i, string name)
        {
            key = i;
            value = name;
        }

        public int getKey() { return key; }

        public void setKey(int i) { key = i; }

        public string toString()
        {
            return key + " : " + value + " ";
        }
    }
}
