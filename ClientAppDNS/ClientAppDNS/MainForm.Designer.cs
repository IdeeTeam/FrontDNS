namespace ClientAppDNS
{
    partial class MainForm
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
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 141);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(155, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start Check In";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(13, 171);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(154, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop Check In";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 224);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
    }
}