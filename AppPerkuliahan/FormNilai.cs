using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPerkuliahan
{
    public partial class FormNilai : Form
    {
        public FormNilai()
        {
            InitializeComponent();
        }
        public string kdnilai, kdmk, nilai, kddosen,nim;
        public void insert()
        {

            string Qinsert = string.Format("Insert Into tblnilai Values('" + kdnilai + "','" + kdmk + "','" + nilai + "','" + kddosen + "','" + nim + "') ");
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

            string Qupdate = string.Format("Update tblnilai set KDMK='" + kdmk + "',NILAI='" + nilai + "',KDDOSEN='" + kddosen + "',NIM='" + nim + "' where KDNILAI='" + nilai + "' "); 
           var database = koneksi.GetConnection();
            var command = database.CreateCommand();
            command.CommandText = Qupdate;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        public void getData()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select * from tblnilai where KDNILAI='" + txtkdnilai.Text + "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            txtkddosen.Text = reader["KDDOSEN"].ToString();
                            txtnilai.Text = reader["NILAI"].ToString();
                            txtkdnilai.Text = reader["KDNILAI"].ToString();
                            cmbnim.Text = reader["NIM"].ToString();
                            cmbkdmk.Text = reader["KDMK"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("NIM tidak terdaftar", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            Disable();
                            btngetdata.Enabled = true;
                            txtkdnilai.Focus();
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

        public void getKdmk()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select kdmk from tblkuliah", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbkdmk.Items.Add(reader["KDMK"].ToString());

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

        public void getNIM()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select NIM from tblmahasiswa", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbnim.Items.Add(reader["NIM"].ToString());

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
        public void delete()
        {
            string Qdelete = string.Format("delete from tblnilai where KDNILAI='" + kdnilai+ "'");
            var database = koneksi.GetConnection();
            var command = database.CreateCommand();
            command.CommandText = Qdelete;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        public void Disable()
        {
            btndel.Enabled = false;
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btngetdata.Enabled = false;
        }
        public void Clear()
        {
            txtkddosen.Clear();
            txtkdnilai.Clear();
            txtnilai.Clear();
            cmbkdmk.Text = "";
            cmbnim.Text = "";
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            grbdatamahasiswa.Enabled = true;
            btndel.Enabled = false;
            btnnew.Enabled = true;
            btnsave.Enabled = true;
            btngetdata.Enabled = true;
            btnupdate.Enabled = false;
            Clear();
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            getKdmk();
            getNIM();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                FormNilai frmnilai = new FormNilai()
                {
                    kdnilai = txtkdnilai.Text, 
                    kdmk = cmbkdmk.Text, 
                    nilai = txtnilai.Text, 
                    kddosen = txtkddosen.Text,
                    nim = cmbnim.Text
                };
                frmnilai.insert();
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

                    FormNilai frmnilai = new FormNilai()
                {
                    kdnilai = txtkdnilai.Text, 
                    kdmk = cmbkdmk.Text, 
                    nilai = txtnilai.Text, 
                    kddosen = txtkddosen.Text,
                    nim = cmbnim.Text
                };
                    frmnilai.Update();
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

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                FormNilai frmnilai= new FormNilai()
                {
                     kdnilai = txtkdnilai.Text
                };
                frmnilai.delete();
                MessageBox.Show("Data Berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtkdnilai.Focus();
                Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
