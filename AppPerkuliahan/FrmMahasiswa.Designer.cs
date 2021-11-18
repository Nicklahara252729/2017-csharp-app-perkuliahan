namespace AppPerkuliahan
{
    partial class FrmMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMahasiswa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndmgetdata = new DevComponents.DotNetBar.ButtonX();
            this.btndmdelete = new DevComponents.DotNetBar.ButtonX();
            this.btndmupdate = new DevComponents.DotNetBar.ButtonX();
            this.btndmsave = new DevComponents.DotNetBar.ButtonX();
            this.btndmnew = new DevComponents.DotNetBar.ButtonX();
            this.gpdatamahasiswa = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbjurusan = new System.Windows.Forms.ComboBox();
            this.txtmatkul = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gpdatamahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndmgetdata);
            this.groupBox1.Controls.Add(this.btndmdelete);
            this.groupBox1.Controls.Add(this.btndmupdate);
            this.groupBox1.Controls.Add(this.btndmsave);
            this.groupBox1.Controls.Add(this.btndmnew);
            this.groupBox1.Location = new System.Drawing.Point(495, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btndmgetdata
            // 
            this.btndmgetdata.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndmgetdata.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndmgetdata.Location = new System.Drawing.Point(9, 184);
            this.btndmgetdata.Name = "btndmgetdata";
            this.btndmgetdata.Size = new System.Drawing.Size(185, 32);
            this.btndmgetdata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndmgetdata.TabIndex = 4;
            this.btndmgetdata.Text = "GET DATA";
            this.btndmgetdata.Click += new System.EventHandler(this.btndmgetdata_Click);
            // 
            // btndmdelete
            // 
            this.btndmdelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndmdelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndmdelete.Location = new System.Drawing.Point(9, 148);
            this.btndmdelete.Name = "btndmdelete";
            this.btndmdelete.Size = new System.Drawing.Size(185, 30);
            this.btndmdelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndmdelete.TabIndex = 3;
            this.btndmdelete.Text = "DELETE";
            this.btndmdelete.Click += new System.EventHandler(this.btndmdelete_Click);
            // 
            // btndmupdate
            // 
            this.btndmupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndmupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndmupdate.Location = new System.Drawing.Point(9, 107);
            this.btndmupdate.Name = "btndmupdate";
            this.btndmupdate.Size = new System.Drawing.Size(185, 33);
            this.btndmupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndmupdate.TabIndex = 2;
            this.btndmupdate.Text = "UPDATE";
            this.btndmupdate.Click += new System.EventHandler(this.btndmupdate_Click);
            // 
            // btndmsave
            // 
            this.btndmsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndmsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndmsave.Location = new System.Drawing.Point(9, 65);
            this.btndmsave.Name = "btndmsave";
            this.btndmsave.Size = new System.Drawing.Size(185, 36);
            this.btndmsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndmsave.TabIndex = 1;
            this.btndmsave.Text = "SAVE";
            this.btndmsave.Click += new System.EventHandler(this.btndmsave_Click);
            // 
            // btndmnew
            // 
            this.btndmnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndmnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndmnew.Location = new System.Drawing.Point(9, 20);
            this.btndmnew.Name = "btndmnew";
            this.btndmnew.Size = new System.Drawing.Size(185, 38);
            this.btndmnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndmnew.TabIndex = 0;
            this.btndmnew.Text = "NEW";
            this.btndmnew.Click += new System.EventHandler(this.btndmnew_Click);
            // 
            // gpdatamahasiswa
            // 
            this.gpdatamahasiswa.Controls.Add(this.label5);
            this.gpdatamahasiswa.Controls.Add(this.label4);
            this.gpdatamahasiswa.Controls.Add(this.label3);
            this.gpdatamahasiswa.Controls.Add(this.label2);
            this.gpdatamahasiswa.Controls.Add(this.cmbjurusan);
            this.gpdatamahasiswa.Controls.Add(this.txtmatkul);
            this.gpdatamahasiswa.Controls.Add(this.txtnama);
            this.gpdatamahasiswa.Controls.Add(this.txtnim);
            this.gpdatamahasiswa.Enabled = false;
            this.gpdatamahasiswa.Location = new System.Drawing.Point(6, 40);
            this.gpdatamahasiswa.Name = "gpdatamahasiswa";
            this.gpdatamahasiswa.Size = new System.Drawing.Size(483, 221);
            this.gpdatamahasiswa.TabIndex = 1;
            this.gpdatamahasiswa.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "KDMATKUL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "JURUSAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIM";
            // 
            // cmbjurusan
            // 
            this.cmbjurusan.FormattingEnabled = true;
            this.cmbjurusan.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Elektro",
            "Teknik Mesin",
            "Akuntansi",
            "Hubungan Internasional"});
            this.cmbjurusan.Location = new System.Drawing.Point(177, 115);
            this.cmbjurusan.Name = "cmbjurusan";
            this.cmbjurusan.Size = new System.Drawing.Size(237, 21);
            this.cmbjurusan.TabIndex = 3;
            // 
            // txtmatkul
            // 
            this.txtmatkul.Location = new System.Drawing.Point(177, 155);
            this.txtmatkul.Multiline = true;
            this.txtmatkul.Name = "txtmatkul";
            this.txtmatkul.Size = new System.Drawing.Size(237, 29);
            this.txtmatkul.TabIndex = 2;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(177, 72);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(237, 29);
            this.txtnama.TabIndex = 1;
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(177, 28);
            this.txtnim.Multiline = true;
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(237, 29);
            this.txtnim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kelola Data Mahasiswa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpdatamahasiswa);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMahasiswa";
            this.Text = "FrmMahasiswa";
            this.Load += new System.EventHandler(this.FrmMahasiswa_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpdatamahasiswa.ResumeLayout(false);
            this.gpdatamahasiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpdatamahasiswa;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btndmgetdata;
        private DevComponents.DotNetBar.ButtonX btndmdelete;
        private DevComponents.DotNetBar.ButtonX btndmupdate;
        private DevComponents.DotNetBar.ButtonX btndmsave;
        private DevComponents.DotNetBar.ButtonX btndmnew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbjurusan;
        private System.Windows.Forms.TextBox txtmatkul;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}