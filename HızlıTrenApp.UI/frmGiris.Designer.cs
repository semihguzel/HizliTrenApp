namespace HızlıTrenApp.UI
{
	partial class frmGiris
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
			this.btnSeferleriListele = new MetroFramework.Controls.MetroButton();
			this.nmrYolcuSayisi = new System.Windows.Forms.NumericUpDown();
			this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
			this.rdbGidisDonus = new MetroFramework.Controls.MetroRadioButton();
			this.rdbTekyon = new MetroFramework.Controls.MetroRadioButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.cmbNereye = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.cmbTip = new MetroFramework.Controls.MetroComboBox();
			this.cmbNereden = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.grpBilet = new System.Windows.Forms.GroupBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nmrYolcuSayisi)).BeginInit();
			this.grpBilet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSeferleriListele
			// 
			this.btnSeferleriListele.Location = new System.Drawing.Point(21, 320);
			this.btnSeferleriListele.Name = "btnSeferleriListele";
			this.btnSeferleriListele.Size = new System.Drawing.Size(292, 35);
			this.btnSeferleriListele.Style = MetroFramework.MetroColorStyle.Red;
			this.btnSeferleriListele.TabIndex = 7;
			this.btnSeferleriListele.Text = "Seferleri Listele";
			this.btnSeferleriListele.Click += new System.EventHandler(this.btnSeferleriListele_Click);
			// 
			// nmrYolcuSayisi
			// 
			this.nmrYolcuSayisi.Location = new System.Drawing.Point(104, 276);
			this.nmrYolcuSayisi.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nmrYolcuSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrYolcuSayisi.Name = "nmrYolcuSayisi";
			this.nmrYolcuSayisi.Size = new System.Drawing.Size(39, 21);
			this.nmrYolcuSayisi.TabIndex = 5;
			this.nmrYolcuSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dtpDonusTarihi
			// 
			this.dtpDonusTarihi.Location = new System.Drawing.Point(23, 233);
			this.dtpDonusTarihi.Name = "dtpDonusTarihi";
			this.dtpDonusTarihi.Size = new System.Drawing.Size(200, 21);
			this.dtpDonusTarihi.TabIndex = 4;
			// 
			// dtpGidisTarihi
			// 
			this.dtpGidisTarihi.Location = new System.Drawing.Point(22, 173);
			this.dtpGidisTarihi.Name = "dtpGidisTarihi";
			this.dtpGidisTarihi.Size = new System.Drawing.Size(200, 21);
			this.dtpGidisTarihi.TabIndex = 3;
			// 
			// rdbGidisDonus
			// 
			this.rdbGidisDonus.AutoSize = true;
			this.rdbGidisDonus.Location = new System.Drawing.Point(104, 35);
			this.rdbGidisDonus.Name = "rdbGidisDonus";
			this.rdbGidisDonus.Size = new System.Drawing.Size(86, 15);
			this.rdbGidisDonus.TabIndex = 4;
			this.rdbGidisDonus.TabStop = true;
			this.rdbGidisDonus.Text = "Gidiş Dönüş";
			this.rdbGidisDonus.UseVisualStyleBackColor = true;
			// 
			// rdbTekyon
			// 
			this.rdbTekyon.AutoSize = true;
			this.rdbTekyon.Location = new System.Drawing.Point(23, 35);
			this.rdbTekyon.Name = "rdbTekyon";
			this.rdbTekyon.Size = new System.Drawing.Size(66, 15);
			this.rdbTekyon.TabIndex = 0;
			this.rdbTekyon.TabStop = true;
			this.rdbTekyon.Text = "Tek Yön";
			this.rdbTekyon.UseVisualStyleBackColor = true;
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.Location = new System.Drawing.Point(23, 278);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(75, 19);
			this.metroLabel6.TabIndex = 3;
			this.metroLabel6.Text = "Yolcu Sayısı";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(23, 211);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(79, 19);
			this.metroLabel5.TabIndex = 3;
			this.metroLabel5.Text = "Dönüş Tarihi";
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(22, 151);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(71, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "Gidiş Tarihi";
			// 
			// cmbNereye
			// 
			this.cmbNereye.FormattingEnabled = true;
			this.cmbNereye.ItemHeight = 23;
			this.cmbNereye.Location = new System.Drawing.Point(182, 94);
			this.cmbNereye.Name = "cmbNereye";
			this.cmbNereye.Size = new System.Drawing.Size(121, 29);
			this.cmbNereye.TabIndex = 2;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(182, 72);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(51, 19);
			this.metroLabel3.TabIndex = 1;
			this.metroLabel3.Text = "Nereye";
			// 
			// cmbTip
			// 
			this.cmbTip.FormattingEnabled = true;
			this.cmbTip.ItemHeight = 23;
			this.cmbTip.Location = new System.Drawing.Point(182, 268);
			this.cmbTip.Name = "cmbTip";
			this.cmbTip.Size = new System.Drawing.Size(121, 29);
			this.cmbTip.TabIndex = 6;
			// 
			// cmbNereden
			// 
			this.cmbNereden.FormattingEnabled = true;
			this.cmbNereden.ItemHeight = 23;
			this.cmbNereden.Location = new System.Drawing.Point(22, 94);
			this.cmbNereden.Name = "cmbNereden";
			this.cmbNereden.Size = new System.Drawing.Size(121, 29);
			this.cmbNereden.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(22, 72);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(60, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Nereden";
			// 
			// grpBilet
			// 
			this.grpBilet.Controls.Add(this.btnSeferleriListele);
			this.grpBilet.Controls.Add(this.nmrYolcuSayisi);
			this.grpBilet.Controls.Add(this.dtpDonusTarihi);
			this.grpBilet.Controls.Add(this.dtpGidisTarihi);
			this.grpBilet.Controls.Add(this.rdbGidisDonus);
			this.grpBilet.Controls.Add(this.rdbTekyon);
			this.grpBilet.Controls.Add(this.metroLabel6);
			this.grpBilet.Controls.Add(this.metroLabel5);
			this.grpBilet.Controls.Add(this.metroLabel4);
			this.grpBilet.Controls.Add(this.cmbNereye);
			this.grpBilet.Controls.Add(this.metroLabel3);
			this.grpBilet.Controls.Add(this.cmbTip);
			this.grpBilet.Controls.Add(this.cmbNereden);
			this.grpBilet.Controls.Add(this.metroLabel2);
			this.grpBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpBilet.Location = new System.Drawing.Point(13, 65);
			this.grpBilet.Name = "grpBilet";
			this.grpBilet.Size = new System.Drawing.Size(338, 368);
			this.grpBilet.TabIndex = 5;
			this.grpBilet.TabStop = false;
			this.grpBilet.Text = "Bilet";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(475, 50);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(263, 25);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Bilet Satış ve Rezervasyon Sistemi";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HızlıTrenApp.UI.Properties.Resources.hizlitren;
			this.pictureBox1.Location = new System.Drawing.Point(357, 87);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(381, 309);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// frmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 441);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.grpBilet);
			this.Controls.Add(this.metroLabel1);
			this.MaximizeBox = false;
			this.Name = "frmGiris";
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Hızlı Tren Bileti";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.Load += new System.EventHandler(this.frmGiris_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmrYolcuSayisi)).EndInit();
			this.grpBilet.ResumeLayout(false);
			this.grpBilet.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroButton btnSeferleriListele;
		private System.Windows.Forms.NumericUpDown nmrYolcuSayisi;
		private System.Windows.Forms.DateTimePicker dtpDonusTarihi;
		private System.Windows.Forms.DateTimePicker dtpGidisTarihi;
		private MetroFramework.Controls.MetroRadioButton rdbGidisDonus;
		private MetroFramework.Controls.MetroRadioButton rdbTekyon;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroComboBox cmbNereye;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox cmbTip;
		private MetroFramework.Controls.MetroComboBox cmbNereden;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.GroupBox grpBilet;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}