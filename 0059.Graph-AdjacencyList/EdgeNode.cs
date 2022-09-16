using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0059.Graph_DirectedAdjacencyList
{
    internal class EdgeNode
    {       
        public VertexNode endVertex;
        public EdgeNode nextEdge;

        public EdgeNode(VertexNode v)
        {
            this.endVertex = v;
        }
    }
}
