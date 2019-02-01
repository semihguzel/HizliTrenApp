namespace HızlıTrenApp.UI
{
    partial class frmAnaSayfa
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
            this.mlBiletlerim = new MetroFramework.Controls.MetroLink();
            this.mlRezervasyonlarim = new MetroFramework.Controls.MetroLink();
            this.grpAnaKutu = new System.Windows.Forms.GroupBox();
            this.mlIstasyonTren = new MetroFramework.Controls.MetroLink();
            this.mlBilet = new MetroFramework.Controls.MetroLink();
            this.grpAnaKutu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlBiletlerim
            // 
            this.mlBiletlerim.Location = new System.Drawing.Point(751, 8);
            this.mlBiletlerim.Margin = new System.Windows.Forms.Padding(2);
            this.mlBiletlerim.Name = "mlBiletlerim";
            this.mlBiletlerim.Size = new System.Drawing.Size(126, 37);
            this.mlBiletlerim.TabIndex = 2;
            this.mlBiletlerim.Text = "Biletlerim";
            // 
            // mlRezervasyonlarim
            // 
            this.mlRezervasyonlarim.Location = new System.Drawing.Point(909, 8);
            this.mlRezervasyonlarim.Margin = new System.Windows.Forms.Padding(2);
            this.mlRezervasyonlarim.Name = "mlRezervasyonlarim";
            this.mlRezervasyonlarim.Size = new System.Drawing.Size(126, 37);
            this.mlRezervasyonlarim.TabIndex = 2;
            this.mlRezervasyonlarim.Text = "Rezervasyonlarim";
            // 
            // grpAnaKutu
            // 
            this.grpAnaKutu.Controls.Add(this.mlIstasyonTren);
            this.grpAnaKutu.Controls.Add(this.mlBilet);
            this.grpAnaKutu.Location = new System.Drawing.Point(22, 58);
            this.grpAnaKutu.Margin = new System.Windows.Forms.Padding(2);
            this.grpAnaKutu.Name = "grpAnaKutu";
            this.grpAnaKutu.Padding = new System.Windows.Forms.Padding(2);
            this.grpAnaKutu.Size = new System.Drawing.Size(1013, 542);
            this.grpAnaKutu.TabIndex = 5;
            this.grpAnaKutu.TabStop = false;
            // 
            // mlIstasyonTren
            // 
            this.mlIstasyonTren.Location = new System.Drawing.Point(877, 16);
            this.mlIstasyonTren.Margin = new System.Windows.Forms.Padding(2);
            this.mlIstasyonTren.Name = "mlIstasyonTren";
            this.mlIstasyonTren.Size = new System.Drawing.Size(132, 29);
            this.mlIstasyonTren.TabIndex = 0;
            this.mlIstasyonTren.Text = "Istasyon-Tren Bilgileri";
            this.mlIstasyonTren.Click += new System.EventHandler(this.mlIstasyonTren_Click);
            // 
            // mlBilet
            // 
            this.mlBilet.Location = new System.Drawing.Point(748, 16);
            this.mlBilet.Margin = new System.Windows.Forms.Padding(2);
            this.mlBilet.Name = "mlBilet";
            this.mlBilet.Size = new System.Drawing.Size(87, 29);
            this.mlBilet.TabIndex = 0;
            this.mlBilet.Text = "Bilet";
            this.mlBilet.Click += new System.EventHandler(this.mlBilet_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.grpAnaKutu);
            this.Controls.Add(this.mlRezervasyonlarim);
            this.Controls.Add(this.mlBiletlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.grpAnaKutu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlBiletlerim;
        private MetroFramework.Controls.MetroLink mlRezervasyonlarim;
        private System.Windows.Forms.GroupBox grpAnaKutu;
        private MetroFramework.Controls.MetroLink mlIstasyonTren;
        private MetroFramework.Controls.MetroLink mlBilet;
    }
}