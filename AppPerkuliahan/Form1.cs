using DevComponents.DotNetBar.Controls;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string terima)
            : this()
        {
            lblname.Text = "User = " + terima;
        }

        private void ChangeSlideSide(eSlideSide side)
        {
            SpConfig.SlideSide = side;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpConfig.IsOpen = false;
            tampilMhs();
            count();
        }

        

        private void bntmhs_Click(object sender, EventArgs e)
        {
            lblData.Text = "Data Mahasiswa";
            btnconfig.Text = "Kelola Data Mahasiswa";
            lblinfo.Text = "Data Mahasiswa";
            btnmhs.TextColor = Color.Aqua;
            btnmatkul.TextColor = Color.Black;
            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Top);
            tampilMhs();
        }

        private void btnmatkul_Click(object sender, EventArgs e)
        {
            lblData.Text = "Data MataKuliah";
            btnconfig.Text = "Kelola Data MataKuliah";
            lblinfo.Text = "Data MataKuliah";
            btnmhs.TextColor = Color.Black;
            btnmatkul.TextColor = Color.Aqua;
            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            tampilKuliah();
        }

        private void btnNilai_Click(object sender, EventArgs e)
        {
            lblData.Text = "Data Nilai";
            btnconfig.Text = "Kelola Data Nilai";
            lblinfo.Text = "Data Nilai";
            btnmhs.TextColor = Color.Black;
            btnmatkul.TextColor = Color.Aqua;
            SpConfig.Visible = true;
            SpConfig.IsOpen = true;
            ChangeSlideSide(eSlideSide.Left);
            tampilnilai();
        }

        public void tampilnilai()
        {
            try
            {


                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                {
                    using (OracleCommand cmd = new OracleCommand
                    ("select * from tblnilai", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            DgViewData.DataSource = dataTable;
                            DgViewData.Columns[0].HeaderText = "KDNILAI";
                            DgViewData.Columns[1].HeaderText = "KDMK";
                            DgViewData.Columns[2].HeaderText = "NILAI";
                            DgViewData.Columns[3].HeaderText = "KDDOSEN";
                            DgViewData.Columns[4].HeaderText = "NIM";
                            DgViewData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void count()
        {
            try
            {


                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                {
                    using (OracleCommand cmd = new OracleCommand
                    ("select count(*) from tblkuliah", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string matkul;
                                matkul = reader["COUNT(*)"].ToString();
                                cpnilai.Value = Convert.ToInt16(matkul);
                            }
                        }
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            SpConfig.Visible = false;
            SpConfig.IsOpen = false;
            ChangeSlideSide(eSlideSide.Left);
        }
        public void tampilMhs()
        {
                      
            try
            {
                
                
                using(OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan"+";Password=123"+";Data Source='XE"+"';"))
                {
                    using(OracleCommand cmd = new OracleCommand
                    ("select * from tblmahasiswa",Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            DgViewData.DataSource = dataTable;
                            DgViewData.Columns[0].HeaderText = "NIM";
                            DgViewData.Columns[1].HeaderText = "NAMA";
                            DgViewData.Columns[2].HeaderText = "JURUSAN";
                            DgViewData.Columns[3].HeaderText = "KODE MATAKULIAH";
                            DgViewData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }

               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tampilKuliah()
        {
          
            try
            {


                using (OracleConnection Conn = new OracleConnection
                ("User ID=dbperkuliahan" + ";Password=123" + ";Data Source='XE" + "';"))
                {
                    using (OracleCommand cmd = new OracleCommand
                    ("select * from tblkuliah", Conn))
                    {
                        Conn.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            DgViewData.DataSource = dataTable;
                            DgViewData.Columns[0].HeaderText = "KDMK";
                            DgViewData.Columns[1].HeaderText = "NAMA MK";
                            DgViewData.Columns[2].HeaderText = "KD NILAI";
                            DgViewData.Columns[3].HeaderText = "SKS";
                            DgViewData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            DgViewData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            if (btnconfig.Text == "Kelola Data Mahasiswa")
            {
                FormMahasiswa fmhs = new FormMahasiswa();
                fmhs.ShowDialog();
                timer1.Enabled = true;
            }
            else if (btnconfig.Text == "Kelola Data MataKuliah")
            {
                FormKdMatkul frmkd = new FormKdMatkul();
                frmkd.ShowDialog();
                timer1.Enabled = true;
            }
            else if (btnconfig.Text == "Kelola Data Nilai")
            {
                FormNilai frmnilai = new FormNilai();
                frmnilai.ShowDialog();
                timer1.Enabled = true;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            if (btnconfig.Text == "Kelola Data Mahasiswa")
            {
                tampilMhs();
            }
            else if (btnconfig.Text == "Kelola Data MataKuliah")
            {
                tampilKuliah();
            }
            else if (btnconfig.Text == "Kelola Data Nilai")
            {
                tampilnilai();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show
                ("Aplikasi ingin ditutup?", "My Apps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnconfig.Text == "Kelola Data Mahasiswa")
            {
                tampilMhs();
                count();
            }
            else if (btnconfig.Text == "Kelola Data MataKuliah")
            {
                tampilKuliah();
            }
            else if (btnconfig.Text == "Kelola Data Nilai")
            {
                tampilnilai();
            }
        }

        private void DgViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Enabled = false;
        }

        
    }
}
