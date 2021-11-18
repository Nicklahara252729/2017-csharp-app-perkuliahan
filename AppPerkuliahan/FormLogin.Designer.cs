namespace AppPerkuliahan
{
    partial class FormLogin
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
            this.spmain = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcclient = new System.Windows.Forms.PictureBox();
            this.pcadmin = new System.Windows.Forms.PictureBox();
            this.spadmin = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btncancel = new DevComponents.DotNetBar.ButtonX();
            this.btnlogin = new DevComponents.DotNetBar.ButtonX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.spclient = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.pcthome = new System.Windows.Forms.PictureBox();
            this.btncancel1 = new DevComponents.DotNetBar.ButtonX();
            this.btnloginclient = new DevComponents.DotNetBar.ButtonX();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpassclient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcadmin)).BeginInit();
            this.spadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.spclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcthome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spmain
            // 
            this.spmain.Controls.Add(this.label2);
            this.spmain.Controls.Add(this.label3);
            this.spmain.Controls.Add(this.label1);
            this.spmain.Controls.Add(this.pcclient);
            this.spmain.Controls.Add(this.pcadmin);
            this.spmain.Location = new System.Drawing.Point(3, 3);
            this.spmain.Name = "spmain";
            this.spmain.Size = new System.Drawing.Size(603, 459);
            this.spmain.SlideOutButtonVisible = false;
            this.spmain.TabIndex = 0;
            this.spmain.Text = "slidePanel1";
            this.spmain.UsesBlockingAnimation = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SELECT ACCESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMIN";
            // 
            // pcclient
            // 
            this.pcclient.BackgroundImage = global::AppPerkuliahan.Properties.Resources.boy;
            this.pcclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcclient.Location = new System.Drawing.Point(301, 187);
            this.pcclient.Name = "pcclient";
            this.pcclient.Size = new System.Drawing.Size(138, 149);
            this.pcclient.TabIndex = 1;
            this.pcclient.TabStop = false;
            this.pcclient.Click += new System.EventHandler(this.pcclient_Click);
            // 
            // pcadmin
            // 
            this.pcadmin.BackgroundImage = global::AppPerkuliahan.Properties.Resources.administrator_icon_5154;
            this.pcadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcadmin.Location = new System.Drawing.Point(136, 187);
            this.pcadmin.Name = "pcadmin";
            this.pcadmin.Size = new System.Drawing.Size(138, 149);
            this.pcadmin.TabIndex = 0;
            this.pcadmin.TabStop = false;
            this.pcadmin.Click += new System.EventHandler(this.pcadmin_Click);
            // 
            // spadmin
            // 
            this.spadmin.AnimationTime = 100;
            this.spadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spadmin.Controls.Add(this.pictureBox3);
            this.spadmin.Controls.Add(this.btncancel);
            this.spadmin.Controls.Add(this.btnlogin);
            this.spadmin.Controls.Add(this.label7);
            this.spadmin.Controls.Add(this.txtpass);
            this.spadmin.Controls.Add(this.label4);
            this.spadmin.Controls.Add(this.txtusername);
            this.spadmin.Controls.Add(this.label5);
            this.spadmin.Controls.Add(this.label6);
            this.spadmin.Controls.Add(this.pictureBox2);
            this.spadmin.Location = new System.Drawing.Point(3, 3);
            this.spadmin.Name = "spadmin";
            this.spadmin.Size = new System.Drawing.Size(603, 459);
            this.spadmin.SlideOutButtonVisible = false;
            this.spadmin.TabIndex = 1;
            this.spadmin.Text = "slidePanel1";
            this.spadmin.UsesBlockingAnimation = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::AppPerkuliahan.Properties.Resources.unnamed__1_;
            this.pictureBox3.Location = new System.Drawing.Point(9, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancel.Location = new System.Drawing.Point(281, 304);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(101, 31);
            this.btncancel.StopPulseOnMouseOver = false;
            this.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btncancel.Symbol = "";
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "CANCEL";
            this.btncancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnlogin
            // 
            this.btnlogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnlogin.Location = new System.Drawing.Point(388, 304);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(101, 31);
            this.btnlogin.StopPulseOnMouseOver = false;
            this.btnlogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnlogin.Symbol = "";
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(280, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "PASSWORD";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(281, 270);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(208, 20);
            this.txtpass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(280, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "USERNAME";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(281, 215);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(208, 20);
            this.txtusername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "ADMINISTRATOR LOGIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(163, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "ADMIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AppPerkuliahan.Properties.Resources.administrator_icon_5154;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(136, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 149);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // spclient
            // 
            this.spclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.spclient.Controls.Add(this.pcthome);
            this.spclient.Controls.Add(this.btncancel1);
            this.spclient.Controls.Add(this.btnloginclient);
            this.spclient.Controls.Add(this.label8);
            this.spclient.Controls.Add(this.txtpassclient);
            this.spclient.Controls.Add(this.label9);
            this.spclient.Controls.Add(this.txtnim);
            this.spclient.Controls.Add(this.label10);
            this.spclient.Controls.Add(this.label11);
            this.spclient.Controls.Add(this.pictureBox1);
            this.spclient.Location = new System.Drawing.Point(3, 3);
            this.spclient.Name = "spclient";
            this.spclient.Size = new System.Drawing.Size(603, 459);
            this.spclient.SlideOutButtonVisible = false;
            this.spclient.TabIndex = 8;
            this.spclient.Text = "slidePanel2";
            this.spclient.UsesBlockingAnimation = false;
            // 
            // pcthome
            // 
            this.pcthome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcthome.Image = global::AppPerkuliahan.Properties.Resources.unnamed__1_;
            this.pcthome.Location = new System.Drawing.Point(9, 9);
            this.pcthome.Name = "pcthome";
            this.pcthome.Size = new System.Drawing.Size(46, 49);
            this.pcthome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcthome.TabIndex = 11;
            this.pcthome.TabStop = false;
            this.pcthome.Click += new System.EventHandler(this.pcthome_Click);
            // 
            // btncancel1
            // 
            this.btncancel1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncancel1.Location = new System.Drawing.Point(281, 296);
            this.btncancel1.Name = "btncancel1";
            this.btncancel1.Size = new System.Drawing.Size(101, 31);
            this.btncancel1.StopPulseOnMouseOver = false;
            this.btncancel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btncancel1.Symbol = "";
            this.btncancel1.TabIndex = 10;
            this.btncancel1.Text = "CANCEL";
            this.btncancel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnloginclient
            // 
            this.btnloginclient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnloginclient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnloginclient.Location = new System.Drawing.Point(388, 296);
            this.btnloginclient.Name = "btnloginclient";
            this.btnloginclient.Size = new System.Drawing.Size(101, 31);
            this.btnloginclient.StopPulseOnMouseOver = false;
            this.btnloginclient.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnloginclient.Symbol = "";
            this.btnloginclient.TabIndex = 9;
            this.btnloginclient.Text = "LOG IN";
            this.btnloginclient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnloginclient.Click += new System.EventHandler(this.btncancel2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(280, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "PASSWORD";
            // 
            // txtpassclient
            // 
            this.txtpassclient.Location = new System.Drawing.Point(281, 270);
            this.txtpassclient.Name = "txtpassclient";
            this.txtpassclient.PasswordChar = '*';
            this.txtpassclient.Size = new System.Drawing.Size(208, 20);
            this.txtpassclient.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(280, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "NIM";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(281, 215);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(208, 20);
            this.txtnim.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(251, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "CLIENT LOGIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(163, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "CLIENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::AppPerkuliahan.Properties.Resources.boy;
            this.pictureBox1.Location = new System.Drawing.Point(136, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 462);
            this.Controls.Add(this.spclient);
            this.Controls.Add(this.spadmin);
            this.Controls.Add(this.spmain);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.spclient_Load);
            this.spmain.ResumeLayout(false);
            this.spmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcadmin)).EndInit();
            this.spadmin.ResumeLayout(false);
            this.spadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.spclient.ResumeLayout(false);
            this.spclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcthome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SlidePanel spmain;
        private System.Windows.Forms.PictureBox pcadmin;
        private System.Windows.Forms.PictureBox pcclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.SlidePanel spadmin;
        private DevComponents.DotNetBar.ButtonX btnlogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.Controls.SlidePanel spclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpassclient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btncancel;
        private System.Windows.Forms.PictureBox pcthome;
        private DevComponents.DotNetBar.ButtonX btncancel1;
        private DevComponents.DotNetBar.ButtonX btnloginclient;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}