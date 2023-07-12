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
    public partial class Form9 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-94VJAKDC\\NALENDRASS;Initial Catalog=DB_RS;Persist Security Info=True;User ID=sa;Password=10Desember2002";
        private SqlConnection koneksi;
        private string namapasien,alamatpasien,idpasien,keluhan;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        public Form9()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.customersBindingSource = this.customersBindingSource;
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            namapasien = txtNamaPasien.Text.Trim();
            alamatpasien = txtAlamatPasien.Text.Trim();
            idpasien = txtIDPasien.Text.Trim();
            keluhan = txtKeluhan.Text.Trim();
            tgl = dtTglDatang.Value;

            if (string.IsNullOrEmpty(namapasien) || string.IsNullOrEmpty(alamatpasien) || string.IsNullOrEmpty(idpasien) || string.IsNullOrEmpty(keluhan))
            {
                MessageBox.Show("Please fill in all identity fields!");
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO mahasiswa (nama_pasien, alamat_pasien, id_pasien, keluhan, tgl_datang) VALUES (@nama_pasien, @alamat_pasien, @id_pasien, @keluhan, @tgl_datang)";
                SqlCommand command = new SqlCommand(query, koneksi);
                command.Parameters.AddWithValue("@nama_pasien", namapasien);
                command.Parameters.AddWithValue("@alamat_pasien", alamatpasien);
                command.Parameters.AddWithValue("@id_pasien", idpasien);
                command.Parameters.AddWithValue("@keluhan", keluhan);
                command.Parameters.AddWithValue("@tgl_datang", tgl);
                command.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data has been saved to the database.");
            }
            refreshform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void clearBinding()
        {
            this.txtNamaPasien.DataBindings.Clear();
            this.txtAlamatPasien.DataBindings.Clear();
            this.txtIDPasien.DataBindings.Clear();
            this.txtKeluhan.DataBindings.Clear();
            this.dtTglDatang.DataBindings.Clear();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void FormDataPasien_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT nama_pasien, alamat, id_pasien, keluhan, tgl_datang FROM Pasien", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNamaPasien.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_pasien", true));
            this.txtAlamatPasien.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat_pasien", true));
            this.txtIDPasien.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pasien", true));
            this.txtKeluhan.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "keluhan", true));
            this.dtTglDatang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_datang", true));
            koneksi.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNamaPasien.Text = "";
            txtAlamatPasien.Text = "";
            txtIDPasien.Text = "";
            txtKeluhan.Text = "";
            dtTglDatang.Value = DateTime.Today;
            txtNamaPasien.Enabled = true;
            txtAlamatPasien.Enabled = true;
            txtIDPasien.Enabled = true;
            txtKeluhan.Enabled = true;
            dtTglDatang.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void refreshform()
        {
            txtNamaPasien.Enabled = false;
            txtAlamatPasien.Enabled = false;
            txtIDPasien.Enabled = false;
            txtKeluhan.Enabled = false;
            dtTglDatang.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            clearBinding();
            FormDataPasien_Load();
        }
    }
}
