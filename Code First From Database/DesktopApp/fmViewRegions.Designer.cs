﻿namespace DesktopApp
{
    partial class fmViewRegions
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboRegions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboRegions
            // 
            this.cboRegions.FormattingEnabled = true;
            this.cboRegions.Location = new System.Drawing.Point(65, 10);
            this.cboRegions.Name = "cboRegions";
            this.cboRegions.Size = new System.Drawing.Size(121, 21);
            this.cboRegions.TabIndex = 1;
            // 
            // fmViewRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cboRegions);
            this.Controls.Add(this.label1);
            this.Name = "fmViewRegions";
            this.Text = "View Regions";
            this.Load += new System.EventHandler(this.fmViewRegions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRegions;
    }
}