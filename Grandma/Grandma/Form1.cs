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
        public Form1()
        {
            InitializeComponent();
        }

        private void handleGraphFile()
        {
            string input = Console.ReadLine();
            string filePath = @"../../test/" + label9.Text;
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
            Form2 gambar = new Form2(G) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pGambar.Controls.Add(gambar);
            gambar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                FEResult += G.getResult_fe(QRes2);
            }
            else
            {
                Queue<Node> QRes2 = G.fe_bfs(fromNode, toNode);
                QRes = QRes2;
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

            // --- Friend Recommendation ---
            // Main Program untuk Friend Recommendation dengan BFS
            string FRResult = "";
            string CurrResult = "";
            int CurrResultLen = 0;

            foreach (Node node in G.fr(fromNode))
            {
                // bukan node awal/starting
                if (node.name != fromName)
                {
                    // panggil fungsi get result fr
                    // untuk mendapatkan string array mutual friends
                    CurrResult = G.getResult_fr(fromNode, node);
                    // kalkulasi banyaknya mutual friends dengan split string
                    CurrResultLen = CurrResult.Split(',').Length;

                    // template cetak nama node To
                    FRResult += "• " + node.name;

                    // apabila tidak kosong
                    if (CurrResult != "")
                    { 
                        if (node.name == toName)
                        {
                            // tambahkan hasil friend explore ke baris FR
                            FRResult += FEResult;
                        }
                        // cetak mutual friends
                        FRResult += "\r\n" + CurrResultLen + " Mutual Friend(s)";
                        FRResult += "\r\n" + CurrResult;
                    }
                    else // kasus tidak ada mutual friends
                    {
                        if (node.name == toName)
                        {
                            FRResult += FEResult;
                        }
                        FRResult += "\r\nTidak ada mutual friends";
                    }
                    FRResult += "\r\n";
                }
                FRResult += "\r\n";
            }

            // enable property scrolling
            tbResult.ScrollBars = ScrollBars.Vertical;
            // ganti textbox dengan FRResult
            tbResult.Text = FRResult;
        }
    }
}
