namespace projectit
{
    partial class IpUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtIp1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            listView1 = new System.Windows.Forms.ListView();
            nameCol = new System.Windows.Forms.ColumnHeader();
            ipCol = new System.Windows.Forms.ColumnHeader();
            macCol = new System.Windows.Forms.ColumnHeader();
            status = new System.Windows.Forms.ColumnHeader();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            panel2 = new System.Windows.Forms.Panel();
            label12 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox7 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            textBox11 = new System.Windows.Forms.TextBox();
            textBox10 = new System.Windows.Forms.TextBox();
            textBox9 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox8 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            unknownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIp1
            // 
            txtIp1.Enabled = false;
            txtIp1.Location = new System.Drawing.Point(31, 31);
            txtIp1.Margin = new System.Windows.Forms.Padding(6);
            txtIp1.MaxLength = 15;
            txtIp1.Name = "txtIp1";
            txtIp1.Size = new System.Drawing.Size(210, 31);
            txtIp1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(351, 25);
            button1.Margin = new System.Windows.Forms.Padding(6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(92, 43);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtIp1);
            panel1.Location = new System.Drawing.Point(2, 0);
            panel1.Margin = new System.Windows.Forms.Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(507, 367);
            panel1.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { nameCol, ipCol, macCol, status });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView1.Location = new System.Drawing.Point(3, 104);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(498, 260);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            nameCol.DisplayIndex = 1;
            nameCol.Text = "Name";
            nameCol.Width = 90;
            // 
            // ipCol
            // 
            ipCol.DisplayIndex = 2;
            ipCol.Text = "Ip";
            ipCol.Width = 150;
            // 
            // macCol
            // 
            macCol.DisplayIndex = 3;
            macCol.Text = "Mac Address";
            macCol.Width = 254;
            // 
            // status
            // 
            status.DisplayIndex = 0;
            status.Text = "Status";
            status.Width = 100;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(456, 25);
            button2.Margin = new System.Windows.Forms.Padding(6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(45, 43);
            button2.TabIndex = 4;
            button2.Text = "⟳";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 25);
            label1.TabIndex = 7;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(3, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(498, 10);
            progressBar1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new System.Drawing.Point(250, 31);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(92, 31);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(506, 367);
            panel2.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(72, 28);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(92, 25);
            label12.TabIndex = 9;
            label12.Text = "Enter Ip:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(41, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 25);
            label3.TabIndex = 8;
            label3.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(43, 321);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 25);
            label7.TabIndex = 8;
            label7.Text = "Org";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(50, 267);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(40, 25);
            label6.TabIndex = 8;
            label6.Text = "Isp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(303, 264);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(89, 25);
            label10.TabIndex = 8;
            label10.Text = "Is Proxy";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(294, 212);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(98, 25);
            label9.TabIndex = 8;
            label9.Text = "Is Mobile";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(294, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(99, 25);
            label5.TabIndex = 8;
            label5.Text = "Currency";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(48, 212);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 25);
            label4.TabIndex = 8;
            label4.Text = "Zip";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(3, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Country";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(96, 155);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(139, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(96, 318);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new System.Drawing.Size(196, 31);
            textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(96, 264);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(196, 31);
            textBox6.TabIndex = 7;
            // 
            // textBox11
            // 
            textBox11.Location = new System.Drawing.Point(399, 318);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new System.Drawing.Size(90, 31);
            textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            textBox10.Location = new System.Drawing.Point(399, 264);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new System.Drawing.Size(90, 31);
            textBox10.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(399, 209);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new System.Drawing.Size(90, 31);
            textBox9.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(399, 155);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new System.Drawing.Size(90, 31);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(96, 209);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new System.Drawing.Size(90, 31);
            textBox4.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(350, 101);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new System.Drawing.Size(139, 31);
            textBox8.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(96, 101);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(139, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(168, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(174, 31);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(372, 19);
            button3.Margin = new System.Windows.Forms.Padding(6);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(92, 43);
            button3.TabIndex = 4;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(238, 104);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(114, 25);
            label8.TabIndex = 8;
            label8.Text = "Time Zone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(286, 321);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(107, 25);
            label11.TabIndex = 8;
            label11.Text = "Is Hosting";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { activeToolStripMenuItem, deadToolStripMenuItem, unknownToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // activeToolStripMenuItem
            // 
            activeToolStripMenuItem.Checked = true;
            activeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            activeToolStripMenuItem.Enabled = false;
            activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            activeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            activeToolStripMenuItem.Text = "Active";
            // 
            // deadToolStripMenuItem
            // 
            deadToolStripMenuItem.CheckOnClick = true;
            deadToolStripMenuItem.Name = "deadToolStripMenuItem";
            deadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            deadToolStripMenuItem.Text = "Dead";
            // 
            // unknownToolStripMenuItem
            // 
            unknownToolStripMenuItem.CheckOnClick = true;
            unknownToolStripMenuItem.Name = "unknownToolStripMenuItem";
            unknownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            unknownToolStripMenuItem.Text = "Unknown";
            // 
            // IpUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "IpUserControl";
            Size = new System.Drawing.Size(507, 367);
            Load += IpUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIp1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader ipCol;
        private System.Windows.Forms.ColumnHeader macCol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unknownToolStripMenuItem;
    }
}
