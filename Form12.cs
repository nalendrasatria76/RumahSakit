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
    public partial class Form12 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-94VJAKDC\\NALENDRASS;Initial Catalog=DB_RS;Persist Security Info=True;User ID=sa;Password=10Desember2002";
        private SqlConnection koneksi;
        private string namapasien, alamatpasien, idpasien, keluhan;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        public Form12()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.customersBindingSource = this.customersBindingSource;
            refreshform();
        }

        private void clearBinding()
        {
            this.txtNamaRuang.DataBindings.Clear();
            this.txtIdRuang.DataBindings.Clear();
            this.txtNamaGedung.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void FormDataRuang_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.nama_ruang, m.alamat, m.id_ruang, m.nama_gedung  ", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNamaRuang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_ruang", true));
            this.txtIdRuang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_ruang", true));
            this.txtNamaGedung.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_gedung", true));
            koneksi.Close();
        }
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNamaRuang.Text = "";
            txtIdRuang.Text = "";
            txtNamaGedung.Text = "";
            txtNamaRuang.Enabled = true;
            txtIdRuang.Enabled = true;
            txtNamaGedung.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void refreshform()
        {
            txtNamaRuang.Enabled = false;
            txtIdRuang.Enabled = false;
            txtNamaGedung.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
            FormDataRuang_Load();
        }
    }
}
