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
            string [] all_nodes = G.getAllNodesInArray();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2 gambar = new Form2(G) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pGambar.Controls.Add(gambar);
            //gambar.Show();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // Friend explore
            string fromName = dropdownAcc.GetItemText(this.dropdownAcc.SelectedItem);
            string toName = dropdownFriend.GetItemText(this.dropdownFriend.SelectedItem);

            Node fromNode = new Node(fromName);
            Node toNode = new Node(toName);

            string fe_result = G.getResult_fr_bfs(G.fr_bfs(fromNode, toNode));

            test.Text = fromName;
            test2.Text = toName;
            labelFER.Text = fe_result;
            tbFER.Text = G.buatDebug;
        }
    }
}
