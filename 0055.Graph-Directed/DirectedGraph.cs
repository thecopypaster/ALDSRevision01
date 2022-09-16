using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0055.Graph_DirectedAdjacencyMatrix
{
    internal class DirectedGraph
    {
        //If the graph has a condition for number of vertices, it can go here
        public readonly int MAX_VERTICES = 30;

        int n;  //number of vertices in the graph
        int e;  //number of edges in the graph

        //2-D boolean array that represents the adjacency matrix of the graph        
        bool[,] adj;

        //array stores vertices of the graph
        Vertex[] vertexList;

        public DirectedGraph()
        {
            //Iitialize adj matrix size to max vertices
            adj = new bool[MAX_VERTICES, MAX_VERTICES];
            //Initialize vertex[] size to max vertices
            vertexList = new Vertex[MAX_VERTICES];
        }

        public int Vertices()
        {
            return n;
        }

        public int Edges()
        {
            return e;
        }

        public void InsertVertex(string vName)
        {
            vertexList[n++] = new Vertex(vName);
        }

        public void Display()
        {
            //PRINT 2-D array
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adj[i, j])
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }

        private int GetIndex(string vName)
        {
            //Iterate through vertices to match name
            for (int i = 0; i < n; i++)
            {
                if (vName.Equals(vertexList[i].name))
                    return i;
            }

            throw new System.InvalidOperationException("Invalid Vertex");
        }

        public void InsertEdge(string vName1, string vName2)
        {
            //1.Get indexes of vName1 & vName2
            //2.check if index are same & throw error
            //3.check if edge already exists and show message
            //4.Insert edge in adj matrix for indexes retrieved
            //5.Increment number of edges

            int u = GetIndex(vName1);
            int v = GetIndex(vName2);

            if (u == v)
                throw new InvalidOperationException("Not a valid edge");
            else if (adj[u, v])
                Console.WriteLine("Edge already present");
            else
            {
                adj[u, v] = true;
                e++;
            }
        }

        public bool EdgeExists(string vName1, string vName2)
        {
            //If indexes of vName1 & vName2 are adjacent(val = 1)
            //in adj matrix, edge exists            
            return IsAdjacent(GetIndex(vName1), GetIndex(vName2));
        }

        private bool IsAdjacent(int u, int v)
        {
            return adj[u, v];
        }

        public void DeleteEdge(string vName1, string vName2)
        {
            //1.Get indexes of vName1 & vName2           
            //3.check if edge doesnt exist and show message
            //4.Remove edge if present
            //5.Decrement number of edges

            int u = GetIndex(vName1);
            int v = GetIndex(vName2);

            if (!IsAdjacent(u, v))
                Console.WriteLine("Edge not present in the graph");
            else
            {
                adj[u, v] = false;
                e--;
            }
        }

        public int OutDegree(string vName)
        {
            int outDeg = 0;
            int u = GetIndex(vName);
            for (int i = 0; i < n; i++)
            {
                if (adj[u, i])
                    outDeg++;
            }

            return outDeg;
        }

        public int InDegree(string vName)
        {
            int inDeg = 0;
            int v = GetIndex(vName);

            for (int i = 0; i < n; i++)
            {
                if (adj[i, v])
                    inDeg++;
            }

            return inDeg;
        }
    }
}
