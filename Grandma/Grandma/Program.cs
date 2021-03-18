using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grandma
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Graph G = new Graph();
            G.addNode("John");
            G.addNode("Bro");
            G.addNode("Karen");
            G.addNode("Bob");

            G.addEdge(0, 1);
            G.addEdge(0, 3);
            G.addEdge(2, 1);
            G.addEdge(1, 3);

            Console.WriteLine("Nodes:");
            G.printAllNodes();

            Console.WriteLine("Visits: ");
            G.dfs();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
