
namespace Grandma
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Grandma.Properties.Resources.grandma_800x600;
            this.pictureBox1.Location = new System.Drawing.Point(-47, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.textBox1.Location = new System.Drawing.Point(160, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Loading..";
            this.textBox1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Timer2);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.Timer3);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.Timer4);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.textBox2.Location = new System.Drawing.Point(160, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 38);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Loading..";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkKhaki;
            this.textBox3.Location = new System.Drawing.Point(160, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 38);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Loading..";
            this.textBox3.Visible = false;
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1500;
            this.timer5.Tick += new System.EventHandler(this.Timer2);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 2000;
            this.timer6.Tick += new System.EventHandler(this.Timer3);
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 2500;
            this.timer7.Tick += new System.EventHandler(this.Timer4);
            // 
            // timer8
            // 
            this.timer8.Enabled = true;
            this.timer8.Interval = 3000;
            this.timer8.Tick += new System.EventHandler(this.Timer2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(436, 324);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
    }
}