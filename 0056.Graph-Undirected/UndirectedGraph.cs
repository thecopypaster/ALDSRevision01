using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0056.Graph_UndirectedAdjacencyMatrix
{
    internal class UndirectedGraph
    {
        readonly int MAX_VERTICES = 30;
        int n;
        int e;
        bool[,] adj;
        Vertex[] vertexList;

        public UndirectedGraph()
        {
            adj = new bool[MAX_VERTICES, MAX_VERTICES];
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

        public int GetIndex(string vName)
        {
            for (int i = 0; i < n; i++)
            {
                if (vName.Equals(vertexList[i].name))
                    return i;
            }

            throw new InvalidOperationException("Vertex not found in graph");
        }

        public void InsertVertex(string vName)
        {
            vertexList[n++] = new Vertex(vName);
        }

        public void Display()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (adj[i, j])
                        Console.WriteLine("1 ");
                    else
                        Console.WriteLine("0 ");
                }
            }
        }

        public void InsertEdge(string vName1, string vName2)
        {
            int u = GetIndex(vName1);
            int v = GetIndex(vName2);

            if (adj[u, v])
                Console.WriteLine("Edge already present");
            else
            {
                adj[u, v] = true;
                adj[v, u] = true;
                e++;
            }
        }

        public bool EdgeExists(string vName1, string vName2)
        {
            return IsAdjacent(GetIndex(vName1), GetIndex(vName2));
        }

        private bool IsAdjacent(int u, int v)
        {
            return adj[u, v];
        }

        public void DeleteEdge(string vName1, string vName2)
        {
            int u = GetIndex(vName1);
            int v = GetIndex(vName2);
            if (!adj[u, v])
                Console.WriteLine("Edge does not exist in the graph");
            else
            {
                adj[u, v] = false;
                adj[v, u] = false;
                e--;
            }
        }

        public int Degree(string vName1)
        {
            int inDeg = 0;
            int u = GetIndex(vName1);
            for (int i = 0; i < n; i++)
            {
                if (adj[u, i])
                    inDeg++;
            }

            return inDeg;
        }
    }
}
