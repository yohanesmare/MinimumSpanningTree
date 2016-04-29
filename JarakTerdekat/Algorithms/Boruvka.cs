using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarakTerdekat
{
    class Prim
    {
        public List<int> resultEdgeCollection;

        public List<Edge> edges;

        public int V;

        public double totalJarak;

        public Prim()
        {
            resultEdgeCollection = new List<int>();
            totalJarak = 0;
        }

        // Jumlah vertex dalam graf

        // Fungsi utilitas untuk menemukan titik dengan nilai kunci minimum, dari
        // Himpunan vertex yang belum termasuk dalam MST
        public int minKey(List<double> key, List<bool> mstSet)
        {
            // Inisialisasi nilai min
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

        // fungsi utilitas untuk mencetak MST yang dibangun disimpan dalam parent []
        public void printMST(List<int> parent, int n, List<List<double>> graph)
        {
            Console.WriteLine("Edge   Weight\n");
            for (int i = 1; i < V; i++)
            {
                Console.WriteLine(String.Format("{0} - {1}    {2} \n", parent[i], i, graph[i][parent[i]]));
                totalJarak += graph[i][parent[i]];
                addEdgeIndexToResult(parent[i], i);
            }
        }

        public void addEdgeIndexToResult(int src, int dest)
        {
            foreach (var edge in edges)
            {
                if (((edge.src == src) && (edge.dest == dest)) || ((edge.src == dest) && (edge.dest == src)))
                {
                    resultEdgeCollection.Add(edge.index);
                }
            }
        }

        // Fungsi untuk membangun dan MST cetak untuk grafik diwakili menggunakan 			    representasi
        // ketetangaan matrix
        public void primMST(List<List<double>> graph)
        {
            List<int> parent = new List<int>(); // Array untuk menyimpan MST yg terbentuk
            List<double> key = new List<double>();   // Nilai kunci dipakai untuk memilih 								edge bobot minimum cut
            List<bool> mstSet = new List<bool>();  // Untuk mempresentasikan set dari 								vertex yang belum termasuk dalam MST 						                  
            parent.Add(0);

            // Inisialisasi semua kunci sebagai INFINITE
            for (int i = 0; i < V; i++)
            {
                key.Add(0);
                mstSet.Add(false);

                key[i] = double.PositiveInfinity;
                mstSet[i] = false;
            }

            // Selalu sertakan vertex 1 pertama di MST.
            key[0] = 0;     // Buat kunci 0 sehingga titik ini dipilih sebagai vertex 					pertama
            parent[0] = -1; // Node pertama selalu menjadi akar dari MST

            // MST akan memiliki vertex V
            for (int count = 0; count < V - 1; count++)
            {
                // Pilih vertex kunci minimum dari himpunan vertex
                // belum termasuk dalam MST
                int u = minKey(key, mstSet);

                // Tambahkan vertex terpilih ke himpunan MST
                mstSet[u] = true;

                // Perbaharui nilai key dan index parent dari the vertex yang beredekatan 		     dari
                // vertex yang terpilih. Mempertimbangkan hanya vertex yang belum
                // termasuk dalam MST
                for (int v = 0; v < V; v++)
                {
                    parent.Add(0);
                    // graph[u][v] adalah non zero hanya untuk vertex yang berdekatan dari
                    // mstSet[v] adalah salah untuk vertex belum termasuk dalam MST
                    // Perbaharui kunci hanya jika graf[u][v] lebih kecil dari kunci[v]
                    if (((graph[u][v] > 0) ? true : false) && mstSet[v] == false && graph[u][v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u][v];
                    }
                }
            }
            // Cetak MST yang terbentuk
            printMST(parent, V, graph);
        }

        // program driver untuk menguji fungsi di atas
        public List<int> main(List<Edge> edges, List<List<double>> graphCollection, int V)
        {

            this.edges = edges;
            this.V = V;

            // Cetak solusi
            primMST(graphCollection);

            return resultEdgeCollection;
        }
    }
}
