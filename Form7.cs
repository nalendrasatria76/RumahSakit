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
    public partial class Form7 : Form
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
        public Form7()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pembayaran from Tbl_Pembayaran";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string IdPembayaran = nmp.Text;
            string IdPasien = nmp.Text;
            string JumlahHarga = nmp.Text;
            string IdPetugas = nmp.Text;

            if (IdPembayaran == "")
            {
                MessageBox.Show("Masukkan Id Pembayaran", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdPasien == "")
            {
                MessageBox.Show("Masukkan Id Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdPetugas == "")
            {
                MessageBox.Show("Masukkan Id Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (JumlahHarga == "")
            {
                MessageBox.Show("Masukkan Jumlah Harga", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into Tbl_Pasien (id_pembayaran, id_pasien, id_petugas, jumlah_harga)" + "values(@id_pembayaran, @id_pasien, @id_petugas, @jumlah_harga)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_pembayaran", IdPembayaran));
                cmd.Parameters.Add(new SqlParameter("id_pasien", IdPasien));
                cmd.Parameters.Add(new SqlParameter("id_Petugas", IdPetugas));
                cmd.Parameters.Add(new SqlParameter("jumlah_harga", JumlahHarga));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }
    }
}
