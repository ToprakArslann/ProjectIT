﻿namespace projectit
{
    partial class TaskUserControl
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
            listView1 = new System.Windows.Forms.ListView();
            name = new System.Windows.Forms.ColumnHeader();
            processId = new System.Windows.Forms.ColumnHeader();
            status = new System.Windows.Forms.ColumnHeader();
            path = new System.Windows.Forms.ColumnHeader();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { name, processId, status, path });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.Location = new System.Drawing.Point(0, 3);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(507, 315);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 200;
            // 
            // processId
            // 
            processId.Text = "PID";
            processId.Width = 100;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 200;
            // 
            // path
            // 
            path.Text = "Path";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { killToolStripMenuItem, openFileLocationToolStripMenuItem, propertiesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            killToolStripMenuItem.Text = "Kill";
            killToolStripMenuItem.Click += killToolStripMenuItem_Click;
            // 
            // openFileLocationToolStripMenuItem
            // 
            openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            openFileLocationToolStripMenuItem.Text = "Open File Location";
            openFileLocationToolStripMenuItem.Click += openFileLocationToolStripMenuItem_Click;
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            propertiesToolStripMenuItem.Text = "Properties";
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(406, 321);
            button3.Margin = new System.Windows.Forms.Padding(6);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(95, 43);
            button3.TabIndex = 5;
            button3.Text = "Kill";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(299, 321);
            button1.Margin = new System.Windows.Forms.Padding(6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(95, 43);
            button1.TabIndex = 5;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(183, 320);
            button2.Margin = new System.Windows.Forms.Padding(6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(95, 43);
            button2.TabIndex = 5;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            textBox1.Location = new System.Drawing.Point(3, 320);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(180, 44);
            textBox1.TabIndex = 6;
            // 
            // TaskUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(listView1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "TaskUserControl";
            Size = new System.Drawing.Size(507, 367);
            Load += TaskUserControl_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader processId;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader path;
    }
}
