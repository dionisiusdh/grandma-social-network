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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(254, 254, 152); // this should be yellow-ish
            pictureBox1.Location = new Point((pictureBox1.Parent.ClientSize.Width / 2) - (pictureBox1.Width / 2),
                              (pictureBox1.Parent.ClientSize.Height / 2) - (pictureBox1.Height / 2) - (pictureBox1.Height/10));
            textBox1.BackColor = Color.FromArgb(254, 254, 152);
            textBox2.BackColor = Color.FromArgb(254, 254, 152);
            textBox3.BackColor = Color.FromArgb(254, 254, 152);

        }

        private void Timer1(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            Form1 actualForm = new Form1();
            actualForm.ShowDialog();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer2(object sender, EventArgs e)
        {
            timer2.Stop();
            textBox1.Visible = false;
            textBox3.Visible = true;
        }

        private void Timer3(object sender, EventArgs e)
        {
            timer3.Stop();
            textBox3.Visible = false;
            textBox2.Visible = true;
        }

        private void Timer4(object sender, EventArgs e)
        {
            timer4.Stop();
            textBox2.Visible = false;
            textBox1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
