using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıTrenApp.UI
{
	public partial class frmGiris : MetroFramework.Forms.MetroForm
	{
		public frmGiris()
		{
			InitializeComponent();
		}

		private void frmGiris_Load(object sender, EventArgs e)
		{
			cmbTip.Items.Add("Ekonomi");
			cmbTip.Items.Add("Business");
			cmbTip.SelectedIndex = 0;
			rdbTekyon.Checked = true;
            dtpDonusTarihi.Enabled = false;
        }
        private void btnSeferleriListele_Click(object sender, EventArgs e)
		{
			frmSeferler frmSeferler = new frmSeferler(this);
            this.Hide();
            GroupBox kutu = (GroupBox)this.Parent;
            Form anaForm = (Form)kutu.Parent.Parent;
            frmSeferler.Width = kutu.Width;
            frmSeferler.Height = kutu.Height;
            frmSeferler.MdiParent = anaForm;
            kutu.Controls.Remove(this);
            kutu.Controls.Add(frmSeferler);
            frmSeferler.Show();
            frmSeferler.Location = Point.Empty;
        }

        private void rdbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtpDonusTarihi.Enabled = true;
        }

        private void rdbTekyon_CheckedChanged(object sender, EventArgs e)
        {
            dtpDonusTarihi.Enabled = false;
        }
    }
}
