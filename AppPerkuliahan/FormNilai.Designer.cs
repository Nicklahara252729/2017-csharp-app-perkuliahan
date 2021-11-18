namespace AppPerkuliahan
{
    partial class FormNilai
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
            this.cmbkdmk = new System.Windows.Forms.ComboBox();
            this.txtkddosen = new System.Windows.Forms.TextBox();
            this.txtkdnilai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngetdata = new DevComponents.DotNetBar.ButtonX();
            this.btnnew = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.grbdatamahasiswa = new System.Windows.Forms.GroupBox();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.cmbnim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grbdatamahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbkdmk
            // 
            this.cmbkdmk.FormattingEnabled = true;
            this.cmbkdmk.Location = new System.Drawing.Point(201, 62);
            this.cmbkdmk.Name = "cmbkdmk";
            this.cmbkdmk.Size = new System.Drawing.Size(213, 21);
            this.cmbkdmk.TabIndex = 9;
            // 
            // txtkddosen
            // 
            this.txtkddosen.Location = new System.Drawing.Point(201, 125);
            this.txtkddosen.Name = "txtkddosen";
            this.txtkddosen.Size = new System.Drawing.Size(213, 20);
            this.txtkddosen.TabIndex = 7;
            // 
            // txtkdnilai
            // 
            this.txtkdnilai.Location = new System.Drawing.Point(201, 28);
            this.txtkdnilai.Name = "txtkdnilai";
            this.txtkdnilai.Size = new System.Drawing.Size(123, 20);
            this.txtkdnilai.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "KODE DOSEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "NILAI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "KODEMK";
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
            this.btndel.Text = "&DELETE";
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
            this.btnupdate.Text = "&UPDATE";
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
            this.btnsave.Text = "&SAVE";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "KODE NILAI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngetdata);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Location = new System.Drawing.Point(448, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 189);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
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
            this.btnnew.Text = "&NEW";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kelola Data Nilai";
            // 
            // grbdatamahasiswa
            // 
            this.grbdatamahasiswa.Controls.Add(this.txtnilai);
            this.grbdatamahasiswa.Controls.Add(this.cmbnim);
            this.grbdatamahasiswa.Controls.Add(this.label6);
            this.grbdatamahasiswa.Controls.Add(this.cmbkdmk);
            this.grbdatamahasiswa.Controls.Add(this.txtkddosen);
            this.grbdatamahasiswa.Controls.Add(this.txtkdnilai);
            this.grbdatamahasiswa.Controls.Add(this.label5);
            this.grbdatamahasiswa.Controls.Add(this.label4);
            this.grbdatamahasiswa.Controls.Add(this.label3);
            this.grbdatamahasiswa.Controls.Add(this.label2);
            this.grbdatamahasiswa.Enabled = false;
            this.grbdatamahasiswa.Location = new System.Drawing.Point(13, 87);
            this.grbdatamahasiswa.Name = "grbdatamahasiswa";
            this.grbdatamahasiswa.Size = new System.Drawing.Size(428, 189);
            this.grbdatamahasiswa.TabIndex = 4;
            this.grbdatamahasiswa.TabStop = false;
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(201, 94);
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(213, 20);
            this.txtnilai.TabIndex = 12;
            // 
            // cmbnim
            // 
            this.cmbnim.FormattingEnabled = true;
            this.cmbnim.Location = new System.Drawing.Point(201, 151);
            this.cmbnim.Name = "cmbnim";
            this.cmbnim.Size = new System.Drawing.Size(213, 21);
            this.cmbnim.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "NIM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPerkuliahan.Properties.Resources._006767_3d_transparent_glass_icon_arrows_arrows_rotated;
            this.pictureBox1.Location = new System.Drawing.Point(508, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbdatamahasiswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbdatamahasiswa.ResumeLayout(false);
            this.grbdatamahasiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbkdmk;
        private System.Windows.Forms.TextBox txtkddosen;
        private System.Windows.Forms.TextBox txtkdnilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btngetdata;
        private DevComponents.DotNetBar.ButtonX btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbdatamahasiswa;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.ComboBox cmbnim;
        private System.Windows.Forms.Label label6;
    }
}