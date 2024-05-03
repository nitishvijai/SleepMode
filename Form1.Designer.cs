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
            this.aboutBtn.Location = new System.Drawing.Point(341, 351);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(428, 382);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.lstBoxInstalledApps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxOpenApps);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sleep Mode v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxOpenApps;
        private System.Windows.Forms.ListBox lstBoxInstalledApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutBtn;
    }
}

