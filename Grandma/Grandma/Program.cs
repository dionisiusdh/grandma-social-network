using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());

            //Read File 
            Console.Write("Nama File : ");
            string input = Console.ReadLine();
            string filePath = @"../../test/"; //+ label9.Text;
            string[] lines = File.ReadAllLines(filePath);

            //Menghitung jumlah node
            ArrayList temp1 = new ArrayList();
            foreach (String line in lines)
            {
                string[] temp2 = line.Split(' ');
                if (temp2.Count() == 2)
                {
                    if (temp1.IndexOf(temp2[0]) == -1)
                    {
                        temp1.Add(temp2[0]);
                    }
                    if (temp1.IndexOf(temp2[1]) == -1)
                    {
                        temp1.Add(temp2[1]);
                    }
                }
            }
            int jumlah_node = temp1.Count;

            //Inisialisasi Graf
            Grandma.Graph G = new Grandma.Graph(jumlah_node);
            G.initNodes(lines);
            G.sortNode();
            G.initEdges(lines);

            //Mencetak hasil graf dan DFS
            Console.WriteLine("Nodes:");
            G.printAllNodes();
            Console.ReadLine();
        }
    }
}
