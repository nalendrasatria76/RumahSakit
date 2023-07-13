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
    public partial class Form13 : Form
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }

        public Form13()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.customersBindingSource = this.customersBindingSource;
            refreshform();
        }

        private void clearBinding()
        {
            this.txtIdPembayaran.DataBindings.Clear();
            this.txtIdPasien.DataBindings.Clear();
            this.txtIdPetugas.DataBindings.Clear();
            this.txtJumlahHarga.DataBindings.Clear();
        }

        private void FormDataPembayaran_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select id_pemabayarn, id_pasien, id_petugas, jumlah_harga", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtIdPembayaran.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pembayaran", true));
            this.txtIdPasien.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pasien", true));
            this.txtIdPetugas.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_petugas", true));
            this.txtJumlahHarga.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jumlah_harga", true));
            koneksi.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdPembayaran.Text = "";
            txtIdPasien.Text = "";
            txtIdPetugas.Text = "";
            txtJumlahHarga.Text = "";
            txtIdPembayaran.Enabled = true;
            txtIdPasien.Enabled = true;
            txtIdPetugas.Enabled = true;
            txtJumlahHarga.Enabled = true;;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void refreshform()
        {
            txtIdPembayaran.Enabled = false;
            txtIdPasien.Enabled = false;
            txtIdPetugas.Enabled = false;
            txtJumlahHarga.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
            FormDataPembayaran_Load();
        }
    }
}
