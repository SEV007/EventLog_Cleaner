namespace EventLogCleaner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.opt3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmdOutput = new System.Windows.Forms.TextBox();
            this.opt5 = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.Button();
            this.opt33 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.opt33);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.cmdOutput);
            this.panel1.Controls.Add(this.opt5);
            this.panel1.Controls.Add(this.opt1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(208, 213);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.opt3);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Location = new System.Drawing.Point(2, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 26);
            this.panel2.TabIndex = 9;
            // 
            // opt3
            // 
            this.opt3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opt3.Enabled = false;
            this.opt3.Location = new System.Drawing.Point(0, 3);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(135, 23);
            this.opt3.TabIndex = 2;
            this.opt3.Text = "Set CPU Limit";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(141, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(2, 186);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(204, 23);
            this.progressBar2.Step = 5;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(2, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // cmdOutput
            // 
            this.cmdOutput.AcceptsReturn = true;
            this.cmdOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOutput.Location = new System.Drawing.Point(2, 110);
            this.cmdOutput.Multiline = true;
            this.cmdOutput.Name = "cmdOutput";
            this.cmdOutput.ReadOnly = true;
            this.cmdOutput.Size = new System.Drawing.Size(204, 41);
            this.cmdOutput.TabIndex = 5;
            this.cmdOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opt5
            // 
            this.opt5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opt5.Location = new System.Drawing.Point(2, 81);
            this.opt5.Name = "opt5";
            this.opt5.Size = new System.Drawing.Size(204, 23);
            this.opt5.TabIndex = 4;
            this.opt5.Text = "Exit";
            this.opt5.UseVisualStyleBackColor = true;
            this.opt5.Click += new System.EventHandler(this.opt5_Click);
            // 
            // opt1
            // 
            this.opt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opt1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opt1.Location = new System.Drawing.Point(2, 2);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(204, 23);
            this.opt1.TabIndex = 0;
            this.opt1.Text = "Clean logs";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.Click += new System.EventHandler(this.opt1_Click);
            // 
            // opt33
            // 
            this.opt33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opt33.Location = new System.Drawing.Point(2, 54);
            this.opt33.Name = "opt33";
            this.opt33.Size = new System.Drawing.Size(204, 26);
            this.opt33.TabIndex = 10;
            this.opt33.Text = "Clean Disk";
            this.opt33.UseVisualStyleBackColor = true;
            this.opt33.Click += new System.EventHandler(this.opt33_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(208, 213);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Event Log Cleaner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button opt5;
        private System.Windows.Forms.Button opt3;
        private System.Windows.Forms.Button opt1;
        private System.Windows.Forms.TextBox cmdOutput;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button opt33;
    }
}

