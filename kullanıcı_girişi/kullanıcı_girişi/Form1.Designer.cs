
namespace kullanıcı_girişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_form1_kaydol = new System.Windows.Forms.Button();
            this.btn_form1_giris_yap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxInstagram = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxYoutube = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_form1_kaydol
            // 
            this.btn_form1_kaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_form1_kaydol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form1_kaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_form1_kaydol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_form1_kaydol.Location = new System.Drawing.Point(51, 322);
            this.btn_form1_kaydol.Name = "btn_form1_kaydol";
            this.btn_form1_kaydol.Size = new System.Drawing.Size(230, 33);
            this.btn_form1_kaydol.TabIndex = 7;
            this.btn_form1_kaydol.Text = "Kaydol";
            this.btn_form1_kaydol.UseVisualStyleBackColor = false;
            this.btn_form1_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // btn_form1_giris_yap
            // 
            this.btn_form1_giris_yap.BackColor = System.Drawing.Color.Cyan;
            this.btn_form1_giris_yap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_form1_giris_yap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_form1_giris_yap.Location = new System.Drawing.Point(51, 267);
            this.btn_form1_giris_yap.Name = "btn_form1_giris_yap";
            this.btn_form1_giris_yap.Size = new System.Drawing.Size(229, 33);
            this.btn_form1_giris_yap.TabIndex = 6;
            this.btn_form1_giris_yap.Text = "Giriş yap";
            this.btn_form1_giris_yap.UseVisualStyleBackColor = false;
            this.btn_form1_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_username.Location = new System.Drawing.Point(98, 182);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(182, 22);
            this.txt_username.TabIndex = 10;
            this.txt_username.Text = "Kullanıcı Adı";
            this.txt_username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_username_MouseClick);
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.MouseEnter += new System.EventHandler(this.txt_username_MouseEnter);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_password.Location = new System.Drawing.Point(98, 225);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(182, 22);
            this.txt_password.TabIndex = 11;
            this.txt_password.Text = "Şifre";
            this.txt_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_password_MouseClick);
            this.txt_password.MouseEnter += new System.EventHandler(this.txt_password_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(51, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(98, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(98, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 1);
            this.panel2.TabIndex = 15;
            // 
            // pictureBoxInstagram
            // 
            this.pictureBoxInstagram.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInstagram.Image")));
            this.pictureBoxInstagram.Location = new System.Drawing.Point(65, 388);
            this.pictureBoxInstagram.Name = "pictureBoxInstagram";
            this.pictureBoxInstagram.Size = new System.Drawing.Size(62, 44);
            this.pictureBoxInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstagram.TabIndex = 16;
            this.pictureBoxInstagram.TabStop = false;
            this.pictureBoxInstagram.Click += new System.EventHandler(this.pictureBoxInstagram_Click);
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebook.Image")));
            this.pictureBoxFacebook.Location = new System.Drawing.Point(150, 392);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(45, 40);
            this.pictureBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebook.TabIndex = 17;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // pictureBoxYoutube
            // 
            this.pictureBoxYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYoutube.Image")));
            this.pictureBoxYoutube.Location = new System.Drawing.Point(224, 392);
            this.pictureBoxYoutube.Name = "pictureBoxYoutube";
            this.pictureBoxYoutube.Size = new System.Drawing.Size(56, 40);
            this.pictureBoxYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYoutube.TabIndex = 18;
            this.pictureBoxYoutube.TabStop = false;
            this.pictureBoxYoutube.Click += new System.EventHandler(this.pictureBoxYoutube_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(300, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(331, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBoxYoutube);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.pictureBoxInstagram);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_form1_kaydol);
            this.Controls.Add(this.btn_form1_giris_yap);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYoutube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form1_kaydol;
        private System.Windows.Forms.Button btn_form1_giris_yap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxInstagram;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxYoutube;
        private System.Windows.Forms.Button btnClose;
    }
}

