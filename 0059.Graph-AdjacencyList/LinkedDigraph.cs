using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0059.Graph_DirectedAdjacencyList
{
    internal class LinkedDigraph
    {
        VertexNode start;
        int n; //number of vertices
        int e; //number of edges

        public int Vertices() { return n; }

        public int Edges() { return e; }

        public void InsertVertex(string vName)
        {
            //1.If start is null then new vertex is start
            //2.Iterate through last vertex and check if vName exists already
            //3.Insert new vertex at the end
            VertexNode temp = new VertexNode(vName);

            if(start == null)
                start = temp;
            else
            {
                VertexNode p = start;
                //loop ends before p reaches last vertex
                while (p.nextVertex != null)
                {
                    if (p.name.Equals(vName))
                    {
                        Console.WriteLine("Vertex already present in graph");
                        return;
                    }
                    p = p.nextVertex;
                }

                //P now points to the last vertex
                if (p.name.Equals(vName))
                {
                    Console.WriteLine("Vertex already present in graph");
                    return;
                }
                p.nextVertex = temp;
            }
            n++;
        }

        public void DeleteVertex(string vName)
        {
            //1.Delete vertex from edge list
            //2.Delete vertex from vertex list
            DeleteVertexFromEdgeList(vName);
            DeleteVertexFromVertexList(vName);
        }

        public void DeleteVertexFromEdgeList(string vName)
        {
            //1.Iterate through Vertex linked list
            //2.If a vertex first edge is null then there is no edge list
            //for this vertex, continue to next vertex
            //3.If vertex first edge points to delete vertex
            //point first edge to next edge to delete the edge
            //Reduce the number of edges
            //4.Iterate through edge nodes to see if 2nd or other edges point
            //to delete vertex. point them to their next edge
            //reduce the number of edges

            for (VertexNode p = start; p != null; p = p.nextVertex)
            {
                if (p.firstEdge == null)
                    continue;
                if (p.firstEdge.endVertex.name.Equals(vName))
                {
                    p.firstEdge = p.firstEdge.nextEdge;
                    e--;
                }
                else
                {
                    EdgeNode q = p.firstEdge;
                    while (q.nextEdge != null)
                    {
                        //Checks from 2nd edge to last edge including last edge
                        if (q.nextEdge.endVertex.name.Equals(vName))
                        {
                            q.nextEdge = q.nextEdge.nextEdge;
                            e--;
                            break;
                        }
                        q = q.nextEdge;
                    }
                }
            }
        }

        public void DeleteVertexFromVertexList(string vName)
        {
            //1.If start is null, return, since no vertices to delete
            //2.If start is delete vertex, reduce edge count
                //point start to next vertex and reduce vertex count
            //3.Iterate through vertices to find vertex before delete vertex
                //If vertex points to last vertex, then delete vertex is not found, so return.
                //If next vertex is delete vertex, reduce edge count
                //and point next vertex to next next vertex and reduce vertex count

            if(start == null)
            {
                Console.WriteLine("No vertices to be deleted");
                return;
            }

            if (start.name.Equals(vName))
            {
                for(EdgeNode q = start.firstEdge; q != null; q = q.nextEdge)
                    e--;
                start = start.nextVertex;
                n--;
            }
            else
            {
                VertexNode p = start;
                while(p.nextVertex != null)
                {
                    if (p.nextVertex.name.Equals(vName))
                        break;
                    p = p.nextVertex;
                }

                if(p.nextVertex == null)
                {
                    Console.WriteLine("Vertex not found");
                    return;
                }
                else
                {
                    for (EdgeNode q = p.nextVertex.firstEdge; q != null; q = q.nextEdge)
                        e--;
                    p.nextVertex = p.nextVertex.nextVertex;
                    n--;
                }
            }
        }

        private VertexNode FindVertex(string vName)
        {
            VertexNode p = start;
            while (p != null)
            {
                if (p.name.Equals(vName))
                   return p;
                p = p.nextVertex;
            }

            return null;
        }

        public void InsertEdge(string vName1, string vName2)
        {
            //1.Return message if new vertex names are same
            //2.Find vertices for both names, check for nulls and return if null
            //3.Create a new edge that points to vName2
            //4.If first edgee of vertex vName1 is null, set its first edge to the new edge you created
            //5.Iterate through vertex vName1 edges to reach last edge
                //If edge already presetn, throw message and return
                //Assign next edge of last edge to new edge if edge not present
            if(vName1.Equals(vName2))
            {
                Console.WriteLine("Invalid edge, start and end vertices are same");
                return;
            }

            VertexNode u = FindVertex(vName1);
            VertexNode v = FindVertex(vName2);

            if(u == null)
            {
                Console.WriteLine("Start vertex not present in the graph");
                return;
            }
            if(v == null)
            {
                Console.WriteLine("End vertex not present in the graph");
                return;
            }

            EdgeNode temp = new EdgeNode(v);
            if(u.firstEdge == null)
            {
                u.firstEdge = temp;
                e++;
            }
            else
            {
                EdgeNode p = u.firstEdge;
                while (p.nextEdge != null)
                {
                    if (p.endVertex.name.Equals(vName2))
                    {
                        Console.WriteLine("Edge already present");
                        return;
                    }
                    p = p.nextEdge;
                }

                if (p.endVertex.name.Equals(vName2))
                {
                    Console.WriteLine("Edge already present");
                    return;
                }

                p.nextEdge = temp;
                e++;
            }
        }

        public void DeleteEdge(string vName1, string vName2)
        {
            //1.Get the start vertex from the edge
            //2.If 
        }
    }
}
