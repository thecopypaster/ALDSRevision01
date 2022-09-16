using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0047.SeperateChainingHashWithLinkedList
{
    internal class Node
    {
        public Node link;
        public KeyValueRecord record;

        public Node(KeyValueRecord newRecord)
        {
            link = null;
            record = newRecord;
        }
    }
}
