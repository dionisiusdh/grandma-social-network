using System;
using System.Collections.Generic;

namespace Grandma
{
	public class Node
	{
		public string name;
		public bool isVisited;

		public Node(String _name)
		{
			name = _name;
			isVisited = false;
		}
	}
}