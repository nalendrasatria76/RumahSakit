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
    public partial class Form5 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-94VJAKDC\\NALENDRASS;Initial Catalog=DB_RS;Persist Security Info=True;User ID=sa;Password=10Desember2002";
        private SqlConnection koneksi;

        public void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Form5()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_dokter from Tbl_Dokter";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmDokter = nmp.Text;
            string AlamatDokter = nmp.Text;
            string idDokter = nmp.Text;
            string SpesialisDokter = nmp.Text;

            if (nmDokter == "")
            {
                MessageBox.Show("Masukkan Nama Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AlamatDokter == "")
            {
                MessageBox.Show("Masukkan Alamat Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idDokter == "")
            {
                MessageBox.Show("Masukkan Id Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SpesialisDokter == "")
            {
                MessageBox.Show("Masukkan Spesialis Dokter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into Tbl_Pasien (id_dokter, nama_dokter, Alamat_Dokter, SpesialisSokter)" + "values(@id_dokter, @nama_dokter, @Alamat_Dokter, @Spesialis_Sokter)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Alamat_Dokter", AlamatDokter));
                cmd.Parameters.Add(new SqlParameter("nama_Dokter", nmDokter));
                cmd.Parameters.Add(new SqlParameter("id_Dokter", idDokter));
                cmd.Parameters.Add(new SqlParameter("Spesialis_dokter", SpesialisDokter));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }
    }
}
