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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_petugas from Tbl_Petugas";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NmPetugas = nmp.Text;
            string AlmtPetugas = nmp.Text;
            string IDPetugas = nmp.Text;
            string JamJaga = nmp.Text;

            if (NmPetugas == "")
            {
                MessageBox.Show("Masukkan nama Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AlmtPetugas == "")
            {
                MessageBox.Show("Masukkan alamat Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IDPetugas == "")
            {
                MessageBox.Show("Masukkan Id Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (JamJaga == "")
            {
                MessageBox.Show("Masukkan jam jaga", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into Tbl_Pasien (id_petugas, nama_petugas, alamat_Petugas, jamjaga)" + "values(@id_petugas, @nama_petugas, @alamat_petugas, @jam_jaga)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_petugas", IDPetugas));
                cmd.Parameters.Add(new SqlParameter("nama_petugas", NmPetugas));
                cmd.Parameters.Add(new SqlParameter("alamat_petugas", AlmtPetugas));
                cmd.Parameters.Add(new SqlParameter("jam_jaga", JamJaga));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    }
}
