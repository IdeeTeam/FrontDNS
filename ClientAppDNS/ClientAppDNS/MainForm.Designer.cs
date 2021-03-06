﻿namespace ClientAppDNS
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lURL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lIP = new System.Windows.Forms.Label();
            this.lURLEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(9, 51);
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
            this.bStop.Location = new System.Drawing.Point(9, 80);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(154, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop Check In";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(9, 25);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(84, 20);
            this.tbURL.TabIndex = 2;
            // 
            // lURL
            // 
            this.lURL.AutoSize = true;
            this.lURL.Location = new System.Drawing.Point(9, 9);
            this.lURL.Name = "lURL";
            this.lURL.Size = new System.Drawing.Size(84, 13);
            this.lURL.TabIndex = 3;
            this.lURL.Text = "Enter URL here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your current IP address is:";
            this.label1.Visible = false;
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIP.Location = new System.Drawing.Point(14, 106);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(155, 20);
            this.lIP.TabIndex = 5;
            this.lIP.Text = "No information yet";
            this.lIP.Visible = false;
            // 
            // lURLEnd
            // 
            this.lURLEnd.AutoSize = true;
            this.lURLEnd.Location = new System.Drawing.Point(99, 28);
            this.lURLEnd.Name = "lURLEnd";
            this.lURLEnd.Size = new System.Drawing.Size(53, 13);
            this.lURLEnd.TabIndex = 6;
            this.lURLEnd.Text = ".idee.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 122);
            this.Controls.Add(this.lURLEnd);
            this.Controls.Add(this.lIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Check in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.Label lURLEnd;
    }
}