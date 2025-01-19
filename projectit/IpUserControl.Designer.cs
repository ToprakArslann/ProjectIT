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
            txtIp1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            listView1 = new System.Windows.Forms.ListView();
            nameCol = new System.Windows.Forms.ColumnHeader();
            ipCol = new System.Windows.Forms.ColumnHeader();
            macCol = new System.Windows.Forms.ColumnHeader();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            panel1.Location = new System.Drawing.Point(1, 0);
            panel1.Margin = new System.Windows.Forms.Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(507, 367);
            panel1.TabIndex = 6;
            // 
            // listView1
            // 
            listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { nameCol, ipCol, macCol });
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
            nameCol.Text = "Name";
            nameCol.Width = 90;
            // 
            // ipCol
            // 
            ipCol.Text = "Ip";
            ipCol.Width = 150;
            // 
            // macCol
            // 
            macCol.Text = "Mac Address";
            macCol.Width = 254;
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
            // IpUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "IpUserControl";
            Size = new System.Drawing.Size(507, 367);
            Load += IpUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader ipCol;
        private System.Windows.Forms.ColumnHeader macCol;
    }
}
