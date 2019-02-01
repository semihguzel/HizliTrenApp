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
            this.flpKoltuklar.Location = new System.Drawing.Point(63, 157);
            this.flpKoltuklar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpKoltuklar.Name = "flpKoltuklar";
            this.flpKoltuklar.Size = new System.Drawing.Size(1076, 378);
            this.flpKoltuklar.TabIndex = 1;
            // 
            // frmKoltukSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.flpKoltuklar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKoltukSecimi";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Koltuk Seçimi";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpKoltuklar;
	}
}