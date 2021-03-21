using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grandma
{
    public partial class Form2 : Form
    {
        public Form2(Graph G)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            // Create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            // Create the graph content 
            string[] all_nodes = G.getAllNodesInArray();
            int[,] m = G.getAdjMatrix();

            for (int i = 0; i < G.getNNode(); i++)
            {
                for (int j = i+1; j < G.getNNode(); j++)
                {
                    if (m[i,j] == 1)
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
            this.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(viewer);
            this.ResumeLayout();
        }
    }
}
