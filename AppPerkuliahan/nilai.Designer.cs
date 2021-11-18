namespace AppPerkuliahan
{
    partial class nilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nilai));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpdatanilai = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbkodemk = new System.Windows.Forms.ComboBox();
            this.txtdosen = new System.Windows.Forms.TextBox();
            this.txtnilai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndmgetdata = new DevComponents.DotNetBar.ButtonX();
            this.btndmdelete = new DevComponents.DotNetBar.ButtonX();
            this.btndmupdate = new DevComponents.DotNetBar.ButtonX();
            this.btndmsave = new DevComponents.DotNetBar.ButtonX();
            this.btndmnew = new DevComponents.DotNetBar.ButtonX();
            this.cmbkodenim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpdatanilai.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kelola Data Nilai";
            // 
            // gpdatanilai
            // 
            this.gpdatanilai.Controls.Add(this.cmbkodenim);
            this.gpdatanilai.Controls.Add(this.label5);
            this.gpdatanilai.Controls.Add(this.label4);
            this.gpdatanilai.Controls.Add(this.label3);
            this.gpdatanilai.Controls.Add(this.label2);
            this.gpdatanilai.Controls.Add(this.cmbkodemk);
            this.gpdatanilai.Controls.Add(this.txtdosen);
            this.gpdatanilai.Controls.Add(this.txtnilai);
            this.gpdatanilai.Enabled = false;
            this.gpdatanilai.Location = new System.Drawing.Point(9, 43);
            this.gpdatanilai.Name = "gpdatanilai";
            this.gpdatanilai.Size = new System.Drawing.Size(483, 221);
            this.gpdatanilai.TabIndex = 7;
            this.gpdatanilai.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kode Dosen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kode MK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode NIM";
            // 
            // cmbkodemk
            // 
            this.cmbkodemk.FormattingEnabled = true;
            this.cmbkodemk.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Elektro",
            "Teknik Mesin",
            "Akuntansi",
            "Hubungan Internasional"});
            this.cmbkodemk.Location = new System.Drawing.Point(177, 83);
            this.cmbkodemk.Name = "cmbkodemk";
            this.cmbkodemk.Size = new System.Drawing.Size(237, 21);
            this.cmbkodemk.TabIndex = 3;
            // 
            // txtdosen
            // 
            this.txtdosen.Location = new System.Drawing.Point(177, 155);
            this.txtdosen.Multiline = true;
            this.txtdosen.Name = "txtdosen";
            this.txtdosen.Size = new System.Drawing.Size(237, 29);
            this.txtdosen.TabIndex = 2;
            // 
            // txtnilai
            // 
            this.txtnilai.Location = new System.Drawing.Point(177, 116);
            this.txtnilai.Multiline = true;
            this.txtnilai.Name = "txtnilai";
            this.txtnilai.Size = new System.Drawing.Size(237, 29);
            this.txtnilai.TabIndex = 1;
            this.txtnilai.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndmgetdata);
            this.groupBox1.Controls.Add(this.btndmdelete);
            this.groupBox1.Controls.Add(this.btndmupdate);
            this.groupBox1.Controls.Add(this.btndmsave);
            this.groupBox1.Controls.Add(this.btndmnew);
            this.groupBox1.Location = new System.Drawing.Point(498, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 222);
            this.groupBox1.TabIndex = 6;
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
            // 
            // cmbkodenim
            // 
            this.cmbkodenim.FormattingEnabled = true;
            this.cmbkodenim.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Elektro",
            "Teknik Mesin",
            "Akuntansi",
            "Hubungan Internasional"});
            this.cmbkodenim.Location = new System.Drawing.Point(177, 39);
            this.cmbkodenim.Name = "cmbkodenim";
            this.cmbkodenim.Size = new System.Drawing.Size(237, 21);
            this.cmbkodenim.TabIndex = 10;
            // 
            // nilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 273);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpdatanilai);
            this.Controls.Add(this.groupBox1);
            this.Name = "nilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nilai";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpdatanilai.ResumeLayout(false);
            this.gpdatanilai.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpdatanilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbkodemk;
        private System.Windows.Forms.TextBox txtdosen;
        private System.Windows.Forms.TextBox txtnilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btndmgetdata;
        private DevComponents.DotNetBar.ButtonX btndmdelete;
        private DevComponents.DotNetBar.ButtonX btndmupdate;
        private DevComponents.DotNetBar.ButtonX btndmsave;
        private DevComponents.DotNetBar.ButtonX btndmnew;
        private System.Windows.Forms.ComboBox cmbkodenim;
    }
}