using System;
using System.Collections.Generic;

namespace Grandma
{
	public class Graph
	// Graph dengan adjacency matrix
	{
		private int n_max;									// Jumlah node maksimum
		private int n_node;									// Jumlah node yang ada
		private Node[] nodes;								// List of nodes
		private int[,] m;									// Adjacency matrix
		
		// Hanya untuk algoritma DFS
		private Stack<int> s;

		public Graph()
		{
			n_max = 50;
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

		public void dfs()
        {
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
	}
}
