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
    public partial class Form8 : Form
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
        public Form8()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_rawatinap from Tbl_RawatInap";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string IdRawatInap= nmp.Text;
            string IdPasien = nmp.Text;
            string IdRuang = nmp.Text;

            if (IdRawatInap == "")
            {
                MessageBox.Show("Masukkan Id Rawat Inap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdPasien == "")
            {
                MessageBox.Show("Masukkan Id Pasien", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdRuang == "")
            {
                MessageBox.Show("Masukkan Id Petugas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into Tbl_Pasien (id_rawatinap, id_pasien, id_ruang)" + "values(@id_rawatinap, @id_pasien, @id_ruang)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_rawatinap", IdRawatInap));
                cmd.Parameters.Add(new SqlParameter("id_pasien", IdPasien));
                cmd.Parameters.Add(new SqlParameter("id_ruang", IdRuang));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

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

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
            this.Hide();
        }
    }
}
