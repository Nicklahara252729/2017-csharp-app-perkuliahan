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
    public partial class FrmMahasiswa : Form
    {
        public FrmMahasiswa()
        {
            InitializeComponent();
        }

        public string nim, nama, jurusan, kdmk;

        public void insert()
        {
            string query = string.Format("insert into tblmahasiswa values('" + nim + "','" + nama + "','" + jurusan + "' ,'" + kdmk + "')" );
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        private void FrmMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void btndmnew_Click(object sender, EventArgs e)
        {
            gpdatamahasiswa.Enabled = true;
            btndmsave.Enabled = true;
            btndmupdate.Enabled = true;
            btndmdelete.Enabled = true;
            btndmgetdata.Enabled = true;
        }

        public void EnableFalse()
        {
            btndmsave.Enabled = false;
            btndmupdate.Enabled = false;
            btndmdelete.Enabled = false; ;
            btndmgetdata.Enabled = false;

        }

        private void btndmsave_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMahasiswa mhs = new FrmMahasiswa
                {
                    nim = txtnim.Text,
                    nama = txtnama.Text,
                    jurusan = cmbjurusan.Text,
                    kdmk = txtmatkul.Text,
                };
                mhs.insert();
                clrscr();
                MessageBox.Show(" Data berhasil di simpan");
                EnableFalse();
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clrscr()
        {
            txtnim.Clear();
            txtnama.Clear();
            cmbjurusan.Text = "pilih";
            txtmatkul.Clear();
        }

        private void btndmgetdata_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE"+"';"))
                using (OracleCommand Cmd = new OracleCommand ("select * from tblmahasiswa where nim = '" + txtnim.Text + "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader Reader = Cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            txtnama.Text = Reader["NAMA"].ToString(); 
                            cmbjurusan.Text = Reader["JURUSAN"].ToString();
                            txtmatkul.Text = Reader["KDMK"].ToString();
                        }
                    }
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndmupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Data akan di edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    string enim = txtnim.Text;
                    string query = string.Format("Update tblmahasiswa set nim ='" + enim + "',nama = '" + txtnama.Text + "', jurusan = '" + cmbjurusan.Text + "', kdmk = '" + txtmatkul.Text + "' where nim = '" + enim + "'");
                    var database = koneksi.GetOracleConnection();
                    var Command = database.CreateCommand();
                    Command.CommandText = query;
                    database.Open();
                    Command.ExecuteNonQuery();
                    database.Close();
                    database.Dispose();
                    Command.Dispose();
                    MessageBox.Show("Data berhasil diubah");
                    clrscr();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btndmdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Data akan di Dihapus?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    string enim = txtnim.Text;
                    string query = string.Format("delete from tblmahasiswa where nim ='" + enim + "'");
                    var database = koneksi.GetOracleConnection();
                    var Command = database.CreateCommand();
                    Command.CommandText = query;
                    database.Open();
                    Command.ExecuteNonQuery();
                    database.Close();
                    database.Dispose();
                    Command.Dispose();
                    MessageBox.Show("Data berhasil dihapus");
                    clrscr();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clrscr();
        }
    }
}
