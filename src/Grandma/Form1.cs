using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grandma
{
    public partial class Form1 : Form
    {
        private Graph G;
        private Queue<Node> QFR; // Hasil friend explore
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(254, 254, 152); // this should be yellow-ish
        }

        private void showGraph()
        {
            // Mengubah konten panel gambar
            pGambar.Controls.Clear();

            // Create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            // Create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Create the graph content 
            string[] all_nodes = G.getAllNodesInArray();
            int[,] m = G.getAdjMatrix();

            for (int i = 0; i < G.getNNode(); i++)
            {
                for (int j = i + 1; j < G.getNNode(); j++)
                {
                    if (m[i, j] == 1)
                    {
                        graph.AddEdge(all_nodes[i], all_nodes[j]).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        graph.FindNode(all_nodes[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aquamarine;
                        graph.FindNode(all_nodes[j]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aquamarine;
                        graph.FindNode(all_nodes[i]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                        graph.FindNode(all_nodes[j]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                        graph.FindNode(all_nodes[i]).Label.FontSize = 20;
                        graph.FindNode(all_nodes[j]).Label.FontSize = 20;
                    }
                }
            }
            // Bind the graph to the viewer 
            viewer.Graph = graph;

            // Change all color to white
            viewer.OutsideAreaBrush = Brushes.White;

            // Associate the viewer with the form 
            pGambar.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pGambar.Controls.Add(viewer);
            pGambar.ResumeLayout();
        }

        private void drawFEPath()
        {
            // Mengubah konten panel gambar
            pGambar.Controls.Clear();

            // Menggambar path ke visualisasi layar
            // Create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            // Create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Create the graph content 
            string[] all_nodes = G.getAllNodesInArray();
            int[,] m = G.getAdjMatrix();

            for (int i = 0; i < G.getNNode(); i++)
            {
                for (int j = i + 1; j < G.getNNode(); j++)
                {
                    if (m[i, j] == 1)
                    {
                        // Warnai edge
                        // Inisiasi array of node name
                        int QSize = QFR.Count;
                        int counter = 0;
                        string[] nn = new string[QSize];        // node_names
                        string[] nn_couple = new string[QSize]; // couple node_names
                        int x;

                        foreach (Node n in this.QFR)
                        {
                            nn[counter] = n.name;
                            counter += 1;
                        }

                        // Get all posibble couple
                        for (x = 0; x < nn.Length - 1; x++)
                        {
                            nn_couple[x] = nn[x] + nn[x + 1];
                        }

                        if (isNodeNameInList(nn_couple, all_nodes[i], all_nodes[j]))
                        {
                            graph.AddEdge(all_nodes[i], all_nodes[j]);
                        } else if (isNodeNameInList(nn_couple, all_nodes[j], all_nodes[i]))
                        {
                            graph.AddEdge(all_nodes[j], all_nodes[i]);
                        }
                        else
                        {
                            graph.AddEdge(all_nodes[i], all_nodes[j]).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        }

                        //if (isNodeInQueue(N1, N2)) {
                        //    graph.AddEdge(all_nodes[i], all_nodes[j]);
                        //} else
                        //{
                        //    graph.AddEdge(all_nodes[i], all_nodes[j]).Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        //}

                        graph.FindNode(all_nodes[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aquamarine;
                        graph.FindNode(all_nodes[j]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Aquamarine;
                        graph.FindNode(all_nodes[i]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                        graph.FindNode(all_nodes[j]).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Box;
                        graph.FindNode(all_nodes[i]).Label.FontSize = 20;
                        graph.FindNode(all_nodes[j]).Label.FontSize = 20;
                    }
                }
            }

            // Path
            foreach (Node node in this.QFR)
            {
                graph.FindNode(node.name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightCoral;
            }

            // Bind the graph to the viewer 
            viewer.Graph = graph;

            // Change all color to white
            viewer.OutsideAreaBrush = Brushes.White;

            // Associate the viewer with the form 
            pGambar.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            pGambar.Controls.Add(viewer);
            pGambar.ResumeLayout();
        }

        private bool isNodeNameInList(string[] l, string n1, string n2)
        {
            var i = 0;

            for (i=0; i<l.Length; i++)
            {
                if (l[i] == n1+n2)
                {
                    return true;
                }
            }
            return false;
        }

        private void handleGraphFile()
        {
            // Ambil parent directory
            string relativePath;
            string lastPartOfCurrentDirectoryName = Path.GetFileName(Environment.CurrentDirectory);

            if (lastPartOfCurrentDirectoryName == "Debug")
            {
                relativePath = @"../../../../test/";
            } else
            {
                relativePath = @"../test/";
            }

            string filePath = relativePath + label9.Text;
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
            this.G = new Grandma.Graph(jumlah_node);
            G.initNodes(lines);
            G.sortNode();
            G.initEdges(lines);

            // Update dropdown items
            string[] all_nodes = G.getAllNodesInArray();
            dropdownAcc.Items.Clear();
            dropdownFriend.Items.Clear();

            foreach (string node in all_nodes)
            {
                dropdownAcc.Items.Add(node);
                dropdownFriend.Items.Add(node);
            }

            // Langsung visualisasi graph
            // Form2 gambar = new Form2(G) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // this.pGambar.Controls.Add(gambar);
            // gambar.Show();
            showGraph();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset view
            labelAlgorithm.Visible = false;
            labelResultTitle.Visible = false;
            tbResult.Visible = false;
            dropdownAcc.SelectedItem = null;
            dropdownFriend.SelectedItem = null;
            dropdownAcc.Items.Clear();
            dropdownFriend.Items.Clear();
            this.Refresh();

            // Get file name
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Browse file graph";
            openfile.InitialDirectory = @"D:\";
            openfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            openfile.FilterIndex = 2;
            openfile.RestoreDirectory = true;

            // Update label
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                label9.Text = System.IO.Path.GetFileName(openfile.FileName);
            }

            // Buat graph berdasarkan graph file
            handleGraphFile();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            //  Init fromNode and toNode
            string fromName = dropdownAcc.GetItemText(this.dropdownAcc.SelectedItem);
            string toName = dropdownFriend.GetItemText(this.dropdownFriend.SelectedItem);

            bool isDFS = rbDFS.Checked;

            if (isDFS)
            {
                labelAlgorithm.Text = "Algorithm: DFS";
                labelAlgorithm.Visible = true;
            }
            else
            {
                labelAlgorithm.Text = "Algorithm: BFS";
                labelAlgorithm.Visible = true;
            }

            Node fromNode = new Node(fromName);
            Node toNode = new Node(toName);

            labelResultTitle.Text = "Friend Recommendation for " + fromName + ": ";
            labelResultTitle.Visible = true;

            tbResult.Visible = true;

            // --- Friend explore ---
            string FEResult = " [ ";
            Queue<Node> QRes;

            if (isDFS)
            {
                Queue<Node> QRes2 = G.fe_dfs(fromNode, toNode);
                QRes = QRes2;
                this.QFR = QRes;
                FEResult += G.getResult_fe(QRes2);
            }
            else
            {
                Queue<Node> QRes2 = G.fe_bfs(fromNode, toNode);
                QRes = QRes2;
                this.QFR = QRes;
                FEResult += G.getResult_fe(QRes2);
            }

            int n_degree = QRes.Count - 2;
            if (n_degree == 0)
            {
                FEResult += " (" + n_degree + "-degree connection)";
            }
            else if (n_degree == 1)
            {
                FEResult += " (" + n_degree + "st-degree connection)";
            }
            else if (n_degree == 2)
            {
                FEResult += " (" + n_degree + "nd-degree connection)";
            }
            else if (n_degree == 3)
            {
                FEResult += " (" + n_degree + "rd-degree connection)";
            }
            else
            {
                FEResult += " (" + n_degree + "th-degree connection)";
            }

            FEResult += " ] ";

            if (n_degree < 0)
            {
                FEResult = " [ Tidak ada hubungan koneksi yang tersedia ] \r\nAnda harus memulai koneksi baru itu sendiri.";
            }

            // --- Friend Recommendation ---
            // Main Program untuk Friend Recommendation dengan BFS
            string FRResult = "";
            string CurrResult = "";
            int CurrResultLen = 0;

            foreach (Node node in G.fr(fromNode, toNode))
            {
                // bukan node awal/starting
                if (node.name != fromName)
                {
                    // panggil fungsi get result fr
                    // untuk mendapatkan string array mutual friends
                    CurrResult = G.getResult_fr(fromNode, node);
                    // kalkulasi banyaknya mutual friends dengan split string
                    CurrResultLen = CurrResult.Split(',').Length;

                    // apabila tidak kosong
                    if (CurrResult != "")
                    {
                        // template cetak nama node To
                        FRResult += "• " + node.name;

                        if (node.name == toName)
                        {
                            // tambahkan hasil friend explore ke baris FR
                            FRResult += FEResult;
                        }
                        // cetak mutual friends
                        FRResult += "\r\n" + CurrResultLen + " Mutual Friend(s)";
                        FRResult += "\r\n" + CurrResult;

                        FRResult += "\r\n";
                        FRResult += "\r\n";
                    }
                    else // kasus tidak ada mutual friends
                    {
                        if (node.name == toName)
                        {   
                            // template cetak nama node To
                            FRResult += "• " + node.name;
                            FRResult += FEResult;
                            FRResult += "\r\nTidak ada mutual friends";

                            FRResult += "\r\n";
                            FRResult += "\r\n";
                        }
                    }
                }
            }

            // enable property scrolling
            tbResult.ScrollBars = ScrollBars.Vertical;

            // ganti textbox dengan FRResult
            tbResult.Text = FRResult;

            // Visualize path
            drawFEPath();
        }
    }
}
