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
	}
}
