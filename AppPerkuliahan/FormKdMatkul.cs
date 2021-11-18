using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace AppPerkuliahan
{
    public partial class FormKdMatkul : Form
    {
        public FormKdMatkul()
        {
            InitializeComponent();
        }

        public string kdmk, namamk, kdnilai, sks;
        public void Disable()
        {
            btndel.Enabled = false;
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btngetdata.Enabled = false;
            grbDataKuliah.Enabled = false;
        }
        public void Clear()
        {
            txtkdmk.Clear();
            cmbnamamk.Text = "";
            txtnilai.Clear();
            txtsks.Clear();
        }
        public void getData()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select * from tblkuliah where KDMK='" + txtkdmk.Text + "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            txtkdmk.Text= reader["KDMK"].ToString();
                            cmbnamamk.Text= reader["NAMAMK"].ToString();
                            txtnilai.Text = reader["KDNILAI"].ToString();
                            txtsks.Text = reader["SKS"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Kode Mata Kuliah tidak terdaftar", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            Disable();
                            txtkdmk.Focus();
                            btndel.Enabled = false;
                            btnsave.Enabled = false;
                        }




                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnupdate.Enabled = true;
            btnsave.Enabled = false;
            btndel.Enabled = true;
        }

        public void insert()
        {

            string Qinsert = string.Format("Insert Into tblkuliah Values('" + kdmk + "','" + namamk + "','" + kdnilai+ "','" + sks+ "') ");
            var database = koneksi.GetConnection();
            var command = database.CreateCommand();
            command.CommandText = Qinsert;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();

        }

        public void update()
        {
            string Qupdate = string.Format("Update tblkuliah set namamk='" + namamk + "',kdnilai='" + kdnilai + "',sks='" + sks + "' where kdmk='" + kdmk + "' ");
            var database = koneksi.GetConnection();
            var command = database.CreateCommand();
            command.CommandText = Qupdate;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        public void delete()
        {
            string Qdelete = string.Format("delete from tblkuliah where KDMK='" + kdmk+ "'");
            var database = koneksi.GetConnection();
            var command = database.CreateCommand();
            command.CommandText = Qdelete;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        private void FormKdMatkul_Load(object sender, EventArgs e)
        {
            Clear();
            Disable();
            FormKdMatkul.ActiveForm.Focus();
        }

        private void FormKdMatkul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                grbDataKuliah.Enabled = true;
                btndel.Enabled = false;
                btnnew.Enabled = true;
                btnsave.Enabled = true;
                btngetdata.Enabled = true;
                btnupdate.Enabled = false;
                Clear();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            grbDataKuliah.Enabled = true;
            btndel.Enabled = false;
            btnnew.Enabled = true;
            btnsave.Enabled = true;
            btngetdata.Enabled = true;
            btnupdate.Enabled = false;
            Clear();
        }

        private void txtkdmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                FormKdMatkul frmkdMatkul= new FormKdMatkul()
                {
                    kdmk = txtkdmk.Text,
                    namamk = cmbnamamk.Text,
                    kdnilai = txtnilai.Text,
                    sks = txtsks.Text
                };
                frmkdMatkul.insert();
                MessageBox.Show("Data Berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show
                ("Apakah data ingin diupdate?", "My Apps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                try
                {

                    kdmk = txtkdmk.Text;
                    namamk = cmbnamamk.Text;
                    kdnilai = txtnilai.Text;
                    sks = txtsks.Text;
                    update();
                    MessageBox.Show("Data Berhasil diupdate", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                FormKdMatkul frmkdMatkul = new FormKdMatkul()
                {
                    kdmk = txtkdmk.Text
                };
                frmkdMatkul.delete();
                MessageBox.Show("Data Berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtkdmk.Focus();
                Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
