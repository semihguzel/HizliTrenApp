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
	public partial class frmKoltukSecimi : MetroFramework.Forms.MetroForm
	{
        Form gelenForm;
		public frmKoltukSecimi(Form form)
		{
			InitializeComponent();
            gelenForm = form;
		}
	}
}
