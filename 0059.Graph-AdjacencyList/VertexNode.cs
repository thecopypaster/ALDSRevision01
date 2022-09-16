using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0059.Graph_DirectedAdjacencyList
{
    internal class VertexNode
    {
        public string name;
        //points to the next vertex in the linked list
        public VertexNode nextVertex;
        //points to the first edge in the linked list
        public EdgeNode firstEdge;

        public VertexNode(string name)
        {
            this.name = name;
        }
    }
}
