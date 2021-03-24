
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
            this.rbDFS = new System.Windows.Forms.RadioButton();
            this.rbBFS = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pGambar = new System.Windows.Forms.Panel();
            this.dropdownAcc = new System.Windows.Forms.ComboBox();
            this.dropdownFriend = new System.Windows.Forms.ComboBox();
            this.labelResultTitle = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(284, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(142, 38);
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
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Algorithm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Graph file:";
            // 
            // rbDFS
            // 
            this.rbDFS.AutoSize = true;
            this.rbDFS.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDFS.Location = new System.Drawing.Point(122, 132);
            this.rbDFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDFS.Name = "rbDFS";
            this.rbDFS.Size = new System.Drawing.Size(52, 22);
            this.rbDFS.TabIndex = 4;
            this.rbDFS.TabStop = true;
            this.rbDFS.Text = "DFS";
            this.rbDFS.UseVisualStyleBackColor = true;
            // 
            // rbBFS
            // 
            this.rbBFS.AutoSize = true;
            this.rbBFS.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBFS.Location = new System.Drawing.Point(211, 132);
            this.rbBFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBFS.Name = "rbBFS";
            this.rbBFS.Size = new System.Drawing.Size(51, 22);
            this.rbBFS.TabIndex = 5;
            this.rbBFS.TabStop = true;
            this.rbBFS.Text = "BFS";
            this.rbBFS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose account      :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Explore friends with : ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "...";
            // 
            // pGambar
            // 
            this.pGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGambar.Location = new System.Drawing.Point(40, 181);
            this.pGambar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGambar.Name = "pGambar";
            this.pGambar.Size = new System.Drawing.Size(621, 290);
            this.pGambar.TabIndex = 13;
            // 
            // dropdownAcc
            // 
            this.dropdownAcc.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownAcc.FormattingEnabled = true;
            this.dropdownAcc.Items.AddRange(new object[] {
            "Masukkan file"});
            this.dropdownAcc.Location = new System.Drawing.Point(186, 499);
            this.dropdownAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropdownAcc.Name = "dropdownAcc";
            this.dropdownAcc.Size = new System.Drawing.Size(121, 26);
            this.dropdownAcc.TabIndex = 14;
            // 
            // dropdownFriend
            // 
            this.dropdownFriend.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdownFriend.FormattingEnabled = true;
            this.dropdownFriend.Items.AddRange(new object[] {
            "Masukkan file"});
            this.dropdownFriend.Location = new System.Drawing.Point(540, 499);
            this.dropdownFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropdownFriend.Name = "dropdownFriend";
            this.dropdownFriend.Size = new System.Drawing.Size(121, 26);
            this.dropdownFriend.TabIndex = 15;
            // 
            // labelResultTitle
            // 
            this.labelResultTitle.AutoSize = true;
            this.labelResultTitle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultTitle.Location = new System.Drawing.Point(38, 546);
            this.labelResultTitle.Name = "labelResultTitle";
            this.labelResultTitle.Size = new System.Drawing.Size(216, 18);
            this.labelResultTitle.TabIndex = 8;
            this.labelResultTitle.Text = "Friend recommendation for      :";
            this.labelResultTitle.Visible = false;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(588, 543);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 26);
            this.buttonRun.TabIndex = 18;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.Location = new System.Drawing.Point(38, 570);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(78, 18);
            this.labelAlgorithm.TabIndex = 19;
            this.labelAlgorithm.Text = "Algorithm: ";
            this.labelAlgorithm.Visible = false;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(41, 608);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(620, 224);
            this.tbResult.TabIndex = 20;
            this.tbResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(715, 876);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.dropdownFriend);
            this.Controls.Add(this.dropdownAcc);
            this.Controls.Add(this.pGambar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResultTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbBFS);
            this.Controls.Add(this.rbDFS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grandma | Social Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDFS;
        private System.Windows.Forms.RadioButton rbBFS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pGambar;
        private System.Windows.Forms.ComboBox dropdownAcc;
        private System.Windows.Forms.ComboBox dropdownFriend;
        private System.Windows.Forms.Label labelResultTitle;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.TextBox tbResult;
    }
}

