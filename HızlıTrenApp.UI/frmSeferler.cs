using MetroFramework.Controls;
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
	public partial class frmSeferler : MetroFramework.Forms.MetroForm
	{
        Form gelenForm;
		public frmSeferler(Form frm)
		{
			InitializeComponent();
            gelenForm = frm;
		}

        private void frmSeferler_Load(object sender, EventArgs e)
        {
            dgvListe.ColumnCount = 5;
            dgvListe.Columns[0].Name = "Bilgi";
            dgvListe.Columns[1].Name = "Kalkış";
            dgvListe.Columns[2].Name = "Varış";
            dgvListe.Columns[3].Name = "Kalan Koltuk";
            dgvListe.Columns[4].Name = "Fiyat";
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Seçim";
            chk.Name = "CheckBox";
            dgvListe.Columns.Add(chk);

            MetroButton devam = new MetroButton();
            devam.Width = 40;
            devam.Height = 20;
            devam.Top = dgvListe.Bottom + 15;
            this.Controls.Add(devam);
        }
    }
}
