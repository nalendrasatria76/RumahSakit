﻿namespace UAS_A22
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasienToolStripMenuItem,
            this.petugasToolStripMenuItem,
            this.dokterToolStripMenuItem,
            this.ruanganToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(141, 24);
            this.toolStripDropDownButton1.Text = "Data Rumah Sakit";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasienToolStripMenuItem.Text = "Pasien ";
            this.pasienToolStripMenuItem.Click += new System.EventHandler(this.pasienToolStripMenuItem_Click);
            // 
            // petugasToolStripMenuItem
            // 
            this.petugasToolStripMenuItem.Name = "petugasToolStripMenuItem";
            this.petugasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.petugasToolStripMenuItem.Text = "Petugas ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dokterToolStripMenuItem.Text = "Dokter";
            // 
            // ruanganToolStripMenuItem
            // 
            this.ruanganToolStripMenuItem.Name = "ruanganToolStripMenuItem";
            this.ruanganToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ruanganToolStripMenuItem.Text = "Ruangan";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Rumah Sakit";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petugasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruanganToolStripMenuItem;
    }
}