using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA;
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
        frmGiris gelenForm;
        public frmSeferler(frmGiris frm)
        {
            InitializeComponent();
            gelenForm = frm;
            _seferlerDal = new SeferlerDal();
            _seferlerSeferSaatleriDal = new SeferlerSeferSaatleriDal();
        }
        private SeferlerDal _seferlerDal;
        private SeferlerSeferSaatleriDal _seferlerSeferSaatleriDal;
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

            Sefer sefer = new Sefer();
            sefer = _seferlerDal.GetSeferIDByFilter(gelenForm.nereden, gelenForm.nereye);
            int id = sefer.SeferID;
            
            List<SeferSeferSaat> seferSeferSaatleri = new List<SeferSeferSaat>();
            seferSeferSaatleri = _seferlerSeferSaatleriDal.GetBySeferID(id);
            foreach (var item in seferSeferSaatleri)
            {
                List<string> veriTopla = new List<string>();
            }

            MetroButton devam = new MetroButton();
            devam.Width = 40;
            devam.Height = 20;
            devam.Top = dgvListe.Bottom + 15;
            this.Controls.Add(devam);
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            frmKoltukSecimi gelenForm = new frmKoltukSecimi(this);
            Hide();
            GroupBox kutu = (GroupBox)this.Parent;
            Form anaForm = (Form)kutu.Parent.Parent;
            gelenForm.Width = kutu.Width;
            gelenForm.Height = kutu.Height;
            gelenForm.MdiParent = anaForm;
            kutu.Controls.Remove(this);
            kutu.Controls.Add(gelenForm);
            gelenForm.Show();
            gelenForm.Location = Point.Empty;
        }
    }
}
