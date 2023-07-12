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
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select nama_pasien from Tbl_Pasien";
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
            string nmPasien = nmp.Text;
            string AlmtPasien = nmp.Text;
            string idPasien = nmp.Text;
            string tgldatangPasien = nmp.Text;
            string keluhanPasien = nmp.Text;

            if (nmPasien == "")
            {
                MessageBox.Show("Masukkan Nama Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AlmtPasien == "")
            {
                MessageBox.Show("Masukkan Alamat Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idPasien == "")
            {
                MessageBox.Show("Masukkan Id Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tgldatangPasien == "")
            {
                MessageBox.Show("Masukkan tgldatang Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (keluhanPasien == "")
            {
                MessageBox.Show("Masukkan keluhan Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into Tbl_Pasien (id_pasien, nama_pasien, alamat_Pasien, tgldatang_pasien, keluhan_pasien)" + "values(@id_pasien, @nama_pasien, @alamat_pasien, @tgldatang_pasien, @keluhan_pasien)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("alamat_Pasien", AlmtPasien));
                cmd.Parameters.Add(new SqlParameter("nama_Pasien", nmPasien));
                cmd.Parameters.Add(new SqlParameter("id_Pasien", idPasien));
                cmd.Parameters.Add(new SqlParameter("tgldatang_Pasien", tgldatangPasien));
                cmd.Parameters.Add(new SqlParameter("keluhan_Pasien", keluhanPasien));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}