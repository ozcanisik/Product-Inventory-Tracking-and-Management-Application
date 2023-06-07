namespace UrunStokTakip.Formlar
{
    partial class FormDepartmanIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartmanIslem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.buttonListele = new DevExpress.XtraEditors.SimpleButton();
            this.buttonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSil = new DevExpress.XtraEditors.SimpleButton();
            this.textAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textDepartman = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelToplamDepartman = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelEnFazlaCalisan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelEnAzCalisan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1291, 600);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.Bisque;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.Info;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Appearance.BackColor = System.Drawing.Color.MintCream;
            this.buttonKaydet.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.buttonKaydet.Appearance.Options.UseBackColor = true;
            this.buttonKaydet.Appearance.Options.UseBorderColor = true;
            this.buttonKaydet.Appearance.Options.UseFont = true;
            this.buttonKaydet.Appearance.Options.UseForeColor = true;
            this.buttonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.ImageOptions.Image")));
            this.buttonKaydet.Location = new System.Drawing.Point(269, 436);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(169, 48);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(231, 144);
            this.textID.Name = "textID";
            this.textID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Properties.Appearance.Options.UseFont = true;
            this.textID.Size = new System.Drawing.Size(247, 26);
            this.textID.TabIndex = 34;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(186, 147);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 19);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "ID:";
            // 
            // buttonListele
            // 
            this.buttonListele.Appearance.BackColor = System.Drawing.Color.Beige;
            this.buttonListele.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListele.Appearance.Options.UseBackColor = true;
            this.buttonListele.Appearance.Options.UseFont = true;
            this.buttonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonListele.ImageOptions.Image")));
            this.buttonListele.Location = new System.Drawing.Point(269, 630);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(169, 48);
            this.buttonListele.TabIndex = 6;
            this.buttonListele.Text = "Listele";
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuncelle.Appearance.Options.UseBackColor = true;
            this.buttonGuncelle.Appearance.Options.UseFont = true;
            this.buttonGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.ImageOptions.Image")));
            this.buttonGuncelle.Location = new System.Drawing.Point(269, 565);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(169, 48);
            this.buttonGuncelle.TabIndex = 5;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.buttonSil.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.buttonSil.Appearance.Options.UseBackColor = true;
            this.buttonSil.Appearance.Options.UseBorderColor = true;
            this.buttonSil.Appearance.Options.UseFont = true;
            this.buttonSil.Appearance.Options.UseForeColor = true;
            this.buttonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.ImageOptions.Image")));
            this.buttonSil.Location = new System.Drawing.Point(269, 500);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(169, 48);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(231, 214);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.textAciklama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAciklama.Properties.Appearance.Options.UseBackColor = true;
            this.textAciklama.Properties.Appearance.Options.UseFont = true;
            this.textAciklama.Size = new System.Drawing.Size(247, 197);
            this.textAciklama.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(139, 211);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 19);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Açıklama:";
            // 
            // textDepartman
            // 
            this.textDepartman.Location = new System.Drawing.Point(231, 176);
            this.textDepartman.Name = "textDepartman";
            this.textDepartman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepartman.Properties.Appearance.Options.UseFont = true;
            this.textDepartman.Size = new System.Drawing.Size(247, 26);
            this.textDepartman.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(100, 179);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 19);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Departman Ad:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.buttonTemizle);
            this.groupControl1.Controls.Add(this.buttonKaydet);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.buttonListele);
            this.groupControl1.Controls.Add(this.buttonGuncelle);
            this.groupControl1.Controls.Add(this.buttonSil);
            this.groupControl1.Controls.Add(this.textAciklama);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textDepartman);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1300, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 841);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "DEPARTMAN İŞLEM";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Appearance.BackColor = System.Drawing.Color.Azure;
            this.buttonTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemizle.Appearance.Options.UseBackColor = true;
            this.buttonTemizle.Appearance.Options.UseFont = true;
            this.buttonTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.ImageOptions.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(269, 697);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(169, 48);
            this.buttonTemizle.TabIndex = 7;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.labelToplamDepartman);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Location = new System.Drawing.Point(3, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 238);
            this.panel1.TabIndex = 21;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(292, 72);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(128, 132);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelToplamDepartman
            // 
            this.labelToplamDepartman.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToplamDepartman.Appearance.Options.UseFont = true;
            this.labelToplamDepartman.Location = new System.Drawing.Point(46, 126);
            this.labelToplamDepartman.Name = "labelToplamDepartman";
            this.labelToplamDepartman.Size = new System.Drawing.Size(17, 39);
            this.labelToplamDepartman.TabIndex = 1;
            this.labelToplamDepartman.Text = "0";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(24, 18);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(271, 29);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Toplam Departman Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureEdit2);
            this.panel2.Controls.Add(this.labelEnFazlaCalisan);
            this.panel2.Controls.Add(this.labelControl11);
            this.panel2.Location = new System.Drawing.Point(436, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 238);
            this.panel2.TabIndex = 22;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(292, 72);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(128, 132);
            this.pictureEdit2.TabIndex = 2;
            // 
            // labelEnFazlaCalisan
            // 
            this.labelEnFazlaCalisan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnFazlaCalisan.Appearance.Options.UseFont = true;
            this.labelEnFazlaCalisan.Location = new System.Drawing.Point(20, 126);
            this.labelEnFazlaCalisan.Name = "labelEnFazlaCalisan";
            this.labelEnFazlaCalisan.Size = new System.Drawing.Size(10, 23);
            this.labelEnFazlaCalisan.TabIndex = 1;
            this.labelEnFazlaCalisan.Text = "0";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(104, 8);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(232, 58);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "En Fazla Çalışanı Olan \r\n       Departman";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureEdit3);
            this.panel3.Controls.Add(this.labelEnAzCalisan);
            this.panel3.Controls.Add(this.labelControl15);
            this.panel3.Location = new System.Drawing.Point(869, 617);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 238);
            this.panel3.TabIndex = 23;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(292, 72);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(128, 132);
            this.pictureEdit3.TabIndex = 2;
            // 
            // labelEnAzCalisan
            // 
            this.labelEnAzCalisan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnAzCalisan.Appearance.Options.UseFont = true;
            this.labelEnAzCalisan.Location = new System.Drawing.Point(20, 126);
            this.labelEnAzCalisan.Name = "labelEnAzCalisan";
            this.labelEnAzCalisan.Size = new System.Drawing.Size(10, 23);
            this.labelEnAzCalisan.TabIndex = 1;
            this.labelEnAzCalisan.Text = "0";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(116, 8);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(202, 58);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "En Az Çalışanı Olan \r\n     Departman";
            // 
            // FormDepartmanIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormDepartmanIslem";
            this.Text = "Departman İşlemleri";
            this.Load += new System.EventHandler(this.FormDepartmanIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton buttonKaydet;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton buttonListele;
        private DevExpress.XtraEditors.SimpleButton buttonGuncelle;
        private DevExpress.XtraEditors.SimpleButton buttonSil;
        private DevExpress.XtraEditors.MemoEdit textAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelToplamDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelEnFazlaCalisan;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl labelEnAzCalisan;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton buttonTemizle;
    }
}