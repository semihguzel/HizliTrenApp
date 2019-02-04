namespace HızlıTrenApp.UI
{
	partial class frmIstasyonAyrinti
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
			this.btnKalkis = new MetroFramework.Controls.MetroButton();
			this.btnVaris = new MetroFramework.Controls.MetroButton();
			this.lstIstasyonSeferleri = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnKalkis
			// 
			this.btnKalkis.Location = new System.Drawing.Point(238, 436);
			this.btnKalkis.Name = "btnKalkis";
			this.btnKalkis.Size = new System.Drawing.Size(98, 43);
			this.btnKalkis.TabIndex = 1;
			this.btnKalkis.Text = "Kalkis";
			this.btnKalkis.Click += new System.EventHandler(this.btnKalkis_Click);
			// 
			// btnVaris
			// 
			this.btnVaris.Location = new System.Drawing.Point(406, 436);
			this.btnVaris.Name = "btnVaris";
			this.btnVaris.Size = new System.Drawing.Size(98, 43);
			this.btnVaris.TabIndex = 1;
			this.btnVaris.Text = "Varis";
			this.btnVaris.Click += new System.EventHandler(this.btnVaris_Click);
			// 
			// lstIstasyonSeferleri
			// 
			this.lstIstasyonSeferleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lstIstasyonSeferleri.GridLines = true;
			this.lstIstasyonSeferleri.Location = new System.Drawing.Point(24, 64);
			this.lstIstasyonSeferleri.Name = "lstIstasyonSeferleri";
			this.lstIstasyonSeferleri.Size = new System.Drawing.Size(753, 366);
			this.lstIstasyonSeferleri.TabIndex = 2;
			this.lstIstasyonSeferleri.UseCompatibleStateImageBehavior = false;
			this.lstIstasyonSeferleri.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "İlk İstasyon";
			this.columnHeader1.Width = 143;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Son İstasyon";
			this.columnHeader2.Width = 145;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Kalkış Saati";
			this.columnHeader3.Width = 148;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tahmini Varış Süresi";
			this.columnHeader4.Width = 167;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Sefer Tarihi";
			this.columnHeader5.Width = 144;
			// 
			// frmIstasyonAyrinti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 490);
			this.Controls.Add(this.lstIstasyonSeferleri);
			this.Controls.Add(this.btnVaris);
			this.Controls.Add(this.btnKalkis);
			this.Name = "frmIstasyonAyrinti";
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "İstasyondaki Seferler";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.Load += new System.EventHandler(this.frmIstasyonAyrinti_Load);
			this.ResumeLayout(false);

		}

		#endregion
        private MetroFramework.Controls.MetroButton btnKalkis;
        private MetroFramework.Controls.MetroButton btnVaris;
        private System.Windows.Forms.ListView lstIstasyonSeferleri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}