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
            this.dgvSeferler.Location = new System.Drawing.Point(30, 92);
            this.dgvSeferler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSeferler.Name = "dgvSeferler";
            this.dgvSeferler.Size = new System.Drawing.Size(1140, 569);
            this.dgvSeferler.TabIndex = 0;
            // 
            // frmIstasyonAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dgvSeferler);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIstasyonAyrinti";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "İstasyondaki Seferler";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeferler)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSeferler;
	}
}