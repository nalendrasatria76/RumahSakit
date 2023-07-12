namespace UAS_A22
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
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawatInapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRuanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRawatInapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
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
            this.ruanganToolStripMenuItem,
            this.pembayaranToolStripMenuItem,
            this.rawatInapToolStripMenuItem,
            this.dataPasienToolStripMenuItem,
            this.dataPetugasToolStripMenuItem,
            this.dataDokterToolStripMenuItem,
            this.dataRuanganToolStripMenuItem,
            this.dataPembayaranToolStripMenuItem,
            this.dataRawatInapToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(141, 28);
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
            this.petugasToolStripMenuItem.Click += new System.EventHandler(this.PetugasMenuItem_Clic);
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dokterToolStripMenuItem.Text = "Dokter";
            this.dokterToolStripMenuItem.Click += new System.EventHandler(this.DokterMenuItem_Clic);
            // 
            // ruanganToolStripMenuItem
            // 
            this.ruanganToolStripMenuItem.Name = "ruanganToolStripMenuItem";
            this.ruanganToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ruanganToolStripMenuItem.Text = "Ruangan";
            this.ruanganToolStripMenuItem.Click += new System.EventHandler(this.RuanganMenuItem_Clic);
            // 
            // pembayaranToolStripMenuItem
            // 
            this.pembayaranToolStripMenuItem.Name = "pembayaranToolStripMenuItem";
            this.pembayaranToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pembayaranToolStripMenuItem.Text = "Pembayaran";
            this.pembayaranToolStripMenuItem.Click += new System.EventHandler(this.PembayaranMenuItem_Clic);
            // 
            // rawatInapToolStripMenuItem
            // 
            this.rawatInapToolStripMenuItem.Name = "rawatInapToolStripMenuItem";
            this.rawatInapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rawatInapToolStripMenuItem.Text = "Rawat Inap";
            this.rawatInapToolStripMenuItem.Click += new System.EventHandler(this.RawatMenuItem_Clic);
            // 
            // dataPasienToolStripMenuItem
            // 
            this.dataPasienToolStripMenuItem.Name = "dataPasienToolStripMenuItem";
            this.dataPasienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPasienToolStripMenuItem.Text = "Data Pasien";
            this.dataPasienToolStripMenuItem.Click += new System.EventHandler(this.dataPasienToolStripMenuItem_Click_1);
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
            // dataPetugasToolStripMenuItem
            // 
            this.dataPetugasToolStripMenuItem.Name = "dataPetugasToolStripMenuItem";
            this.dataPetugasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPetugasToolStripMenuItem.Text = "Data Petugas";
            this.dataPetugasToolStripMenuItem.Click += new System.EventHandler(this.dataPetugasToolStripMenuItem_Click);
            // 
            // dataDokterToolStripMenuItem
            // 
            this.dataDokterToolStripMenuItem.Name = "dataDokterToolStripMenuItem";
            this.dataDokterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataDokterToolStripMenuItem.Text = "Data Dokter";
            this.dataDokterToolStripMenuItem.Click += new System.EventHandler(this.dataDokterToolStripMenuItem_Click);
            // 
            // dataRuanganToolStripMenuItem
            // 
            this.dataRuanganToolStripMenuItem.Name = "dataRuanganToolStripMenuItem";
            this.dataRuanganToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataRuanganToolStripMenuItem.Text = "Data Ruangan";
            this.dataRuanganToolStripMenuItem.Click += new System.EventHandler(this.dataRuanganToolStripMenuItem_Click);
            // 
            // dataPembayaranToolStripMenuItem
            // 
            this.dataPembayaranToolStripMenuItem.Name = "dataPembayaranToolStripMenuItem";
            this.dataPembayaranToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataPembayaranToolStripMenuItem.Text = "Data Pembayaran";
            this.dataPembayaranToolStripMenuItem.Click += new System.EventHandler(this.dataPembayaranToolStripMenuItem_Click);
            // 
            // dataRawatInapToolStripMenuItem
            // 
            this.dataRawatInapToolStripMenuItem.Name = "dataRawatInapToolStripMenuItem";
            this.dataRawatInapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataRawatInapToolStripMenuItem.Text = "Data Rawat Inap";
            this.dataRawatInapToolStripMenuItem.Click += new System.EventHandler(this.dataRawatInapToolStripMenuItem_Click);
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
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.ToolStripMenuItem pembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawatInapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRuanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRawatInapToolStripMenuItem;
    }
}