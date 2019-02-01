namespace HızlıTrenApp.UI
{
	partial class frmIstasyonTrenBilgileri
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbIstasyon = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 142);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "İstasyon";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(82, 255);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tarih";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(82, 289);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(298, 26);
            this.dtpTarih.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(82, 358);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(300, 60);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "İstasyon-Tren Bilgileri";
            // 
            // cmbIstasyon
            // 
            this.cmbIstasyon.FormattingEnabled = true;
            this.cmbIstasyon.ItemHeight = 23;
            this.cmbIstasyon.Location = new System.Drawing.Point(82, 175);
            this.cmbIstasyon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIstasyon.Name = "cmbIstasyon";
            this.cmbIstasyon.Size = new System.Drawing.Size(298, 29);
            this.cmbIstasyon.TabIndex = 0;
            // 
            // frmIstasyonTrenBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 454);
            this.Controls.Add(this.cmbIstasyon);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIstasyonTrenBilgileri";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "İstasyon Tren Bilgileri";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.DateTimePicker dtpTarih;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroComboBox cmbIstasyon;
	}
}