using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class Prim
    {
        // A C / C++ program for Prim's Minimum Spanning Tree (MST) algorithm. 
        // The program is for adjacency matrix representation of the graph

        public List<Edge> resultEdgeCollection;

        public Prim()
        {
            resultEdgeCollection = new List<Edge>();
        }

        // Number of vertices in the graph
        public int V = 5;

        // A utility function to find the vertex with minimum key value, from
        // the set of vertices not yet included in MST
        public int minKey(List<double>key, List<bool> mstSet)
        {
            // Initialize min value
            double min = double.PositiveInfinity;
            int min_index = 0;

            for (int v = 0; v < V; v++)
                if (mstSet[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print the constructed MST stored in parent[]
        public void printMST(List<int> parent, int n, List<List<double>> graph)
        {
            Console.WriteLine("Edge   Weight\n");
            for (int i = 1; i < V; i++)
            {
                Console.WriteLine(String.Format("{0} - {1}    {2} \n", parent[i], i, graph[i][parent[i]]));
                resultEdgeCollection.Add(new Edge());
                resultEdgeCollection[resultEdgeCollection.Count - 1].src = parent[i];
                resultEdgeCollection[resultEdgeCollection.Count - 1].dest = i;
            }
        }

        // Function to construct and print MST for a graph represented using adjacency
        // matrix representation
        public void primMST(List<List<double>> graph)
        {
            List<int> parent = new List<int>(); // Array to store constructed MST
            List<double> key = new List<double>();   // Key values used to pick minimum weight edge in cut
            List<bool> mstSet = new List<bool>();  // To represent set of vertices not yet included in MST

            parent.Add(0);

            // Initialize all keys as INFINITE
            for (int i = 0; i < V; i++)
            {
                key.Add(0);
                mstSet.Add(false);

                key[i] = double.PositiveInfinity;
                mstSet[i] = false;
            }

            // Always include first 1st vertex in MST.
            key[0] = 0;     // Make key 0 so that this vertex is picked as first vertex
            parent[0] = -1; // First node is always root of MST 

            // The MST will have V vertices
            for (int count = 0; count < V - 1; count++)
            {
                // Pick thd minimum key vertex from the set of vertices
                // not yet included in MST
                int u = minKey(key, mstSet);

                // Add the picked vertex to the MST Set
                mstSet[u] = true;

                // Update key value and parent index of the adjacent vertices of
                // the picked vertex. Consider only those vertices which are not yet
                // included in MST
                for (int v = 0; v < V; v++)
                {
                    parent.Add(0);
                    // graph[u][v] is non zero only for adjacent vertices of m
                    // mstSet[v] is false for vertices not yet included in MST
                    // Update the key only if graph[u][v] is smaller than key[v]
                    if (((graph[u][v] > 0) ? true : false) && mstSet[v] == false && graph[u][v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u][v];
                    }
                }
            }
            // print the constructed MST
            printMST(parent, V, graph);
        }

        // driver program to test above function
        public void main()
        {
            /* Let us create the following graph
                    2    3
                (0)--(1)--(2)
                |   / \   |
                6| 8/   \5 |7
                | /     \ |
                (3)-------(4)
                        9          */
            double[][] graph = new double[][]{
                new double[]{0, 2, 0, 6, 0},
                new double[]{2, 0, 3, 8, 5},
                new double[]{0, 3, 0, 0, 7},
                new double[]{6, 8, 0, 0, 9},
                new double[]{0, 5, 7, 9, 0},
            };
            List<List<double>> graphCollection = new List<List<double>>();
            
            foreach(var i in Enumerable.Range(0, graph.Count()))
            {
                graphCollection.Add(new List<double>());
                foreach (var j in Enumerable.Range(0, graph.Count()))
                {
                    graphCollection[i].Add(graph[i][j]);
                    Console.Write(graph[i][j] + " ");
                }
                Console.WriteLine("");
            }

            // Print the solution
            primMST(graphCollection);
        }
    }
}
