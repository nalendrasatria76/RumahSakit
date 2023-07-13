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
    public partial class Form14 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-94VJAKDC\\NALENDRASS;Initial Catalog=DB_RS;Persist Security Info=True;User ID=sa;Password=10Desember2002";
        private SqlConnection koneksi;
        private string namapasien, alamatpasien, idpasien, keluhan;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
        private void clearBinding()
        {
            this.txtIdRawatInap.DataBindings.Clear();
            this.txtIdPasien.DataBindings.Clear();
            this.txtIdPetugas.DataBindings.Clear();
        }

        private void FormDataRawatInap_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_rawatinap, id_pasien, id_petugas", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIdRawatInap.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_rawatinap", true));
            this.txtIdPasien.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pasien", true));
            this.txtIdPetugas.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_petugas", true));
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }

        public Form14()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.customersBindingSource = this.customersBindingSource;
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdRawatInap.Text = "";
            txtIdPasien.Text = "";
            txtIdPetugas.Text = "";
            txtIdRawatInap.Enabled = true;
            txtIdPasien.Enabled = true;
            txtIdPetugas.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void refreshform()
        {
            txtIdRawatInap.Enabled = false;
            txtIdPasien.Enabled = false;
            txtIdPetugas.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
            FormDataRawatInap_Load();
        }
    }
}
