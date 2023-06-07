namespace UrunStokTakip
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(113, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 140);
            this.pictureEdit1.TabIndex = 19;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(236, 337);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(31, 335);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(90, 20);
            this.checkBeniHatirla.TabIndex = 3;
            // 
            // textSifre
            // 
            this.textSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Location = new System.Drawing.Point(31, 282);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(301, 27);
            this.textSifre.TabIndex = 2;
            this.textSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            // 
            // textKullaniciAdi
            // 
            this.textKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullaniciAdi.Location = new System.Drawing.Point(31, 219);
            this.textKullaniciAdi.Name = "textKullaniciAdi";
            this.textKullaniciAdi.Size = new System.Drawing.Size(301, 27);
            this.textKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // BtnKapat
            // 
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKapat.ImageOptions.SvgImage")));
            this.BtnKapat.Location = new System.Drawing.Point(201, 399);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(131, 45);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BtnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Appearance.Options.UseForeColor = true;
            this.BtnGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGiris.ImageOptions.SvgImage")));
            this.BtnGiris.Location = new System.Drawing.Point(31, 399);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(135, 45);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click_1);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(365, 490);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textKullaniciAdi);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
    }
}