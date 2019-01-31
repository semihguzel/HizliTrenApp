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
		}
		private void btnSeferleriListele_Click(object sender, EventArgs e)
		{
			frmSeferler frmSeferler = new frmSeferler();
			this.Hide();
			frmSeferler.Show();
		}

	}
}
