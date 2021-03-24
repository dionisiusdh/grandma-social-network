using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Grandma
{
	public class Graph
	// Graph dengan adjacency matrix
	{
		private int n_max;									// Jumlah node maksimum
		private int n_node;									// Jumlah node yang ada
		private Node[] nodes;								// List of nodes
		private int[,] m;                                   // Adjacency matrix
		public string buatDebug;

		// Queue algoritma bfs
		private Queue<int> q;

		public Graph(int max)
		{
			n_max = max;
			n_node = 0;
			nodes = new Node[n_max];
			m = new int[n_max, n_max];
		}

		public void addNode(string name)
		{
			if (n_node != n_max) 
			{
				nodes[n_node] = new Node(name);
				n_node += 1;
			}
		}
		public void addEdge(int node_a_pos, int node_b_pos)
		{
			m[node_a_pos, node_b_pos] = 1;
			m[node_b_pos, node_a_pos] = 1;
		}

		public int getAdjNode(int node_pos)
		{
			// Mengambil node adjacent yang belum di kunjungi
			for (int i = 0; i < n_node; i++)
			{
				if (m[node_pos, i] == 1 && nodes[i].isVisited == false)
				{
					return i;
				}
			}
			return -1;
		}

		public void printNodeX(int X)
		{
			Console.WriteLine(nodes[X].name + " ");
		}

		public void printAllNodes() 
		{
			for (int i = 0; i < n_node; i++) 
			{
				Console.WriteLine(nodes[i].name);
			}
		}

		public string getAllNodesInString()
		{
			// Mereturn node yang ada dalam bentuk string
			string all_nodes = "";

			for (int i = 0; i < n_node; i++)
			{
				all_nodes += nodes[i].name;
			}
			return all_nodes;
		}

		public string[] getAllNodesInArray()
		{
			// Mereturn node yang ada dalam bentuk array / list
			string[] nodes_names = new string[n_max];

			for (int i = 0; i < n_node; i++)
			{
                nodes_names[i] = nodes[i].name;
			}

			return nodes_names;
		}

		public int[,] getAdjMatrix()
        {
			return m;
        }

		public int getNNode()
        {
			return n_node;
        }

		public int findIdxNode(string s)
		{
			int i = 0;
			bool found = false;
			while (i<n_node && !found)
			{
				if (nodes[i].name == s)
				{
					found = true;
				}
				else 
				{
					i += 1;
				}
			}
			if (!found)
			{
				return -1;
			}
			else 
			{
				return i;
			}
		}
		public void initNodes(string[] input)
		{
			foreach (String line in input)
			{
				string[] temp = line.Split(' ');
				if (temp.Count() == 2)
				{
					if (this.findIdxNode(temp[0]) == -1)
					{
						addNode(temp[0]);
					}
					if (this.findIdxNode(temp[1]) == -1)
					{
						addNode(temp[1]);
					}
				}
			}
		}

		public void sortNode()
		{
			Array.Sort(nodes, delegate (Node x, Node y) { return x.name.CompareTo(y.name); });
		}

		public void initEdges(string[] input) 
		{
			foreach (String line in input)
			{
				string[] temp = line.Split(' ');
				if (temp.Count() == 2)
				{
					addEdge(findIdxNode(temp[0]), findIdxNode(temp[1]));
				}
			}
		}

		public void initArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = -1;
			}
		}

		public int[] cari_mutual(Node n, Node end)
		{
			// declare resulting nodes array and queue
			Queue<int> q = new Queue<int>();
			int[] resNodeIdx = new int[n_node];

			// initialize array all elements to -1 & reset all isVisited to false
			initArray(resNodeIdx);
			resetIsVisited();

			// visit level 0
			int nodeIdx = findIdxNode(n.name);
			nodes[nodeIdx].isVisited = true;
			q.Enqueue(nodeIdx);

			// variabel integer 1 berguna untuk menandakan
			// current level dari traversal graf dari node awal
			int curr_level = 1;

			// variabel untuk indeks insert array
			int array_insert = 0;

			// list penyimpan node level 1
			List<int> levelOne = new List<int>();

			// while loop selagi masih ada yang di queue DAN
			// current level masih di level ke jumlah anakan
			// root node tambah satu atau kurang
			while (q.Count != 0 && curr_level <= levelOne.Count()+1)
			{
				// get current node that is visited
				nodeIdx = q.Dequeue();

				// get all adjacent nodes
				for (int i = 0; i < nodes.Length; i++)
				{
					// apabila ada penghubung, di level 2, DAN adj node = ending node
					if (m[nodeIdx, i] == 1 && nodes[i].name == end.name && levelOne.Contains(nodeIdx))
					{
						// adding node that is mutual friends to resulting array
						resNodeIdx[array_insert] = nodeIdx;
						array_insert++;
					}
					// apabila ada penghubung, dan belum dikunjungi
					if (m[nodeIdx, i] == 1 && (!nodes[i].isVisited))
					{
						// mencatat elemen yang ada pada level pertama
						if (curr_level == 1)
                        {
							levelOne.Add(i);
                        }
						// adding adj node to queue and setting visited to true
						q.Enqueue(i);
						nodes[i].isVisited = true;
					}
				}

				// next level
				curr_level++;
			}
			return resNodeIdx;
		}

		public Node[] fr(Node s, Node end)
		{
			// init initial neighbor list variable to store
			// index of initial neigbors
			var initialNeighborIdx = new List<int>();

			// for loop to add initial neigbors to list
			Queue<Node> initialNeighborNode = getNeighbour(s);
			while (initialNeighborNode.Count > 0)
            {
				initialNeighborIdx.Add(findIdxNode(initialNeighborNode.Dequeue().name));
            }

			// buat List of tuple yang tiap tuplenya
			// terdiri dari <int indexTo, int countMutual>
			var allNodeMutual = new List<Tuple<int, int>>();
			foreach (Node node in nodes)
            {
				// tambahkan index node serta banyaknya mutual friend dari s ke node
				if (!initialNeighborIdx.Contains(findIdxNode(node.name)))
				{
					allNodeMutual.Add(Tuple.Create(findIdxNode(node.name), cari_mutual(s, node).Count(a => a != -1)));
                }
            }

			// tambahkan toNode karena tetap akan dicari mutual friendsnya
			if (!allNodeMutual.Contains(Tuple.Create(findIdxNode(end.name), cari_mutual(s, end).Count(a => a != -1)))) 
			{
				allNodeMutual.Add(Tuple.Create(findIdxNode(end.name), cari_mutual(s, end).Count(a => a != -1)));
			}

			// Mensortir array berdasarkan int countMutual pada bagian tuple
			int n = allNodeMutual.Count;

			// gerak boundary unsorted array
			for (int i = 0; i < n - 1; i++)
			{
				// cari elemen maksimum dalam array unsorted
				int max_idx = i;
				for (int j = i + 1; j < n; j++)
                {
					if (allNodeMutual[j].Item2 > allNodeMutual[max_idx].Item2)
                    {
						max_idx = j;
                    }
                }

				// lakukan swap elemen
				Tuple<int, int> temp = allNodeMutual[max_idx];
				allNodeMutual[max_idx] = allNodeMutual[i];
				allNodeMutual[i] = temp;
            }

			// init array of nodes dengan ukuran sesuai dengan allNodeMutual
			Node[] hasil = new Node[allNodeMutual.Count];

			for (int i = 0; i < n; i++)
            {
				// masukan nodes dengan indeks yang sudah terurut ke dalam hasil
				hasil[i] = nodes[allNodeMutual[i].Item1];
            }

			return hasil;
		}

		public string getResult_fr(Node s, Node N)
		{
			// Init empty string
			string res = "";

			// init array of int mutual untuk semua mutual friends
			int[] mutual = cari_mutual(new Node(s.name), new Node(N.name));

			// while loop untuk memasukan semua mutual
			// friends ke dalam string hasil
			int j = 0;
			while (j < mutual.Count(n => n != -1)) 
			{
				res += nodes[mutual[j]].name;
				if (j < mutual.Count(n => n != -1) - 1)
				{
					res += ",";
				} 
				j++;
			}

			return res;
		}
		
		public string getResult_fe(Queue<Node> Q)
        {
			string res = "";
			int i = 0;

			foreach (var elem in Q)
			{
				res += elem.name;
				
				if (i != Q.Count - 1)
                {
					res += " -> ";
				}
				i++;
			}

			return res;
        }

		public Queue<Node> fe_dfs(Node s, Node e)
		{
			bool found = false;
			resetIsVisited();								// reset all isVisited to false
			nodes[findIdxNode(s.name)].isVisited = true;	// Mulai dari node start
			Stack<Node> temp = new Stack<Node>();			// Stack hasil berisi node-node
			temp.Push(s);                                   // Push element pertama stack
			Queue<Node> hasil = new Queue<Node>();

			//Lakukan operasi sampai node end sudah ditemukan atau semua node sudah dikunjungi
			while ((temp.Count != 0) && !found)
			{
				//curr_node diisi dengan simpul anak dari top stack yang belum dikunjungi
				int curr_node = getAdjNode(findIdxNode(temp.Peek().name));

				if (curr_node == -1) //Kalau tidak ada simpul anak dari curr_node yang lom dikunjungi maka backtrack
				{
					temp.Pop();
				}
				else
				{
					if (nodes[curr_node].name == e.name) //Kalau curr_node adalah simpul end maka hentikan proses
					{
						found = true;
						temp.Push(nodes[curr_node]);
					}
					else //Kalau curr_node bukan simpul end maka lakukan operasi yang sama ke simpul curr_node
					{
						nodes[curr_node].isVisited = true;
						temp.Push(nodes[curr_node]);
					}
				}
			}

			//Memasukkan isi dari stack ke dalam queue
			foreach (Node n in temp.Reverse())
			{
				hasil.Enqueue(n);
			}

			return hasil;
		}

		public Queue<Node> fe_bfs(Node s, Node e) 
		{
			Node[] prev = new Node[n_node];
			prev = solve(s);
			return reconstructPath(s,e,prev);
		}

		public Queue<Node> getNeighbour (Node e)
		{ 
			Queue<Node> neighbor = new Queue<Node>();
			for (int i =0; i<n_node; i++) 
			{ 
				if (m[findIdxNode(e.name),i] == 1)
                { 
					neighbor.Enqueue(nodes[i]);
				}
			}
			return neighbor;
		}

		public Node[] solve(Node s) 
		{ 
			//Inisialisasi
			Queue<Node> q = new Queue<Node>();
			q.Enqueue(s);
			resetIsVisited();
			nodes[findIdxNode(s.name)].isVisited = true;
			Node[] prev = new Node[n_node];

			//Looping buat cari parent node dari masing-masing array
			while (q.Count != 0)
            { 
				Node n = q.Dequeue();
				Queue<Node> neighbours = this.getNeighbour(n);
				foreach (Node next in neighbours) 
				{ 
					if (next.isVisited == false)
                    { 
						q.Enqueue(next);
						nodes[findIdxNode(next.name)].isVisited = true;
						prev[findIdxNode(next.name)] = n;
					}
				}
			}
			return prev;
		}

		public Queue<Node> reconstructPath(Node s, Node e, Node[] prev) 
		{ 
			Queue<Node> path = new Queue<Node>();
			//Cari hasil dengan menulusuri simpul dari e sampai simpul s
			for (Node at=e; at!=null; at = prev[findIdxNode(at.name)]) 
			{ 
				path.Enqueue(at);
			}
			Queue<Node> hasil = new Queue<Node>();
			foreach (Node n in path.Reverse()) //Hasil yang ada dibalik
			{ 
				hasil.Enqueue(n);
			}
			
			if (hasil.Peek() == s) //Kalau berhasil mendapatkan jalur atau hasil dimulai dari simpul s
			{ 
				return hasil;
			}
            else //Kalau tidak maka kembalikan queue kosong
			{ 
				hasil.Clear();
				return hasil;
			}
		}

		public void resetIsVisited()
        {
			foreach (Node n in nodes)
            {
				n.isVisited = false;
            }
        }
	}
}
