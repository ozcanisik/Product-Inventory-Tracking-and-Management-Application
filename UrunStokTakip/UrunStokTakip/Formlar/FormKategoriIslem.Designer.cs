namespace UrunStokTakip.Formlar
{
    partial class FormKategoriIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriIslem));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.buttonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.buttonListele = new DevExpress.XtraEditors.SimpleButton();
            this.buttonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.textKategori = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1291, 319);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.buttonKaydet.Location = new System.Drawing.Point(269, 338);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(169, 48);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(231, 157);
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
            this.labelControl8.Location = new System.Drawing.Point(146, 160);
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
            this.buttonListele.Location = new System.Drawing.Point(269, 532);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(169, 48);
            this.buttonListele.TabIndex = 5;
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
            this.buttonGuncelle.Location = new System.Drawing.Point(269, 467);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(169, 48);
            this.buttonGuncelle.TabIndex = 4;
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
            this.buttonSil.Location = new System.Drawing.Point(269, 402);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(169, 48);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(146, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 19);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Kategori:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.buttonTemizle);
            this.groupControl1.Controls.Add(this.textKategori);
            this.groupControl1.Controls.Add(this.buttonKaydet);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.buttonListele);
            this.groupControl1.Controls.Add(this.buttonGuncelle);
            this.groupControl1.Controls.Add(this.buttonSil);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(1300, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 837);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "KATEGORİ İŞLEM";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Appearance.BackColor = System.Drawing.Color.Azure;
            this.buttonTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemizle.Appearance.Options.UseBackColor = true;
            this.buttonTemizle.Appearance.Options.UseFont = true;
            this.buttonTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.ImageOptions.Image")));
            this.buttonTemizle.Location = new System.Drawing.Point(269, 598);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(169, 48);
            this.buttonTemizle.TabIndex = 6;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // textKategori
            // 
            this.textKategori.Location = new System.Drawing.Point(231, 194);
            this.textKategori.Name = "textKategori";
            this.textKategori.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKategori.Properties.Appearance.Options.UseFont = true;
            this.textKategori.Size = new System.Drawing.Size(247, 26);
            this.textKategori.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 327);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(642, 512);
            this.pictureEdit1.TabIndex = 37;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(651, 327);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(642, 512);
            this.pictureEdit2.TabIndex = 38;
            // 
            // FormKategoriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormKategoriIslem";
            this.Text = "Kategori İşlemleri";
            this.Load += new System.EventHandler(this.FormKategoriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton buttonKaydet;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton buttonListele;
        private DevExpress.XtraEditors.SimpleButton buttonGuncelle;
        private DevExpress.XtraEditors.SimpleButton buttonSil;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textKategori;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton buttonTemizle;
    }
}