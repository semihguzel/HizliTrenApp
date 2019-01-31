namespace HızlıTrenApp.UI
{
	partial class frmKoltukSecimi
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
			this.flpKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpKoltuklar
			// 
			this.flpKoltuklar.Location = new System.Drawing.Point(42, 102);
			this.flpKoltuklar.Name = "flpKoltuklar";
			this.flpKoltuklar.Size = new System.Drawing.Size(717, 246);
			this.flpKoltuklar.TabIndex = 1;
			// 
			// frmKoltukSecimi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flpKoltuklar);
			this.Name = "frmKoltukSecimi";
			this.Style = MetroFramework.MetroColorStyle.Red;
			this.Text = "Koltuk Seçimi";
			this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpKoltuklar;
	}
}