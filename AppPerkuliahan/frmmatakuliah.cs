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
    public partial class frmmatakuliah : Form
    {
        public frmmatakuliah()
        {
            InitializeComponent();
        }

        private void btnmknew_Click(object sender, EventArgs e)
        {
            gpdatamahasiswa.Enabled = true;
            btnmknew.Enabled = true;
            btnmkupdate.Enabled = true;
            btnmkdelete.Enabled = true;
            btnmkgetdata.Enabled = true;
        }

        public void EnableFalse()
        {
            btnmksave.Enabled = false;
            btnmkupdate.Enabled = false;
            btnmkdelete.Enabled = false; ;
            btnmkgetdata.Enabled = false;

        }

        public string kdmk, namamk, kdnilai, sks;

        public void insert()
        {
            string query = string.Format("insert into tblkuliah values('" + kdmk + "','" + namamk + "','" + kdnilai + "' ,'" + sks + "')");
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery(); 
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        private void btnmksave_Click(object sender, EventArgs e)
        {
            try
            {
                frmmatakuliah matkul = new frmmatakuliah
                {
                    kdmk = txtkodemk.Text,
                    namamk = cmnamamk.Text,
                    kdnilai = txtkdnilai.Text,
                    sks = txtsks.Text,
                };
                matkul.insert();
                clrscr();
                MessageBox.Show(" Data berhasil di simpan");
                EnableFalse();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clrscr()
        {
            txtkodemk.Clear();
            txtkdnilai.Clear();
            cmnamamk.Text = "pilih";
            txtsks.Clear();
        }

        private void frmmatakuliah_Load(object sender, EventArgs e)
        {

        }

        private void btnmkgetdata_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand Cmd = new OracleCommand("select * from tblkuliah where kdmk = '" + txtkodemk.Text + "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader Reader = Cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            cmnamamk.Text = Reader["NAMAMK"].ToString();
                            txtkdnilai.Text = Reader["KDNILAI"].ToString();
                            txtsks.Text = Reader["SKS"].ToString();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmkdelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Data akan di Dihapus?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    string enim = txtkodemk.Text;
                    string query = string.Format("delete from tblkuliah where kdmk ='" + enim + "'");
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

        private void btnmkupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Data akan di edit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    string enim = txtkodemk.Text;
                    string query = string.Format("Update tblkuliah set kdmk ='" + enim + "',namamk = '" + cmnamamk.Text + "', kdnilai = '" + txtkdnilai.Text + "', sks = '" + txtsks.Text + "' where kdmk = '" + enim + "'");
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
