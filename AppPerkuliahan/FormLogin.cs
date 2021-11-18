using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Data.OracleClient;

namespace AppPerkuliahan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void ChangeSlideSide(eSlideSide eslideside)
        {
            
            spadmin.SlideSide = eslideside;

        }
        
        private void spclient_Load(object sender, EventArgs e)
        {
            spclient.Visible = false;
            spmain.Visible = true;
            spadmin.Visible = false;

            spmain.IsOpen = true;
            spadmin.IsOpen = false;
            spclient.IsOpen = false;
        }

        private void pcadmin_Click(object sender, EventArgs e)
        {

            spmain.IsOpen = false;
            ChangeSlideSide(eSlideSide.Left);
            spadmin.IsOpen = true;
            spadmin.Visible = true;
            spclient.Visible = false;

        }

        private void pcclient_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = false;
            ChangeSlideSide(eSlideSide.Left);
            spclient.IsOpen = true;
            spclient.Visible = true;

            
        }

        private void pcthome_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = true;
            spclient.IsOpen = false;
            ChangeSlideSide(eSlideSide.Right);
            spclient.Visible = false;
            spadmin.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            spmain.IsOpen = true;
            spadmin.IsOpen = false;
            ChangeSlideSide(eSlideSide.Right);
            spclient.Visible = false;
            spadmin.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpass.Text != "")
            {
                try
                {
                    string hasil = "";
                    using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                    using (OracleCommand cmd = new OracleCommand("select * from tbluser where id='"+txtusername.Text+"'", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hasil = reader["PASSWORD"].ToString();
                                if (txtpass.Text == hasil)
                                {
                                    String kiriman;
                                    kiriman = txtusername.Text;
                                    Form1 frmutama = new Form1(kiriman);
                                    this.Hide();
                                    frmutama.ShowDialog();
                                }
                            }
                            if (hasil == "")
                            {
                                MessageBox.Show("Username atau Password Salah", "INFROMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtpass.Clear();
                                txtpass.Clear();
                                this.ActiveControl = txtusername;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btncancel2_Click(object sender, EventArgs e)
        {
            if (txtnim.Text != "" && txtpassclient.Text != "")
            {
                try
                {
                    string hasil = "";
                    using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                    using (OracleCommand cmd = new OracleCommand("select * from tbluser where id='" + txtnim.Text + "'", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hasil = reader["PASSWORD"].ToString();
                                if (txtpassclient.Text == hasil)
                                {
                                    String kiriman;
                                    kiriman = txtnim.Text;
                                    FormClient frmutama = new FormClient(kiriman);
                                    this.Hide();
                                    frmutama.ShowDialog();
                                }
                            }
                            if (hasil == "")
                            {
                                MessageBox.Show("Username atau Password Salah", "INFROMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtpassclient.Clear();
                                this.ActiveControl = txtnim;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       

        
    }
}
