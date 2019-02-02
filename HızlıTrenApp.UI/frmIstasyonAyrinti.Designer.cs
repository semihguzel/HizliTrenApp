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
			((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSeferler
			// 
			this.dgvSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSeferler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSeferler.Location = new System.Drawing.Point(20, 60);
			this.dgvSeferler.Name = "dgvSeferler";
			this.dgvSeferler.Size = new System.Drawing.Size(760, 370);
			this.dgvSeferler.TabIndex = 0;
			// 
			// frmIstasyonAyrinti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}