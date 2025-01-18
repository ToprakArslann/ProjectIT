namespace projectit
{
    partial class LegacyForm
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
            controlBtn = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            dragController1 = new DragController();
            networksBtn = new System.Windows.Forms.Button();
            powerBtn = new System.Windows.Forms.Button();
            regionBtn = new System.Windows.Forms.Button();
            sysBtn = new System.Windows.Forms.Button();
            printerBtn = new System.Windows.Forms.Button();
            soundBtn = new System.Windows.Forms.Button();
            userBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // controlBtn
            // 
            controlBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            controlBtn.FlatAppearance.BorderSize = 0;
            controlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            controlBtn.ForeColor = System.Drawing.Color.White;
            controlBtn.Location = new System.Drawing.Point(12, 37);
            controlBtn.Name = "controlBtn";
            controlBtn.Size = new System.Drawing.Size(192, 48);
            controlBtn.TabIndex = 0;
            controlBtn.Tag = "";
            controlBtn.Text = "Control Panel";
            controlBtn.UseVisualStyleBackColor = false;
            controlBtn.Click += Btn_Click;
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseButton.ForeColor = System.Drawing.Color.White;
            CloseButton.Location = new System.Drawing.Point(378, -1);
            CloseButton.Name = "CloseButton";
            CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CloseButton.Size = new System.Drawing.Size(37, 37);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // dragController1
            // 
            dragController1.SelectControl = this;
            // 
            // networksBtn
            // 
            networksBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            networksBtn.FlatAppearance.BorderSize = 0;
            networksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            networksBtn.ForeColor = System.Drawing.Color.White;
            networksBtn.Location = new System.Drawing.Point(210, 37);
            networksBtn.Name = "networksBtn";
            networksBtn.Size = new System.Drawing.Size(192, 48);
            networksBtn.TabIndex = 0;
            networksBtn.Tag = "";
            networksBtn.Text = "Networks";
            networksBtn.UseVisualStyleBackColor = false;
            networksBtn.Click += Btn_Click;
            // 
            // powerBtn
            // 
            powerBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            powerBtn.FlatAppearance.BorderSize = 0;
            powerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            powerBtn.ForeColor = System.Drawing.Color.White;
            powerBtn.Location = new System.Drawing.Point(12, 91);
            powerBtn.Name = "powerBtn";
            powerBtn.Size = new System.Drawing.Size(192, 48);
            powerBtn.TabIndex = 0;
            powerBtn.Tag = "";
            powerBtn.Text = "Power Panel";
            powerBtn.UseVisualStyleBackColor = false;
            powerBtn.Click += Btn_Click;
            // 
            // regionBtn
            // 
            regionBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            regionBtn.FlatAppearance.BorderSize = 0;
            regionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            regionBtn.ForeColor = System.Drawing.Color.White;
            regionBtn.Location = new System.Drawing.Point(12, 145);
            regionBtn.Name = "regionBtn";
            regionBtn.Size = new System.Drawing.Size(192, 48);
            regionBtn.TabIndex = 0;
            regionBtn.Tag = "";
            regionBtn.Text = "Region";
            regionBtn.UseVisualStyleBackColor = false;
            regionBtn.Click += Btn_Click;
            // 
            // sysBtn
            // 
            sysBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            sysBtn.FlatAppearance.BorderSize = 0;
            sysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sysBtn.ForeColor = System.Drawing.Color.White;
            sysBtn.Location = new System.Drawing.Point(12, 199);
            sysBtn.Name = "sysBtn";
            sysBtn.Size = new System.Drawing.Size(192, 48);
            sysBtn.TabIndex = 0;
            sysBtn.Tag = "";
            sysBtn.Text = "Sys Properties";
            sysBtn.UseVisualStyleBackColor = false;
            sysBtn.Click += Btn_Click;
            // 
            // printerBtn
            // 
            printerBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            printerBtn.FlatAppearance.BorderSize = 0;
            printerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            printerBtn.ForeColor = System.Drawing.Color.White;
            printerBtn.Location = new System.Drawing.Point(210, 91);
            printerBtn.Name = "printerBtn";
            printerBtn.Size = new System.Drawing.Size(192, 48);
            printerBtn.TabIndex = 0;
            printerBtn.Tag = "";
            printerBtn.Text = "Printer Panel";
            printerBtn.UseVisualStyleBackColor = false;
            printerBtn.Click += Btn_Click;
            // 
            // soundBtn
            // 
            soundBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            soundBtn.FlatAppearance.BorderSize = 0;
            soundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            soundBtn.ForeColor = System.Drawing.Color.White;
            soundBtn.Location = new System.Drawing.Point(210, 145);
            soundBtn.Name = "soundBtn";
            soundBtn.Size = new System.Drawing.Size(192, 48);
            soundBtn.TabIndex = 0;
            soundBtn.Tag = "";
            soundBtn.Text = "Sound Settings";
            soundBtn.UseVisualStyleBackColor = false;
            soundBtn.Click += Btn_Click;
            // 
            // userBtn
            // 
            userBtn.BackColor = System.Drawing.Color.FromArgb(52, 52, 52);
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            userBtn.ForeColor = System.Drawing.Color.White;
            userBtn.Location = new System.Drawing.Point(210, 197);
            userBtn.Name = "userBtn";
            userBtn.Size = new System.Drawing.Size(192, 48);
            userBtn.TabIndex = 0;
            userBtn.Tag = "";
            userBtn.Text = "User Accounts";
            userBtn.UseVisualStyleBackColor = false;
            userBtn.Click += Btn_Click;
            // 
            // LegacyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            ClientSize = new System.Drawing.Size(414, 257);
            Controls.Add(networksBtn);
            Controls.Add(userBtn);
            Controls.Add(soundBtn);
            Controls.Add(printerBtn);
            Controls.Add(sysBtn);
            Controls.Add(regionBtn);
            Controls.Add(powerBtn);
            Controls.Add(controlBtn);
            Controls.Add(CloseButton);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "LegacyForm";
            Text = "LegacyForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button controlBtn;
        private System.Windows.Forms.Button CloseButton;
        private DragController dragController1;
        private System.Windows.Forms.Button networksBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.Button printerBtn;
        private System.Windows.Forms.Button sysBtn;
        private System.Windows.Forms.Button regionBtn;
        private System.Windows.Forms.Button powerBtn;
    }
}