
namespace Grandma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pGambar = new System.Windows.Forms.Panel();
            this.dropdownAcc = new System.Windows.Forms.ComboBox();
            this.dropdownFriend = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFER = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.test2 = new System.Windows.Forms.Label();
            this.tbFER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFR = new System.Windows.Forms.TextBox();
            this.labelFR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(346, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(144, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Grandma";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Algorithm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Graph file:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(149, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(235, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "BFS";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose account      :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Explore friends with : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "...";
            // 
            // pGambar
            // 
            this.pGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGambar.Location = new System.Drawing.Point(39, 152);
            this.pGambar.Name = "pGambar";
            this.pGambar.Size = new System.Drawing.Size(772, 323);
            this.pGambar.TabIndex = 13;
            // 
            // dropdownAcc
            // 
            this.dropdownAcc.FormattingEnabled = true;
            this.dropdownAcc.Items.AddRange(new object[] {
            "Masukkan file"});
            this.dropdownAcc.Location = new System.Drawing.Point(188, 499);
            this.dropdownAcc.Name = "dropdownAcc";
            this.dropdownAcc.Size = new System.Drawing.Size(121, 24);
            this.dropdownAcc.TabIndex = 14;
            // 
            // dropdownFriend
            // 
            this.dropdownFriend.FormattingEnabled = true;
            this.dropdownFriend.Items.AddRange(new object[] {
            "Masukkan file"});
            this.dropdownFriend.Location = new System.Drawing.Point(188, 548);
            this.dropdownFriend.Name = "dropdownFriend";
            this.dropdownFriend.Size = new System.Drawing.Size(121, 24);
            this.dropdownFriend.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Friend recommendation for      :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\K. Stima\\Tugas\\Tubes 2\\new\\tubes-2-stima\\Grandma\\Grandma\\assets\\grandma-pic.pn" +
    "g";
            this.pictureBox1.Location = new System.Drawing.Point(718, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 88);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // labelFER
            // 
            this.labelFER.AutoSize = true;
            this.labelFER.Location = new System.Drawing.Point(40, 725);
            this.labelFER.Name = "labelFER";
            this.labelFER.Size = new System.Drawing.Size(20, 17);
            this.labelFER.TabIndex = 17;
            this.labelFER.Text = "...";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(43, 596);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 18;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(423, 499);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(46, 17);
            this.test.TabIndex = 19;
            this.test.Text = "label1";
            // 
            // test2
            // 
            this.test2.AutoSize = true;
            this.test2.Location = new System.Drawing.Point(518, 499);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(46, 17);
            this.test2.TabIndex = 20;
            this.test2.Text = "label1";
            // 
            // tbFER
            // 
            this.tbFER.Location = new System.Drawing.Point(426, 573);
            this.tbFER.Name = "tbFER";
            this.tbFER.Size = new System.Drawing.Size(367, 22);
            this.tbFER.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Friend Recomm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 636);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Friend Explore";
            // 
            // tbFR
            // 
            this.tbFR.Location = new System.Drawing.Point(426, 670);
            this.tbFR.Name = "tbFR";
            this.tbFR.Size = new System.Drawing.Size(367, 22);
            this.tbFR.TabIndex = 24;
            // 
            // labelFR
            // 
            this.labelFR.AutoSize = true;
            this.labelFR.Location = new System.Drawing.Point(40, 670);
            this.labelFR.Name = "labelFR";
            this.labelFR.Size = new System.Drawing.Size(20, 17);
            this.labelFR.TabIndex = 25;
            this.labelFR.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 670);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "FR:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 725);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "FE: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(861, 780);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelFR);
            this.Controls.Add(this.tbFR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFER);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelFER);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dropdownFriend);
            this.Controls.Add(this.dropdownAcc);
            this.Controls.Add(this.pGambar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grandma | Social Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pGambar;
        private System.Windows.Forms.ComboBox dropdownAcc;
        private System.Windows.Forms.ComboBox dropdownFriend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFER;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label test2;
        private System.Windows.Forms.TextBox tbFER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFR;
        private System.Windows.Forms.Label labelFR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

