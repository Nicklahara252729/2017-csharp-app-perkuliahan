namespace AppPerkuliahan
{
    partial class frmmatakuliah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmatakuliah));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpdatamahasiswa = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmnamamk = new System.Windows.Forms.ComboBox();
            this.txtsks = new System.Windows.Forms.TextBox();
            this.txtkdnilai = new System.Windows.Forms.TextBox();
            this.txtkodemk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmkgetdata = new DevComponents.DotNetBar.ButtonX();
            this.btnmkdelete = new DevComponents.DotNetBar.ButtonX();
            this.btnmkupdate = new DevComponents.DotNetBar.ButtonX();
            this.btnmksave = new DevComponents.DotNetBar.ButtonX();
            this.btnmknew = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpdatamahasiswa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kelola Data Matakuliah";
            // 
            // gpdatamahasiswa
            // 
            this.gpdatamahasiswa.Controls.Add(this.label5);
            this.gpdatamahasiswa.Controls.Add(this.label4);
            this.gpdatamahasiswa.Controls.Add(this.label3);
            this.gpdatamahasiswa.Controls.Add(this.label2);
            this.gpdatamahasiswa.Controls.Add(this.cmnamamk);
            this.gpdatamahasiswa.Controls.Add(this.txtsks);
            this.gpdatamahasiswa.Controls.Add(this.txtkdnilai);
            this.gpdatamahasiswa.Controls.Add(this.txtkodemk);
            this.gpdatamahasiswa.Enabled = false;
            this.gpdatamahasiswa.Location = new System.Drawing.Point(6, 41);
            this.gpdatamahasiswa.Name = "gpdatamahasiswa";
            this.gpdatamahasiswa.Size = new System.Drawing.Size(483, 221);
            this.gpdatamahasiswa.TabIndex = 7;
            this.gpdatamahasiswa.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kode Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama MK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode MK";
            // 
            // cmnamamk
            // 
            this.cmnamamk.FormattingEnabled = true;
            this.cmnamamk.Items.AddRange(new object[] {
            "Algoritma Pemrograman",
            "Teknik Digital",
            "Mikroprosessor",
            "Multimedia",
            "Teknik Animasi"});
            this.cmnamamk.Location = new System.Drawing.Point(177, 75);
            this.cmnamamk.Name = "cmnamamk";
            this.cmnamamk.Size = new System.Drawing.Size(237, 21);
            this.cmnamamk.TabIndex = 3;
            // 
            // txtsks
            // 
            this.txtsks.Location = new System.Drawing.Point(177, 155);
            this.txtsks.Multiline = true;
            this.txtsks.Name = "txtsks";
            this.txtsks.Size = new System.Drawing.Size(237, 29);
            this.txtsks.TabIndex = 2;
            // 
            // txtkdnilai
            // 
            this.txtkdnilai.Location = new System.Drawing.Point(177, 113);
            this.txtkdnilai.Multiline = true;
            this.txtkdnilai.Name = "txtkdnilai";
            this.txtkdnilai.Size = new System.Drawing.Size(237, 29);
            this.txtkdnilai.TabIndex = 1;
            // 
            // txtkodemk
            // 
            this.txtkodemk.Location = new System.Drawing.Point(177, 28);
            this.txtkodemk.Multiline = true;
            this.txtkodemk.Name = "txtkodemk";
            this.txtkodemk.Size = new System.Drawing.Size(237, 29);
            this.txtkodemk.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmkgetdata);
            this.groupBox1.Controls.Add(this.btnmkdelete);
            this.groupBox1.Controls.Add(this.btnmkupdate);
            this.groupBox1.Controls.Add(this.btnmksave);
            this.groupBox1.Controls.Add(this.btnmknew);
            this.groupBox1.Location = new System.Drawing.Point(495, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnmkgetdata
            // 
            this.btnmkgetdata.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmkgetdata.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmkgetdata.Location = new System.Drawing.Point(9, 184);
            this.btnmkgetdata.Name = "btnmkgetdata";
            this.btnmkgetdata.Size = new System.Drawing.Size(185, 32);
            this.btnmkgetdata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmkgetdata.TabIndex = 4;
            this.btnmkgetdata.Text = "GET DATA";
            this.btnmkgetdata.Click += new System.EventHandler(this.btnmkgetdata_Click);
            // 
            // btnmkdelete
            // 
            this.btnmkdelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmkdelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmkdelete.Location = new System.Drawing.Point(9, 148);
            this.btnmkdelete.Name = "btnmkdelete";
            this.btnmkdelete.Size = new System.Drawing.Size(185, 30);
            this.btnmkdelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmkdelete.TabIndex = 3;
            this.btnmkdelete.Text = "DELETE";
            this.btnmkdelete.Click += new System.EventHandler(this.btnmkdelete_Click);
            // 
            // btnmkupdate
            // 
            this.btnmkupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmkupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmkupdate.Location = new System.Drawing.Point(9, 107);
            this.btnmkupdate.Name = "btnmkupdate";
            this.btnmkupdate.Size = new System.Drawing.Size(185, 33);
            this.btnmkupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmkupdate.TabIndex = 2;
            this.btnmkupdate.Text = "UPDATE";
            this.btnmkupdate.Click += new System.EventHandler(this.btnmkupdate_Click);
            // 
            // btnmksave
            // 
            this.btnmksave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmksave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmksave.Location = new System.Drawing.Point(9, 65);
            this.btnmksave.Name = "btnmksave";
            this.btnmksave.Size = new System.Drawing.Size(185, 36);
            this.btnmksave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmksave.TabIndex = 1;
            this.btnmksave.Text = "SAVE";
            this.btnmksave.Click += new System.EventHandler(this.btnmksave_Click);
            // 
            // btnmknew
            // 
            this.btnmknew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnmknew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnmknew.Location = new System.Drawing.Point(9, 20);
            this.btnmknew.Name = "btnmknew";
            this.btnmknew.Size = new System.Drawing.Size(185, 38);
            this.btnmknew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnmknew.TabIndex = 0;
            this.btnmknew.Text = "NEW";
            this.btnmknew.Click += new System.EventHandler(this.btnmknew_Click);
            // 
            // frmmatakuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpdatamahasiswa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmatakuliah";
            this.Text = "frmmatakuliah";
            this.Load += new System.EventHandler(this.frmmatakuliah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpdatamahasiswa.ResumeLayout(false);
            this.gpdatamahasiswa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpdatamahasiswa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmnamamk;
        private System.Windows.Forms.TextBox txtsks;
        private System.Windows.Forms.TextBox txtkdnilai;
        private System.Windows.Forms.TextBox txtkodemk;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnmkgetdata;
        private DevComponents.DotNetBar.ButtonX btnmkdelete;
        private DevComponents.DotNetBar.ButtonX btnmkupdate;
        private DevComponents.DotNetBar.ButtonX btnmksave;
        private DevComponents.DotNetBar.ButtonX btnmknew;
    }
}