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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(128, 134);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Onceki Gun Tarihi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(973, 134);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Sonraki Gun Tarihi";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(30, 180);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(1162, 938);
            this.dgvListe.TabIndex = 4;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(1093, 111);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(94, 61);
            this.btnIleri.TabIndex = 6;
            this.btnIleri.Text = ">";
            this.btnIleri.UseVisualStyleBackColor = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(27, 111);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 61);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(1093, 1126);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(94, 61);
            this.btnDevam.TabIndex = 6;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(27, 1126);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(94, 61);
            this.btnAnasayfa.TabIndex = 6;
            this.btnAnasayfa.Text = "Ana Sayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // frmSeferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1214);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSeferler";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Seferler";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.frmSeferler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}