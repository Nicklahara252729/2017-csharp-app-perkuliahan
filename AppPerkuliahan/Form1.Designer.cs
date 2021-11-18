namespace AppPerkuliahan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNilai = new DevComponents.DotNetBar.ButtonX();
            this.btnlogout = new DevComponents.DotNetBar.ButtonX();
            this.SpConfig = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.btnrefresh = new DevComponents.DotNetBar.ButtonX();
            this.btnclose = new DevComponents.DotNetBar.ButtonX();
            this.btnconfig = new DevComponents.DotNetBar.ButtonX();
            this.btnmatkul = new DevComponents.DotNetBar.ButtonX();
            this.btnmhs = new DevComponents.DotNetBar.ButtonX();
            this.DgViewData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpnilai = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.NILAI = new System.Windows.Forms.Label();
            this.cpmahasiswa = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnNilai);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.SpConfig);
            this.panel1.Controls.Add(this.btnmatkul);
            this.panel1.Controls.Add(this.btnmhs);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 98);
            this.panel1.TabIndex = 0;
            // 
            // btnNilai
            // 
            this.btnNilai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNilai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNilai.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNilai.Location = new System.Drawing.Point(242, 2);
            this.btnNilai.Name = "btnNilai";
            this.btnNilai.Size = new System.Drawing.Size(119, 97);
            this.btnNilai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNilai.Symbol = "";
            this.btnNilai.SymbolSize = 30F;
            this.btnNilai.TabIndex = 5;
            this.btnNilai.Text = "Nilai";
            this.btnNilai.Click += new System.EventHandler(this.btnNilai_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlogout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlogout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnlogout.Location = new System.Drawing.Point(794, 1);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(91, 96);
            this.btnlogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlogout.Symbol = "";
            this.btnlogout.SymbolSize = 30F;
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.TextColor = System.Drawing.Color.Red;
            this.btnlogout.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // SpConfig
            // 
            this.SpConfig.BackColor = System.Drawing.Color.Cyan;
            this.SpConfig.Controls.Add(this.btnrefresh);
            this.SpConfig.Controls.Add(this.btnclose);
            this.SpConfig.Controls.Add(this.btnconfig);
            this.SpConfig.Location = new System.Drawing.Point(361, 2);
            this.SpConfig.Name = "SpConfig";
            this.SpConfig.Size = new System.Drawing.Size(192, 96);
            this.SpConfig.SlideOutButtonVisible = false;
            this.SpConfig.TabIndex = 1;
            this.SpConfig.Text = "slidePanel1";
            this.SpConfig.UsesBlockingAnimation = false;
            this.SpConfig.Visible = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnrefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnrefresh.Location = new System.Drawing.Point(120, 3);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(25, 23);
            this.btnrefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnrefresh.Symbol = "";
            this.btnrefresh.SymbolSize = 10F;
            this.btnrefresh.TabIndex = 2;
            this.btnrefresh.TextColor = System.Drawing.Color.DarkOliveGreen;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnclose
            // 
            this.btnclose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnclose.Location = new System.Drawing.Point(151, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 23);
            this.btnclose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclose.Symbol = "";
            this.btnclose.SymbolSize = 10F;
            this.btnclose.TabIndex = 1;
            this.btnclose.TextColor = System.Drawing.Color.Red;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnconfig
            // 
            this.btnconfig.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnconfig.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnconfig.Location = new System.Drawing.Point(16, 41);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(160, 23);
            this.btnconfig.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnconfig.TabIndex = 1;
            this.btnconfig.Text = "Kelolah Data Matakuliah";
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // btnmatkul
            // 
            this.btnmatkul.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmatkul.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmatkul.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnmatkul.Location = new System.Drawing.Point(121, 2);
            this.btnmatkul.Name = "btnmatkul";
            this.btnmatkul.Size = new System.Drawing.Size(119, 97);
            this.btnmatkul.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmatkul.Symbol = "";
            this.btnmatkul.SymbolSize = 30F;
            this.btnmatkul.TabIndex = 2;
            this.btnmatkul.Text = "Mata Kuliah";
            this.btnmatkul.Click += new System.EventHandler(this.btnmatkul_Click);
            // 
            // btnmhs
            // 
            this.btnmhs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmhs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmhs.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnmhs.Location = new System.Drawing.Point(0, 1);
            this.btnmhs.Name = "btnmhs";
            this.btnmhs.Size = new System.Drawing.Size(119, 97);
            this.btnmhs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmhs.Symbol = "";
            this.btnmhs.SymbolSize = 30F;
            this.btnmhs.TabIndex = 1;
            this.btnmhs.Text = "Mahasiswa";
            this.btnmhs.Click += new System.EventHandler(this.bntmhs_Click);
            // 
            // DgViewData
            // 
            this.DgViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewData.Location = new System.Drawing.Point(1, 138);
            this.DgViewData.Name = "DgViewData";
            this.DgViewData.Size = new System.Drawing.Size(751, 371);
            this.DgViewData.TabIndex = 1;
            this.DgViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewData_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.lblinfo);
            this.panel2.Location = new System.Drawing.Point(1, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 23);
            this.panel2.TabIndex = 2;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(3, 5);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(86, 13);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "Data Mahasiswa";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(2, 110);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(185, 25);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data Mahasiswa";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpnilai
            // 
            // 
            // 
            // 
            this.cpnilai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpnilai.Location = new System.Drawing.Point(758, 138);
            this.cpnilai.Name = "cpnilai";
            this.cpnilai.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cpnilai.ProgressColor = System.Drawing.Color.Red;
            this.cpnilai.ProgressTextVisible = true;
            this.cpnilai.Size = new System.Drawing.Size(145, 101);
            this.cpnilai.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpnilai.TabIndex = 5;
            // 
            // NILAI
            // 
            this.NILAI.AutoSize = true;
            this.NILAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NILAI.Location = new System.Drawing.Point(771, 256);
            this.NILAI.Name = "NILAI";
            this.NILAI.Size = new System.Drawing.Size(68, 25);
            this.NILAI.TabIndex = 6;
            this.NILAI.Text = "NILAI";
            // 
            // cpmahasiswa
            // 
            // 
            // 
            // 
            this.cpmahasiswa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cpmahasiswa.Location = new System.Drawing.Point(758, 303);
            this.cpmahasiswa.Name = "cpmahasiswa";
            this.cpmahasiswa.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cpmahasiswa.ProgressColor = System.Drawing.Color.DarkKhaki;
            this.cpmahasiswa.ProgressTextVisible = true;
            this.cpmahasiswa.Size = new System.Drawing.Size(145, 101);
            this.cpmahasiswa.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cpmahasiswa.TabIndex = 7;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(521, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(173, 25);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Nama Admin : -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 538);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.cpmahasiswa);
            this.Controls.Add(this.NILAI);
            this.Controls.Add(this.cpnilai);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgViewData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.SpConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.SlidePanel SpConfig;
        private DevComponents.DotNetBar.ButtonX btnrefresh;
        private DevComponents.DotNetBar.ButtonX btnclose;
        private DevComponents.DotNetBar.ButtonX btnconfig;
        private DevComponents.DotNetBar.ButtonX btnmatkul;
        private DevComponents.DotNetBar.ButtonX btnmhs;
        private DevComponents.DotNetBar.ButtonX btnlogout;
        private System.Windows.Forms.DataGridView DgViewData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX btnNilai;
        private DevComponents.DotNetBar.Controls.CircularProgress cpnilai;
        private System.Windows.Forms.Label NILAI;
        private DevComponents.DotNetBar.Controls.CircularProgress cpmahasiswa;
        private System.Windows.Forms.Label lblname;
    }
}

