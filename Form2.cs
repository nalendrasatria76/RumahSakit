using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_A22
{
    public partial class Form2 : Form
    {
        private string stringConnection = "LAPTOP-94VJAKDC\\NALENDRASS;Initial Catalog=DB_RS;Persist Security Info=True;User ID=sa;Password=10Desember2002";
        private SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 nm = new Form1();
            nm.Show();
            this.Hide();
        }

        private void dataPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fo = new Form3();
            fo.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PetugasMenuItem_Clic(object sender, EventArgs e)
        {
            Form4 fo = new Form4();
            fo.Show();
            this.Hide();
        }

        private void DokterMenuItem_Clic(object sender, EventArgs e)
        {
            Form5 fo = new Form5();
            fo.Show();
            this.Hide();
        }

        private void RuanganMenuItem_Clic(object sender, EventArgs e)
        {
            Form6 fo = new Form6();
            fo.Show();
            this.Hide();
        }

        private void PembayaranMenuItem_Clic(object sender, EventArgs e)
        {
            Form7 fo = new Form7();
            fo.Show();
            this.Hide();
        }

        private void RawatMenuItem_Clic(object sender, EventArgs e)
        {
            Form8 fo = new Form8();
            fo.Show();
            this.Hide();
        }
    }
}
