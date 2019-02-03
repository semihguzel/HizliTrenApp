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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.grpAnaKutu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mlBiletlerim
            // 
            this.mlBiletlerim.Location = new System.Drawing.Point(1126, 12);
            this.mlBiletlerim.Name = "mlBiletlerim";
            this.mlBiletlerim.Size = new System.Drawing.Size(189, 57);
            this.mlBiletlerim.TabIndex = 2;
            this.mlBiletlerim.Text = "Biletlerim";
            this.mlBiletlerim.Click += new System.EventHandler(this.mlBiletlerim_Click);
            // 
            // mlRezervasyonlarim
            // 
            this.mlRezervasyonlarim.Location = new System.Drawing.Point(1364, 12);
            this.mlRezervasyonlarim.Name = "mlRezervasyonlarim";
            this.mlRezervasyonlarim.Size = new System.Drawing.Size(189, 57);
            this.mlRezervasyonlarim.TabIndex = 2;
            this.mlRezervasyonlarim.Text = "Rezervasyonlarim";
            this.mlRezervasyonlarim.Click += new System.EventHandler(this.mlRezervasyonlarim_Click);
            // 
            // grpAnaKutu
            // 
            this.grpAnaKutu.Controls.Add(this.mlIstasyonTren);
            this.grpAnaKutu.Controls.Add(this.mlBilet);
            this.grpAnaKutu.Location = new System.Drawing.Point(33, 89);
            this.grpAnaKutu.Name = "grpAnaKutu";
            this.grpAnaKutu.Size = new System.Drawing.Size(1520, 834);
            this.grpAnaKutu.TabIndex = 5;
            this.grpAnaKutu.TabStop = false;
            // 
            // mlIstasyonTren
            // 
            this.mlIstasyonTren.Location = new System.Drawing.Point(1316, 25);
            this.mlIstasyonTren.Name = "mlIstasyonTren";
            this.mlIstasyonTren.Size = new System.Drawing.Size(198, 45);
            this.mlIstasyonTren.TabIndex = 0;
            this.mlIstasyonTren.Text = "Istasyon-Tren Bilgileri";
            this.mlIstasyonTren.Click += new System.EventHandler(this.mlIstasyonTren_Click);
            // 
            // mlBilet
            // 
            this.mlBilet.Location = new System.Drawing.Point(1122, 25);
            this.mlBilet.Name = "mlBilet";
            this.mlBilet.Size = new System.Drawing.Size(130, 45);
            this.mlBilet.TabIndex = 0;
            this.mlBilet.Text = "Bilet";
            this.mlBilet.Click += new System.EventHandler(this.mlBilet_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(33, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(127, 71);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 1017);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpAnaKutu);
            this.Controls.Add(this.mlRezervasyonlarim);
            this.Controls.Add(this.mlBiletlerim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.grpAnaKutu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink mlBiletlerim;
        private MetroFramework.Controls.MetroLink mlRezervasyonlarim;
        private System.Windows.Forms.GroupBox grpAnaKutu;
        private MetroFramework.Controls.MetroLink mlIstasyonTren;
        private MetroFramework.Controls.MetroLink mlBilet;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}