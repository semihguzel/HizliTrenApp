namespace HızlıTrenApp.UI
{
	partial class frmBiletlerim
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txtPnrNo = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.btnSorgula = new MetroFramework.Controls.MetroButton();
			this.grpSeyehatBilgileri = new System.Windows.Forms.GroupBox();
			this.dgvSeyehatBilgileri = new System.Windows.Forms.DataGridView();
			this.btnİade = new MetroFramework.Controls.MetroButton();
			this.btnAcikBilet = new MetroFramework.Controls.MetroButton();
			this.btnDegistir = new MetroFramework.Controls.MetroButton();
			this.grpSeyehatBilgileri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(24, 86);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "PNR No";
			// 
			// txtPnrNo
			// 
			this.txtPnrNo.Location = new System.Drawing.Point(87, 85);
			this.txtPnrNo.Name = "txtPnrNo";
			this.txtPnrNo.Size = new System.Drawing.Size(124, 20);
			this.txtPnrNo.TabIndex = 1;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(36, 113);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(45, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Soyad";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(87, 113);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(124, 20);
			this.txtSoyad.TabIndex = 1;
			// 
			// btnSorgula
			// 
			this.btnSorgula.Location = new System.Drawing.Point(136, 150);
			this.btnSorgula.Name = "btnSorgula";
			this.btnSorgula.Size = new System.Drawing.Size(75, 23);
			this.btnSorgula.TabIndex = 2;
			this.btnSorgula.Text = "Sorgula";
			// 
			// grpSeyehatBilgileri
			// 
			this.grpSeyehatBilgileri.Controls.Add(this.dgvSeyehatBilgileri);
			this.grpSeyehatBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpSeyehatBilgileri.Location = new System.Drawing.Point(36, 179);
			this.grpSeyehatBilgileri.Name = "grpSeyehatBilgileri";
			this.grpSeyehatBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.grpSeyehatBilgileri.Size = new System.Drawing.Size(741, 236);
			this.grpSeyehatBilgileri.TabIndex = 3;
			this.grpSeyehatBilgileri.TabStop = false;
			this.grpSeyehatBilgileri.Text = "Seyehat Bilgileri Listesi";
			// 
			// dgvSeyehatBilgileri
			// 
			this.dgvSeyehatBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeyehatBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSeyehatBilgileri.Location = new System.Drawing.Point(3, 19);
			this.dgvSeyehatBilgileri.Name = "dgvSeyehatBilgileri";
			this.dgvSeyehatBilgileri.Size = new System.Drawing.Size(735, 214);
			this.dgvSeyehatBilgileri.TabIndex = 0;
			// 
			// btnİade
			// 
			this.btnİade.Location = new System.Drawing.Point(186, 435);
			this.btnİade.Name = "btnİade";
			this.btnİade.Size = new System.Drawing.Size(75, 23);
			this.btnİade.TabIndex = 2;
			this.btnİade.Text = "İade";
			// 
			// btnAcikBilet
			// 
			this.btnAcikBilet.Location = new System.Drawing.Point(306, 435);
			this.btnAcikBilet.Name = "btnAcikBilet";
			this.btnAcikBilet.Size = new System.Drawing.Size(164, 23);
			this.btnAcikBilet.TabIndex = 2;
			this.btnAcikBilet.Text = "Açık Bilet Kuponuna Çevir";
			// 
			// btnDegistir
			// 
			this.btnDegistir.Location = new System.Drawing.Point(515, 435);
			this.btnDegistir.Name = "btnDegistir";
			this.btnDegistir.Size = new System.Drawing.Size(75, 23);
			this.btnDegistir.TabIndex = 2;
			this.btnDegistir.Text = "Değistir";
			// 
			// frmBiletlerim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 502);
			this.Controls.Add(this.grpSeyehatBilgileri);
			this.Controls.Add(this.btnDegistir);
			this.Controls.Add(this.btnAcikBilet);
			this.Controls.Add(this.btnİade);
			this.Controls.Add(this.btnSorgula);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txtPnrNo);
			this.Controls.Add(this.metroLabel1);
			this.Name = "frmBiletlerim";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Biletlerim";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.grpSeyehatBilgileri.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSeyehatBilgileri)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.TextBox txtPnrNo;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.TextBox txtSoyad;
		private MetroFramework.Controls.MetroButton btnSorgula;
		private System.Windows.Forms.GroupBox grpSeyehatBilgileri;
		private System.Windows.Forms.DataGridView dgvSeyehatBilgileri;
		private MetroFramework.Controls.MetroButton btnİade;
		private MetroFramework.Controls.MetroButton btnAcikBilet;
		private MetroFramework.Controls.MetroButton btnDegistir;
	}
}