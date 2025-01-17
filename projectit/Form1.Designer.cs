namespace projectit
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
            panel2 = new System.Windows.Forms.Panel();
            labelaaaa = new System.Windows.Forms.Label();
            cmbSpecList = new System.Windows.Forms.ComboBox();
            btnGetSpecs = new System.Windows.Forms.Button();
            PnlSide = new System.Windows.Forms.Panel();
            PnlMain = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            PnlInfo = new System.Windows.Forms.Panel();
            BtnInfo = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            PnlSpecs = new System.Windows.Forms.Panel();
            BtnSpecs = new System.Windows.Forms.Button();
            PnlDisk = new System.Windows.Forms.Panel();
            BtnDisk = new System.Windows.Forms.Button();
            PnlTask = new System.Windows.Forms.Panel();
            BtnTask = new System.Windows.Forms.Button();
            PnlIp = new System.Windows.Forms.Panel();
            BtnIp = new System.Windows.Forms.Button();
            dragController1 = new DragController();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            PnlInfo.SuspendLayout();
            PnlSpecs.SuspendLayout();
            PnlDisk.SuspendLayout();
            PnlTask.SuspendLayout();
            PnlIp.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            panel2.Controls.Add(labelaaaa);
            panel2.Controls.Add(cmbSpecList);
            panel2.Controls.Add(btnGetSpecs);
            panel2.Controls.Add(PnlSide);
            panel2.Controls.Add(PnlMain);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.ForeColor = System.Drawing.SystemColors.Control;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(739, 485);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // labelaaaa
            // 
            labelaaaa.AutoSize = true;
            labelaaaa.Location = new System.Drawing.Point(643, 55);
            labelaaaa.Name = "labelaaaa";
            labelaaaa.Size = new System.Drawing.Size(70, 25);
            labelaaaa.TabIndex = 0;
            labelaaaa.Text = "label1";
            labelaaaa.Click += labelaaaa_Click;
            // 
            // cmbSpecList
            // 
            cmbSpecList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSpecList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbSpecList.FormattingEnabled = true;
            cmbSpecList.Items.AddRange(new object[] { "cpu", "gpu", "all" });
            cmbSpecList.Location = new System.Drawing.Point(217, 47);
            cmbSpecList.Name = "cmbSpecList";
            cmbSpecList.Size = new System.Drawing.Size(216, 33);
            cmbSpecList.TabIndex = 5;
            cmbSpecList.Visible = false;
            // 
            // btnGetSpecs
            // 
            btnGetSpecs.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            btnGetSpecs.FlatAppearance.BorderSize = 0;
            btnGetSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGetSpecs.Location = new System.Drawing.Point(439, 47);
            btnGetSpecs.Name = "btnGetSpecs";
            btnGetSpecs.Size = new System.Drawing.Size(98, 33);
            btnGetSpecs.TabIndex = 0;
            btnGetSpecs.Text = "Run";
            btnGetSpecs.UseVisualStyleBackColor = false;
            btnGetSpecs.Visible = false;
            btnGetSpecs.Click += btnGetSpecs_Click;
            // 
            // PnlSide
            // 
            PnlSide.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            PnlSide.Location = new System.Drawing.Point(553, 94);
            PnlSide.Name = "PnlSide";
            PnlSide.Size = new System.Drawing.Size(174, 367);
            PnlSide.TabIndex = 0;
            // 
            // PnlMain
            // 
            PnlMain.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            PnlMain.Location = new System.Drawing.Point(217, 94);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new System.Drawing.Size(320, 367);
            PnlMain.TabIndex = 4;
            PnlMain.Paint += PnlMain_Paint;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Location = new System.Drawing.Point(702, 0);
            button5.Name = "button5";
            button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            button5.Size = new System.Drawing.Size(37, 37);
            button5.TabIndex = 3;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label2.Location = new System.Drawing.Point(341, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 13);
            label2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(PnlInfo, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(PnlSpecs, 0, 0);
            tableLayoutPanel1.Controls.Add(PnlDisk, 0, 2);
            tableLayoutPanel1.Controls.Add(PnlTask, 0, 1);
            tableLayoutPanel1.Controls.Add(PnlIp, 0, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new System.Drawing.Size(200, 485);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // PnlInfo
            // 
            PnlInfo.Controls.Add(BtnInfo);
            PnlInfo.Location = new System.Drawing.Point(0, 320);
            PnlInfo.Margin = new System.Windows.Forms.Padding(0);
            PnlInfo.Name = "PnlInfo";
            PnlInfo.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            PnlInfo.Size = new System.Drawing.Size(200, 80);
            PnlInfo.TabIndex = 5;
            // 
            // BtnInfo
            // 
            BtnInfo.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            BtnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnInfo.FlatAppearance.BorderSize = 0;
            BtnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnInfo.ForeColor = System.Drawing.SystemColors.Control;
            BtnInfo.Location = new System.Drawing.Point(0, 0);
            BtnInfo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new System.Drawing.Size(194, 80);
            BtnInfo.TabIndex = 2;
            BtnInfo.Text = "Info";
            BtnInfo.UseVisualStyleBackColor = false;
            BtnInfo.Click += btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            label3.Location = new System.Drawing.Point(3, 472);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(194, 13);
            label3.TabIndex = 3;
            label3.Text = " Information Technology Tool";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlSpecs
            // 
            PnlSpecs.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            PnlSpecs.Controls.Add(BtnSpecs);
            PnlSpecs.Dock = System.Windows.Forms.DockStyle.Fill;
            PnlSpecs.Location = new System.Drawing.Point(0, 0);
            PnlSpecs.Margin = new System.Windows.Forms.Padding(0);
            PnlSpecs.Name = "PnlSpecs";
            PnlSpecs.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            PnlSpecs.Size = new System.Drawing.Size(200, 80);
            PnlSpecs.TabIndex = 4;
            // 
            // BtnSpecs
            // 
            BtnSpecs.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            BtnSpecs.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnSpecs.FlatAppearance.BorderSize = 0;
            BtnSpecs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            BtnSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSpecs.ForeColor = System.Drawing.SystemColors.Control;
            BtnSpecs.Location = new System.Drawing.Point(0, 0);
            BtnSpecs.Margin = new System.Windows.Forms.Padding(0);
            BtnSpecs.Name = "BtnSpecs";
            BtnSpecs.Size = new System.Drawing.Size(194, 80);
            BtnSpecs.TabIndex = 2;
            BtnSpecs.Text = "Specs";
            BtnSpecs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnSpecs.UseVisualStyleBackColor = false;
            BtnSpecs.Click += btn_Click;
            // 
            // PnlDisk
            // 
            PnlDisk.Controls.Add(BtnDisk);
            PnlDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            PnlDisk.Location = new System.Drawing.Point(0, 160);
            PnlDisk.Margin = new System.Windows.Forms.Padding(0);
            PnlDisk.Name = "PnlDisk";
            PnlDisk.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            PnlDisk.Size = new System.Drawing.Size(200, 80);
            PnlDisk.TabIndex = 6;
            // 
            // BtnDisk
            // 
            BtnDisk.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            BtnDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnDisk.FlatAppearance.BorderSize = 0;
            BtnDisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            BtnDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnDisk.ForeColor = System.Drawing.SystemColors.Control;
            BtnDisk.Location = new System.Drawing.Point(0, 0);
            BtnDisk.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            BtnDisk.Name = "BtnDisk";
            BtnDisk.Size = new System.Drawing.Size(194, 80);
            BtnDisk.TabIndex = 2;
            BtnDisk.Text = "Tweaks";
            BtnDisk.UseVisualStyleBackColor = false;
            BtnDisk.Click += btn_Click;
            // 
            // PnlTask
            // 
            PnlTask.Controls.Add(BtnTask);
            PnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            PnlTask.Location = new System.Drawing.Point(0, 80);
            PnlTask.Margin = new System.Windows.Forms.Padding(0);
            PnlTask.Name = "PnlTask";
            PnlTask.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            PnlTask.Size = new System.Drawing.Size(200, 80);
            PnlTask.TabIndex = 7;
            // 
            // BtnTask
            // 
            BtnTask.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            BtnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnTask.FlatAppearance.BorderSize = 0;
            BtnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            BtnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnTask.ForeColor = System.Drawing.SystemColors.Control;
            BtnTask.Location = new System.Drawing.Point(0, 0);
            BtnTask.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            BtnTask.Name = "BtnTask";
            BtnTask.Size = new System.Drawing.Size(194, 80);
            BtnTask.TabIndex = 2;
            BtnTask.Text = "Task Manager";
            BtnTask.UseVisualStyleBackColor = false;
            BtnTask.Click += btn_Click;
            // 
            // PnlIp
            // 
            PnlIp.Controls.Add(BtnIp);
            PnlIp.Location = new System.Drawing.Point(0, 240);
            PnlIp.Margin = new System.Windows.Forms.Padding(0);
            PnlIp.Name = "PnlIp";
            PnlIp.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            PnlIp.Size = new System.Drawing.Size(200, 80);
            PnlIp.TabIndex = 8;
            // 
            // BtnIp
            // 
            BtnIp.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            BtnIp.Dock = System.Windows.Forms.DockStyle.Fill;
            BtnIp.FlatAppearance.BorderSize = 0;
            BtnIp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            BtnIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnIp.ForeColor = System.Drawing.SystemColors.Control;
            BtnIp.Location = new System.Drawing.Point(0, 0);
            BtnIp.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            BtnIp.Name = "BtnIp";
            BtnIp.Size = new System.Drawing.Size(194, 80);
            BtnIp.TabIndex = 3;
            BtnIp.Text = "Ip Quary";
            BtnIp.UseVisualStyleBackColor = false;
            BtnIp.Click += btn_Click;
            // 
            // dragController1
            // 
            dragController1.SelectControl = panel2;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(739, 485);
            Controls.Add(panel2);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Form1";
            ShowIcon = false;
            Text = "w";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PnlInfo.ResumeLayout(false);
            PnlSpecs.ResumeLayout(false);
            PnlDisk.ResumeLayout(false);
            PnlTask.ResumeLayout(false);
            PnlIp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DragController dragController1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlSpecs;
        private System.Windows.Forms.Button BtnSpecs;
        private System.Windows.Forms.Panel PnlInfo;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Panel PnlDisk;
        private System.Windows.Forms.Button BtnDisk;
        private System.Windows.Forms.Panel PnlTask;
        private System.Windows.Forms.Button BtnTask;
        private System.Windows.Forms.Panel PnlSide;
        public System.Windows.Forms.ComboBox cmbSpecList;
        public System.Windows.Forms.Button btnGetSpecs;
        private System.Windows.Forms.Panel PnlIp;
        private System.Windows.Forms.Button BtnIp;
        internal System.Windows.Forms.Label labelaaaa;
    }
}

