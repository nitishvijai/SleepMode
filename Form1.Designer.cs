namespace SleepMode
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxOpenApps = new System.Windows.Forms.ListBox();
            this.lstBoxInstalledApps = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.btGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "All currently open windows:";
            // 
            // lstBoxOpenApps
            // 
            this.lstBoxOpenApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxOpenApps.FormattingEnabled = true;
            this.lstBoxOpenApps.Location = new System.Drawing.Point(15, 26);
            this.lstBoxOpenApps.Name = "lstBoxOpenApps";
            this.lstBoxOpenApps.Size = new System.Drawing.Size(401, 147);
            this.lstBoxOpenApps.TabIndex = 2;
            // 
            // lstBoxInstalledApps
            // 
            this.lstBoxInstalledApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxInstalledApps.FormattingEnabled = true;
            this.lstBoxInstalledApps.Location = new System.Drawing.Point(15, 198);
            this.lstBoxInstalledApps.Name = "lstBoxInstalledApps";
            this.lstBoxInstalledApps.Size = new System.Drawing.Size(401, 147);
            this.lstBoxInstalledApps.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "All installed system apps:";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aboutBtn.Location = new System.Drawing.Point(341, 363);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // btGroupBox
            // 
            this.btGroupBox.Controls.Add(this.label4);
            this.btGroupBox.Controls.Add(this.button1);
            this.btGroupBox.Controls.Add(this.checkBox1);
            this.btGroupBox.Controls.Add(this.label3);
            this.btGroupBox.Location = new System.Drawing.Point(15, 403);
            this.btGroupBox.Name = "btGroupBox";
            this.btGroupBox.Size = new System.Drawing.Size(401, 145);
            this.btGroupBox.TabIndex = 6;
            this.btGroupBox.TabStop = false;
            this.btGroupBox.Text = "Bedtime";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your bedtime is not set up yet. Click on Bedtime Settings below to get started!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(328, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Keep this computer awake tonight (overrides Bedtime Settings)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bedtime Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 15);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(428, 561);
            this.Controls.Add(this.btGroupBox);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.lstBoxInstalledApps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxOpenApps);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sleep Mode v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btGroupBox.ResumeLayout(false);
            this.btGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxOpenApps;
        private System.Windows.Forms.ListBox lstBoxInstalledApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.GroupBox btGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

