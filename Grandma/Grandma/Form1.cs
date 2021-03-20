﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Browse file graph";
            openfile.InitialDirectory = @"D:\";
            openfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            openfile.FilterIndex = 2;
            openfile.RestoreDirectory = true;
            
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                label9.Text = System.IO.Path.GetFileName(openfile.FileName);
            }
        }
    }
}
