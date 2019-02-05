namespace HızlıTrenApp.UI
{
	partial class frmOdeme
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
			this.grpYolcuBilgileri = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grpOdemeBilgileri = new System.Windows.Forms.GroupBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtKartSahibi = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtKartNumarasi = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cmbAy = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.cmbYil = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.txtGuvenlikKodu = new MetroFramework.Controls.MetroTextBox();
			this.btnOdemeYap = new MetroFramework.Controls.MetroButton();
			this.chkKartBilgileriSakla = new MetroFramework.Controls.MetroCheckBox();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.chkSatisSozlesmesi = new MetroFramework.Controls.MetroCheckBox();
			this.grpYolcuBilgileri.SuspendLayout();
			this.grpOdemeBilgileri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// grpYolcuBilgileri
			// 
			this.grpYolcuBilgileri.Controls.Add(this.listView1);
			this.grpYolcuBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpYolcuBilgileri.Location = new System.Drawing.Point(29, 64);
			this.grpYolcuBilgileri.Name = "grpYolcuBilgileri";
			this.grpYolcuBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grpYolcuBilgileri.Size = new System.Drawing.Size(782, 91);
			this.grpYolcuBilgileri.TabIndex = 0;
			this.grpYolcuBilgileri.TabStop = false;
			this.grpYolcuBilgileri.Text = "Yolcu Bilgileri";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(3, 19);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(776, 69);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Adı";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Soyadı";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Seyehat Tipi";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tren";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Hareket Saati";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Koltuk No";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 90;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ücret";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 80;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Toplam Ücret";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 100;
			// 
			// grpOdemeBilgileri
			// 
			this.grpOdemeBilgileri.Controls.Add(this.chkSatisSozlesmesi);
			this.grpOdemeBilgileri.Controls.Add(this.chkKartBilgileriSakla);
			this.grpOdemeBilgileri.Controls.Add(this.pictureBox2);
			this.grpOdemeBilgileri.Controls.Add(this.pictureBox1);
			this.grpOdemeBilgileri.Controls.Add(this.btnOdemeYap);
			this.grpOdemeBilgileri.Controls.Add(this.cmbYil);
			this.grpOdemeBilgileri.Controls.Add(this.cmbAy);
			this.grpOdemeBilgileri.Controls.Add(this.txtGuvenlikKodu);
			this.grpOdemeBilgileri.Controls.Add(this.txtKartNumarasi);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel4);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel5);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel3);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel2);
			this.grpOdemeBilgileri.Controls.Add(this.txtKartSahibi);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel6);
			this.grpOdemeBilgileri.Controls.Add(this.metroLabel1);
			this.grpOdemeBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpOdemeBilgileri.Location = new System.Drawing.Point(27, 188);
			this.grpOdemeBilgileri.Name = "grpOdemeBilgileri";
			this.grpOdemeBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grpOdemeBilgileri.Size = new System.Drawing.Size(813, 265);
			this.grpOdemeBilgileri.TabIndex = 1;
			this.grpOdemeBilgileri.TabStop = false;
			this.grpOdemeBilgileri.Text = "Ödeme Bilgileri";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(63, 50);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(72, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Kart Sahibi";
			// 
			// txtKartSahibi
			// 
			this.txtKartSahibi.Location = new System.Drawing.Point(141, 46);
			this.txtKartSahibi.Name = "txtKartSahibi";
			this.txtKartSahibi.Size = new System.Drawing.Size(144, 23);
			this.txtKartSahibi.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(42, 89);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(93, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Kart Numarası";
			// 
			// txtKartNumarasi
			// 
			this.txtKartNumarasi.Location = new System.Drawing.Point(141, 85);
			this.txtKartNumarasi.Name = "txtKartNumarasi";
			this.txtKartNumarasi.Size = new System.Drawing.Size(144, 23);
			this.txtKartNumarasi.TabIndex = 1;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(13, 140);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(122, 19);
			this.metroLabel3.TabIndex = 0;
			this.metroLabel3.Text = "Son Kullanma Tarihi";
			// 
			// cmbAy
			// 
			this.cmbAy.FormattingEnabled = true;
			this.cmbAy.ItemHeight = 23;
			this.cmbAy.Location = new System.Drawing.Point(141, 130);
			this.cmbAy.Name = "cmbAy";
			this.cmbAy.Size = new System.Drawing.Size(52, 29);
			this.cmbAy.TabIndex = 2;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.Location = new System.Drawing.Point(198, 132);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(19, 25);
			this.metroLabel4.TabIndex = 0;
			this.metroLabel4.Text = "/";
			// 
			// cmbYil
			// 
			this.cmbYil.FormattingEnabled = true;
			this.cmbYil.ItemHeight = 23;
			this.cmbYil.Location = new System.Drawing.Point(223, 130);
			this.cmbYil.Name = "cmbYil";
			this.cmbYil.Size = new System.Drawing.Size(52, 29);
			this.cmbYil.TabIndex = 2;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(13, 176);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(91, 19);
			this.metroLabel5.TabIndex = 0;
			this.metroLabel5.Text = "Güvenlik Kodu";
			// 
			// txtGuvenlikKodu
			// 
			this.txtGuvenlikKodu.Location = new System.Drawing.Point(141, 172);
			this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
			this.txtGuvenlikKodu.Size = new System.Drawing.Size(144, 23);
			this.txtGuvenlikKodu.TabIndex = 1;
			// 
			// btnOdemeYap
			// 
			this.btnOdemeYap.Location = new System.Drawing.Point(158, 216);
			this.btnOdemeYap.Name = "btnOdemeYap";
			this.btnOdemeYap.Size = new System.Drawing.Size(127, 37);
			this.btnOdemeYap.TabIndex = 3;
			this.btnOdemeYap.Text = "Ödeme Yap";
			// 
			// chkKartBilgileriSakla
			// 
			this.chkKartBilgileriSakla.AutoSize = true;
			this.chkKartBilgileriSakla.Location = new System.Drawing.Point(313, 216);
			this.chkKartBilgileriSakla.Name = "chkKartBilgileriSakla";
			this.chkKartBilgileriSakla.Size = new System.Drawing.Size(496, 15);
			this.chkKartBilgileriSakla.TabIndex = 5;
			this.chkKartBilgileriSakla.Text = "Kartımı MasterPass altyapısında saklamak ve bir sonraki alışverişimde kullanmak i" +
    "stiyorum";
			this.chkKartBilgileriSakla.UseVisualStyleBackColor = true;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel6.Location = new System.Drawing.Point(495, 140);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(247, 57);
			this.metroLabel6.TabIndex = 0;
			this.metroLabel6.Text = "Kredi kartı bilgileriniz tarafımızca\r\nsaklanmamaktadır, ödeme altyapısı\r\nMasterCa" +
    "rd tarafından sağlanmaktadır.";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::HızlıTrenApp.UI.Properties.Resources._3Dsecure;
			this.pictureBox2.Location = new System.Drawing.Point(50, 212);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(102, 43);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HızlıTrenApp.UI.Properties.Resources.visa_PNG17;
			this.pictureBox1.Location = new System.Drawing.Point(322, 140);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(167, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// chkSatisSozlesmesi
			// 
			this.chkSatisSozlesmesi.AutoSize = true;
			this.chkSatisSozlesmesi.Location = new System.Drawing.Point(538, 32);
			this.chkSatisSozlesmesi.Name = "chkSatisSozlesmesi";
			this.chkSatisSozlesmesi.Size = new System.Drawing.Size(269, 15);
			this.chkSatisSozlesmesi.TabIndex = 5;
			this.chkSatisSozlesmesi.Text = "Satış Sözleşmesini Okudum ve Kabul Ediyorum";
			this.chkSatisSozlesmesi.UseVisualStyleBackColor = true;
			// 
			// frmOdeme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 476);
			this.Controls.Add(this.grpOdemeBilgileri);
			this.Controls.Add(this.grpYolcuBilgileri);
			this.Name = "frmOdeme";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Ödeme";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.grpYolcuBilgileri.ResumeLayout(false);
			this.grpOdemeBilgileri.ResumeLayout(false);
			this.grpOdemeBilgileri.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpYolcuBilgileri;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.GroupBox grpOdemeBilgileri;
		private MetroFramework.Controls.MetroTextBox txtKartNumarasi;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox txtKartSahibi;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroButton btnOdemeYap;
		private MetroFramework.Controls.MetroComboBox cmbYil;
		private MetroFramework.Controls.MetroComboBox cmbAy;
		private MetroFramework.Controls.MetroTextBox txtGuvenlikKodu;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroCheckBox chkKartBilgileriSakla;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private MetroFramework.Controls.MetroCheckBox chkSatisSozlesmesi;
	}
}