namespace AppPerkuliahan
{
    partial class FormKdMatkul
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
            this.btngetdata = new DevComponents.DotNetBar.ButtonX();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnnew = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbnamamk = new System.Windows.Forms.ComboBox();
            this.txtsks = new System.Windows.Forms.TextBox();
            this.txtkdmk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.grbDataKuliah = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grbDataKuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetdata
            // 
            this.btngetdata.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btngetdata.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btngetdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetdata.Location = new System.Drawing.Point(6, 145);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(117, 23);
            this.btngetdata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btngetdata.TabIndex = 6;
            this.btngetdata.Text = "GET DATA";
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(7, 113);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(117, 23);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 5;
            this.btndel.Text = "DELETE";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(7, 82);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 23);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(7, 51);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(117, 23);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "SAVE";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(7, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(117, 23);
            this.btnnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "NEW";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngetdata);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(446, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // cmbnamamk
            // 
            this.cmbnamamk.FormattingEnabled = true;
            this.cmbnamamk.Items.AddRange(new object[] {
            "Algoritma Pemrograman",
            "Teknik Digital",
            "Mikroprosessor",
            "Multimedia",
            "Teknik Animasi"});
            this.cmbnamamk.Location = new System.Drawing.Point(201, 52);
            this.cmbnamamk.Name = "cmbnamamk";
            this.cmbnamamk.Size = new System.Drawing.Size(213, 21);
            this.cmbnamamk.TabIndex = 1;
            // 
            // txtsks
            // 
            this.txtsks.Location = new System.Drawing.Point(201, 113);
            this.txtsks.Name = "txtsks";
            this.txtsks.Size = new System.Drawing.Size(213, 20);
            this.txtsks.TabIndex = 3;
            // 
            // txtkdmk
            // 
            this.txtkdmk.Location = new System.Drawing.Point(201, 20);
            this.txtkdmk.Name = "txtkdmk";
            this.txtkdmk.Size = new System.Drawing.Size(123, 20);
            this.txtkdmk.TabIndex = 0;
            this.txtkdmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkdmk_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "SKS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama MK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode MK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kelola Data MataKuliah";
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(201, 83);
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(213, 20);
            this.txtnilai.TabIndex = 2;
            // 
            // grbDataKuliah
            // 
            this.grbDataKuliah.Controls.Add(this.cmbnamamk);
            this.grbDataKuliah.Controls.Add(this.txtsks);
            this.grbDataKuliah.Controls.Add(this.txtnilai);
            this.grbDataKuliah.Controls.Add(this.txtkdmk);
            this.grbDataKuliah.Controls.Add(this.label5);
            this.grbDataKuliah.Controls.Add(this.label4);
            this.grbDataKuliah.Controls.Add(this.label3);
            this.grbDataKuliah.Controls.Add(this.label2);
            this.grbDataKuliah.Enabled = false;
            this.grbDataKuliah.Location = new System.Drawing.Point(11, 85);
            this.grbDataKuliah.Name = "grbDataKuliah";
            this.grbDataKuliah.Size = new System.Drawing.Size(428, 189);
            this.grbDataKuliah.TabIndex = 4;
            this.grbDataKuliah.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPerkuliahan.Properties.Resources._006767_3d_transparent_glass_icon_arrows_arrows_rotated;
            this.pictureBox1.Location = new System.Drawing.Point(506, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormKdMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDataKuliah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormKdMatkul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKdMatkul";
            this.Load += new System.EventHandler(this.FormKdMatkul_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKdMatkul_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.grbDataKuliah.ResumeLayout(false);
            this.grbDataKuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btngetdata;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btnnew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbnamamk;
        private System.Windows.Forms.TextBox txtsks;
        private System.Windows.Forms.TextBox txtkdmk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.GroupBox grbDataKuliah;
    }
}