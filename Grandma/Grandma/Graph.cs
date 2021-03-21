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

		// Stack algoritma dfs
		private Stack<int> s;
		// Queue algoritma bfs
		private Queue<int> q;

		public Graph(int max)
		{
			n_max = max;
			n_node = 0;
			s = new Stack<int>();
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
		public void dfs()
        {
			resetIsVisited();			// reset all isVisited to false
			nodes[0].isVisited = true;  // Mulai dari node 0
			printNodeX(0);
			s.Push(0);

			while (s.Count != 0)
            {
                int curr_node = getAdjNode(s.Peek());

				if (curr_node == -1)
                {
                    s.Pop();
                } else
                {
                    nodes[curr_node].isVisited = true;
                    printNodeX(curr_node);
                    s.Push(curr_node);
                }
            }
        }

		public Node[] bfs(Node n, Node end)
		{
			// declare resulting nodes array
			Node[] resNodes = new Node[n_node];
			
			// reset all isVisited to false
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
			
			// while loop selagi masih ada yang di queue DAN
			// current level masih di level ke 2 atau kurang
			while (q.Count != 0 && curr_level <= 2)
            {
				// get current node that is visited
				nodeIdx = q.Dequeue();

				// get all adjacent nodes
				for (int i = 0; i < nodes.Length; i++)
                {
					// apabila ada penghubung, di level 2, DAN adj node = ending node
					if (m[nodeIdx, i] == 1 && nodes[i].name == end.name && curr_level == 2)
                    {
						// adding node that is mutual friends to resulting array
						resNodes[array_insert] = nodes[nodeIdx];
						array_insert++;
                    }
					// apabila ada penghubung, dan belum dikunjungi
					if (m[nodeIdx, i] == 1 && (!nodes[i].isVisited))
                    {
						// adding adj node to queue and setting visited to true
						q.Enqueue(i);
						nodes[i].isVisited = true;
                    }
                }

				// next level
				curr_level++;
            }

			return resNodes;
		}
		
		public Queue<Node> fr_bfs(Node s, Node e) 
		{
			Node[] prev = new Node[n_node];
			prev = solve(s);
			buatDebug += "Uda berhasil FR BFS";
			return reconstructPath(s,e,prev);
		}

		public string getResult_fr_bfs(Queue<Node> Q)
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
			for (Node at=e; at!=null; at = prev[findIdxNode(at.name)]) 
			{ 
				path.Enqueue(at);
			}
			for (int i=0; i<n_node; i++)
			{ 
				Node n = path.Dequeue();
				path.Enqueue(n);
			}
			
			if (path.Peek() == s)
			{ 
				return path;
			}
            else 
			{ 
				path.Clear();
				return path;
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
