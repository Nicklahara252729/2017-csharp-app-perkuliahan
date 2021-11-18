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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        public FormClient(string terima)
            : this()
        {
            lblnim.Text = terima;
        }

        public void tampildataUser()
        {
            try
            {
                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("Select * from tblmahasiswa where NIM='" + lblnim.Text+ "'", Conn))
                {
                    Conn.Open();
                    using (OracleDataReader Reader = cmd.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            txtnama.Text = Reader["NAMA"].ToString();
                            txtnim.Text = Reader["NIM"].ToString();
                            txtjurusan.Text = Reader["JURUSAN"].ToString();
                            txtkdmatkul.Text = Reader["KDMK"].ToString();
                            lblnama.Text = Reader["NAMA"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            tampildataUser();
            txtnim.Enabled = false;
            txtnama.Enabled = false;
            txtjurusan.Enabled = false;
            txtkdmatkul.Enabled = false;
            lblnim.Enabled = false;
        }
    }
}
