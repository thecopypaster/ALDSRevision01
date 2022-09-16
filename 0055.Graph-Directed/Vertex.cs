using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0055.Graph_DirectedAdjacencyMatrix
{
    internal class Vertex
    {
        //We can have more data members that specify other properties of the vertex
        //However, for simplicity we have taken only one property called the name
        public string name;

        public Vertex(string name)
        {
            this.name = name;
        }
    }
}
