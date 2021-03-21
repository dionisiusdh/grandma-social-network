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
		private int[,] m;									// Adjacency matrix
		
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
			resetIsVisited(); // reset all isVisited to false
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

		public void bfs(Node n)
		{
			resetIsVisited(); // reset all isVisited to false
			int nodeIdx = findIdxNode(n.name);

			nodes[nodeIdx].isVisited = true;
			printNodeX(nodeIdx);
			q.Enqueue(nodeIdx);

			while (q.Count != 0)
            {
				nodeIdx = q.Dequeue();

				if (nodes[nodeIdx].isVisited == false)
                {
					nodes[nodeIdx].isVisited = true;

					int adjNodeIdx = 0;

					while (adjNodeIdx != -1)
                    {
						adjNodeIdx = getAdjNode(nodeIdx);
						q.Enqueue(adjNodeIdx);
                    }
                }
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
