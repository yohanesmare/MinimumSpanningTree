using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class Boruvka
    {
        // Boruvka's algorithm to find Minimum Spanning
        // Tree of a given connected, undirected and
        // weighted graph

        // a structure to represent a weighted edge in graph

        // a structure to represent a connected, undirected
        // and weighted graph as a collection of edges.
        public List<int> resultPath;

        public Boruvka()
        {
            resultPath = new List<int>();
        }
        class Graph
        {
            // V-> Number of vertices, E-> Number of edges
            public int V, E;

            // graph is represented as an array of edges.
            // Since the graph is undirected, the edge
            // from src to dest is also edge from dest
            // to src. Both are counted as 1 edge here.
            public List<Edge> edge = new List<Edge>();
        };

        // A structure to represent a subset for union-find
        class subset
        {
            public int parent;
            public int rank;
        };

            // The main function for MST using Boruvka's algorithm
        void boruvkaMST(Graph graph)
        {
            // Get data of given graph
            int V = graph.V;
            int E = graph.E;
            List<Edge> edge = graph.edge;

            // Allocate memory for creating V subsets.
            List<subset> subsets = new List<subset>();
 
            // An array to store index of the cheapest edge of
            // subset.  The stored index for indexing array 'edge[]'
            List<int> cheapest = new List<int>();
 
            // Create V subsets with single elements
            for (int v = 0; v<V; ++v)
            {
                subsets.Add(new subset());
                subsets[v].parent = v;
                subsets[v].rank = 0;
                cheapest.Add(0);
            }

            // Initially there are V different trees.
            // Finally there will be one tree that will be MST
            int numTrees = V;
            double MSTweight = 0;
 
            // Keep combining components (or sets) until all
            // compnentes are not combined into single MST.
            while (numTrees > 1)
            {
                // Traverse through all edges and update
                // cheapest of every component
                for (int i = 0; i<E; i++)
                {
                    // Find components (or sets) of two corners
                    // of current edge
                    int set1 = find(subsets, edge[i].src);
                    int set2 = find(subsets, edge[i].dest);
 
                    // If two corners of current edge belong to
                    // same set, ignore current edge
                    if (set1 == set2)
                        continue;
 
                    // Else check if current edge is closer to previous
                    // cheapest edges of set1 and set2
                    else
                    {
                        if (cheapest.Count >= set1 ||
                            edge[cheapest[set1]].weight > edge[i].weight)
                            cheapest[set1] = i;
 
                        if (cheapest.Count >= set1 ||
                            edge[cheapest[set2]].weight > edge[i].weight)
                            cheapest[set2] = i;
                    }
                }
 
                // Consider the above picked cheapest edges and add them
                // to MST
                for (int i = 0; i<V; i++)
                {
                    // Check if cheapest for current set exists
                    if (i < cheapest.Count)
                    {
                        int set1 = find(subsets, edge[cheapest[i]].src);
                        int set2 = find(subsets, edge[cheapest[i]].dest);
 
                        if (set1 == set2)
                            continue;
                        MSTweight += edge[cheapest[i]].weight;
                        Console.WriteLine("[" + edge[cheapest[i]].index + "] Edge " + edge[cheapest[i]].src + "-" + edge[cheapest[i]].dest + " included in MST");
                        resultPath.Add(edge[cheapest[i]].index);
                        // Do a union of set1 and set2 and decrease number
                        // of trees
                        Union(subsets, set1, set2);
                        numTrees--;
                    }
                }

                Console.WriteLine(numTrees);
            }

            Console.WriteLine("Weight of MST is " + MSTweight);
            return;
        }
 
        // Creates a graph with V vertices and E edges
        Graph createGraph(int V, int E)
        {
            Graph graph = new Graph();
            graph.V = V;
            graph.E = E;
            graph.edge = new List<Edge>();
            return graph;
        }

        // A utility function to find set of an element i
        // (uses path compression technique)
        int find(List<subset> subsets, int i)
        {
            // find root and make root as parent of i
            // (path compression)
            if (subsets[i].parent != i)
              subsets[i].parent =
                     find(subsets, subsets[i].parent);
 
            return subsets[i].parent;
        }
 
        // A function that does union of two sets of x and y
        // (uses union by rank)
        void Union(List<subset> subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);
 
            // Attach smaller rank tree under root of high
            // rank tree (Union by Rank)
            if (subsets[xroot].rank<subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;
 
            // If ranks are same, then make one as root and
            // increment its rank by one
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        public List<int> start(List<Edge> edges, int numOfVertices, int numOfEdges)
        {
            Console.WriteLine("Number of vertices: " + numOfVertices);
            Console.WriteLine("Number of edges: " + numOfEdges);

            Graph graph = createGraph(numOfVertices, numOfEdges);

            graph.edge = edges;

            displayEdges(edges);

            boruvkaMST(graph);

            return resultPath;
        }

        public void displayEdges(List<Edge> edges)
        {
            int i = 1;
            foreach (var edge in edges)
            {
                Console.WriteLine(i + ") edge " + edge.src + "-" + edge.dest + " : " + edge.weight);
                i++;
            }
        }
    }
}
