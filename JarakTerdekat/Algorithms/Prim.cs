using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class Boruvka
    {
        // Algoritma Boruvka untuk mencari Minimum Spanning
        // Tree dari graf terhubung, graf tidak berarah dan 
        // graf berbobot

        // struktur untuk merepresentasikan graf berbobot pada graf

        // struktur untuk merepresentasikan graf terhubung, tidak berarah
        // dan graf berbobot sebagai koleksi tepi.
        public List<int> resultPath;

        public double totalJarak;

        public Boruvka()
        {
            resultPath = new List<int>();
            totalJarak = 0;
        }
        class Graph
        {
            // V-> Jumalah vertex, E-> Jumlah edge
            public int V, E;

            // graph direpresentasikan sebagai array dari simpul.
            // Karna graf tidak berarah, edge
            // dari src ke dest juga edge dari dest
            // ke src. keduanya dihitung sebagai 1 edge disini.
            public List<Edge> edge = new List<Edge>();
        };

        // Sebuah struktur untuk merepresentasi sebuah subset untuk himpunan pencarian
        class subset
        {
            public int parent;
            public int rank;
        };

        // Fungsi utama dari algoritma Boruvka
        void boruvkaMST(Graph graph)
        {
            //  Ambil data dari graf yang ada
            int V = graph.V;
            int E = graph.E;
            List<Edge> edge = graph.edge;

            // Alokasi memori untuk membuat subset V.
            List<subset> subsets = new List<subset>();

            // Array untuk menyimpan indeks edge terkecil dari            
            // subset.  index tersimpan untuk pengindexan array 'edge[]'	
            List<int> cheapest = new List<int>();

            // Buat subset V dengan elemen sendiri
            cheapest.Add(-1);
            for (int v = 0; v < V; ++v)
            {
                subsets.Add(new subset());
                subsets[v].parent = v;
                subsets[v].rank = 0;
                cheapest.Add(-1);
            }

            // Inisialisasi ada V dengan pohon berbeda.
            // Akhirnya akan ada satu pohon yang menjadi MST
            int numTrees = V;
            double MSTweight = 0;

            // Tetap kombinasikan komponen (atau sets) hingga semua
            // komponen tidak tergabung menjadi MST sendiri.
            while (numTrees > 1)
            {
                // Melintasi semua edge dan perbaharui
                // yang terkecil dari semua komponen
                for (int i = 0; i < E; i++)
                {
                    // Cari komponen (atau sets) dari dua sudut
                    // dari edge
                    int set1 = find(subsets, edge[i].src);
                    int set2 = find(subsets, edge[i].dest);

                    // Jika dua sudut dari edge milik
                    // set yang sama, abaikan edge
                    if (set1 == set2)
                        continue;

                    // Lain, periksa jika edge lebih dekat ke edge terkecil 
                    // sebelumnya dari set1 dan set2
                    else
                    {
                        if (checkIfCurrentEdgeIsCloserToPreviousCheapest(set1, i, edge, cheapest))
                            cheapest[set1] = i;


                        if (checkIfCurrentEdgeIsCloserToPreviousCheapest(set2, i, edge, cheapest))
                            cheapest[set2] = i;
                    }
                }

                // Pertimbangkan edge terkecil dan tambahkan mereka
                // ke MST
                for (int i = 0; i < V; i++)
                {
                    // Periksa jika set terkecil ada 
                    if (cheapest[i] != -1)
                    {
                        int set1 = find(subsets, edge[cheapest[i]].src);
                        int set2 = find(subsets, edge[cheapest[i]].dest);

                        if (set1 == set2)
                            continue;
                        MSTweight += edge[cheapest[i]].weight;
                        resultPath.Add(edge[cheapest[i]].index);
                        // Lakukan penyatuan set 1 dan set 2, dab kurangi jumlah 
                        // dari pohon
                        Union(subsets, set1, set2);
                        numTrees--;
                    }
                }
                for (int i = 0; i < V; i++)
                {
                    cheapest[i] = -1;

                }

            }

            totalJarak = MSTweight;
            return;
        }

        private bool checkIfCurrentEdgeIsCloserToPreviousCheapest(int edgeIndex, int i, List<Edge> edge, List<int> cheapest)
        {
            var cond = false;

            if (cheapest[edgeIndex] == -1)
                cond = true;

            if (cheapest[edgeIndex] != -1)
            {
                if (edge[cheapest[edgeIndex]].weight > edge[i].weight)
                    cond = true;
            }
            return cond;
        }

        // Buat sebuah graf dengan vertex V dan edge E
        Graph createGraph(int V, int E)
        {
            Graph graph = new Graph();
            graph.V = V;
            graph.E = E;
            graph.edge = new List<Edge>();
            return graph;
        }

        // Sebuah fungsi utilitas untuk menemukan set elemen i
        // (menggunakan teknik kompresi jalan)
        int find(List<subset> subsets, int i)
        {
            // cari akar dan buat akar sebagai paremt dari i
            // (kompresi jalan)
            if (subsets[i].parent != i)
                subsets[i].parent =
                       find(subsets, subsets[i].parent);

            return subsets[i].parent;
        }

        // Sebuah fungsi yang melakukan penyatuan dua set dari x dan y
        // (menggunakan satuan dari peringkat)
        void Union(List<subset> subsets, int x, int y)
        {
            int xroot = find(subsets, x);
            int yroot = find(subsets, y);

            // Melampirkan peringkat pohon lebih kecil di bawah akar 
            // pohon peringkat tinggi (Penyatuan oleh Peringkat)
            if (subsets[xroot].rank < subsets[yroot].rank)
                subsets[xroot].parent = yroot;
            else if (subsets[xroot].rank > subsets[yroot].rank)
                subsets[yroot].parent = xroot;

            // Jika peringkat sama, maka buat satu sebagai akar dan
            // tambahkan peringkat oleh satu
            else
            {
                subsets[yroot].parent = xroot;
                subsets[xroot].rank++;
            }
        }

        public List<int> start(List<Edge> edges, int numOfVertices, int numOfEdges)
        {

            Graph graph = createGraph(numOfVertices, numOfEdges);

            graph.edge = edges;

            //Tampilkan edges;

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
