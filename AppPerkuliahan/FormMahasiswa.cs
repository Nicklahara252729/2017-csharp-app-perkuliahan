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
    public partial class FormMahasiswa : Form
    {
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        public string nim, nama, jurusan, kdmk;

        public void insert()
        {
            
            string Qinsert = string.Format("Insert Into tblmahasiswa Values('" + nim + "','" + nama + "','" + jurusan + "','" + kdmk + "') ");
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
            string Qupdate = string.Format("Update tblmahasiswa set nama='" + nama + "',jurusan='" + jurusan + "',kdmk='" + kdmk + "' where NIM='"+nim+"' ");
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
                using(OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select * from tblmahasiswa where NIM='" + txtnim.Text + "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                                txtnama.Text = reader["NAMA"].ToString();
                                cmbjurusan.Text = reader["JURUSAn"].ToString();
                                txtkdmatkul.Text = reader["KDMK"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("NIM tidak terdaftar", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            Disable();
                            txtnim.Focus();
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

        public void getKdmk(){
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

                            txtkdmatkul.Items.Add(reader["KDMK"].ToString()); 

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
            string Qdelete = string.Format("delete from tblmahasiswa where NIM='"+nim+"'");
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
            txtnim.Clear();
            txtnama.Clear();
            cmbjurusan.Text = "";
            txtkdmatkul.Text = "";
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

        public string id, password, level;
        public void insertUser(){
        string query= string.Format("insert into tbluser values('"+ id +"','"+ password+"','"+level+"')");
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                FormMahasiswa frmMhs = new FormMahasiswa()
                {
                    nim = txtnim.Text,
                    nama = txtnama.Text,
                    jurusan = cmbjurusan.Text,
                    kdmk = txtkdmatkul.Text
                };             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                FormMahasiswa user = new FormMahasiswa{
                    id = txtnim.Text,
                    password = txtpassword.Text,
                    level = "client"
                };
            user.insertUser();
            Clear();
            MessageBox.Show("Data berhasil disimpan");
            Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                }

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

                    nama = txtnama.Text;
                    jurusan = cmbjurusan.Text;
                    kdmk = txtkdmatkul.Text;
                    nim = txtnim.Text;
                    txtnim.Enabled = false;
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

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                FormMahasiswa frmMhs = new FormMahasiswa()
                {
                    nim = txtnim.Text
                };
                frmMhs.delete();
                MessageBox.Show("Data Berhasil dihapus", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtnim.Focus();
                Disable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            Disable();
            getKdmk();
        }

        

        private void txtnama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbjurusan.Focus();
            }
        }

        private void cmbjurusan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtkdmatkul.Focus();
            }
        }

        private void txtkdmatkul_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnsave.PerformClick();
            }
        }

        private void txtnim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getData();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                txtnama.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        

        
    }
    
}
