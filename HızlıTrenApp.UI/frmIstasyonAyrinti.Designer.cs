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
            this.dgvSeferler = new System.Windows.Forms.DataGridView();
            this.btnKalkis = new MetroFramework.Controls.MetroButton();
            this.btnVaris = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeferler
            // 
            this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeferler.Location = new System.Drawing.Point(20, 60);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.Size = new System.Drawing.Size(760, 370);
            this.dgvSeferler.TabIndex = 0;
            // 
            // btnKalkis
            // 
            this.btnKalkis.Location = new System.Drawing.Point(238, 436);
            this.btnKalkis.Name = "btnKalkis";
            this.btnKalkis.Size = new System.Drawing.Size(98, 43);
            this.btnKalkis.TabIndex = 1;
            this.btnKalkis.Text = "Kalkis";
            // 
            // btnVaris
            // 
            this.btnVaris.Location = new System.Drawing.Point(406, 436);
            this.btnVaris.Name = "btnVaris";
            this.btnVaris.Size = new System.Drawing.Size(98, 43);
            this.btnVaris.TabIndex = 1;
            this.btnVaris.Text = "Varis";
            // 
            // frmIstasyonAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnVaris);
            this.Controls.Add(this.btnKalkis);
            this.Controls.Add(this.dgvSeferler);
            this.Name = "frmIstasyonAyrinti";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "İstasyondaki Seferler";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.frmIstasyonAyrinti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSeferler;
        private MetroFramework.Controls.MetroButton btnKalkis;
        private MetroFramework.Controls.MetroButton btnVaris;
    }
}