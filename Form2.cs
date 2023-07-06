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

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
