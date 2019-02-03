namespace HızlıTrenApp.UI
{
	partial class frmSeferler
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
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.lstSeferler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Onceki Gun Tarihi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(611, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Sonraki Gun Tarihi";
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(729, 72);
            this.btnIleri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(63, 40);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = ">";
            this.btnIleri.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(18, 72);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(63, 40);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(729, 732);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(63, 40);
            this.btnDevam.TabIndex = 6;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(18, 732);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(63, 40);
            this.btnAnasayfa.TabIndex = 6;
            this.btnAnasayfa.Text = "Ana Sayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // lstSeferler
            // 
            this.lstSeferler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstSeferler.FullRowSelect = true;
            this.lstSeferler.GridLines = true;
            this.lstSeferler.Location = new System.Drawing.Point(18, 118);
            this.lstSeferler.Name = "lstSeferler";
            this.lstSeferler.Size = new System.Drawing.Size(772, 371);
            this.lstSeferler.TabIndex = 7;
            this.lstSeferler.UseCompatibleStateImageBehavior = false;
            this.lstSeferler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kalkış";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Varış";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tahmini Varış Süresi";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Boş Koltuk Sayısı";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sefer Tarihi";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sefer Saati";
            this.columnHeader6.Width = 144;
            // 
            // frmSeferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 512);
            this.Controls.Add(this.lstSeferler);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmSeferler";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Seferler";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.frmSeferler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.ListView lstSeferler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}