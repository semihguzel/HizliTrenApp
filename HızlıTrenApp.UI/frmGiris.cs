using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA;
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
            _seferlerSeferSaatleriDal = new SeferlerDal();
        }

        List<Sefer> seferler;
        private SeferlerDal _seferlerSeferSaatleriDal;
        public DateTime gidisTarihi;
        public DateTime donusTarihi;
        public string nereden;
        public string nereye;
        public int yolcuSayisi;
        public string yolcuTipi;
        public bool ciftMi;

        private void frmGiris_Load(object sender, EventArgs e)
        {
            cmbTip.Items.Add("Economy");
            cmbTip.Items.Add("Business");
            cmbTip.SelectedIndex = 0;
            rdbTekyon.Checked = true;
            dtpDonusTarihi.Enabled = false;
            ciftMi = false;
            //ComboBox lara seirlerin eklenmesi
            seferler = new List<Sefer>();
            seferler.AddRange(_seferlerSeferSaatleriDal.GetAllSeferler());
            foreach (Sefer item in seferler)
            {
                string[] sehir = item.SeferYonu.Split('-');
                int sayac1 = 0;
                int sayac2 = 0;
                foreach (var items in cmbNereden.Items)
                {
                    if (items.ToString() == sehir[0])
                    {
                        sayac1 = 1;
                    }
                    if (items.ToString() == sehir[1])
                    {
                        sayac2 = 1;
                    }
                }
                if (sayac1 == 0 && sayac2 == 0)
                {
                    cmbNereden.Items.Add(sehir[0]);
                    cmbNereye.Items.Add(sehir[0]);
                }
                else if (sayac1 == 1 && sayac2 == 0)
                {
                    cmbNereden.Items.Add(sehir[1]);
                    cmbNereye.Items.Add(sehir[1]);
                }
                else if (sayac1 == 0 && sayac2 == 1)
                {
                    cmbNereden.Items.Add(sehir[0]);
                    cmbNereye.Items.Add(sehir[0]);
                }
            }
        }
        private void btnSeferleriListele_Click(object sender, EventArgs e)
        {
            //Verilerin Doğru olup olmadığının kontrol edilmesi.
            if (Tools.Sorgula(grpBilet))
            {
                if (cmbNereden.SelectedItem != cmbNereye.SelectedItem)
                {
                    if (dtpGidisTarihi.Value.Day >= DateTime.Now.Day)
                    {
                        if (dtpDonusTarihi.Enabled != true)
                        {
                            ToplananVerileriDoldur();
                            
                            frmSeferler frmSeferler = new frmSeferler(this);
                            Hide();
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
                        else if (dtpDonusTarihi.Enabled == true && dtpDonusTarihi.Value > dtpGidisTarihi.Value)
                        {
                            ToplananVerileriDoldur();
                            donusTarihi = dtpDonusTarihi.Value;
                            frmSeferler frmSeferler = new frmSeferler(this);
                            Hide();
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
                        else
                        {
                            MessageBox.Show("Dönüş tarihi gidiş tarihinden önce veya eşit olamaz...");
                        }
                    }
                    else
                        MessageBox.Show("Lütfen gidiş tarihinin doğru olduğundan emin olunuz...");

                }
                else
                {
                    MessageBox.Show("Nereden ve nereye şehirleri aynı olamaz...");
                }
            }
            else
                MessageBox.Show("Bütün alanların doğru seçildiğinden emin olunuz...");
        }

        private void ToplananVerileriDoldur()
        {
            gidisTarihi = dtpGidisTarihi.Value;
            nereden = cmbNereden.SelectedItem.ToString();
            nereye = cmbNereye.SelectedItem.ToString();
            yolcuSayisi = (int)nmrYolcuSayisi.Value;
            yolcuTipi = cmbTip.SelectedItem.ToString();
        }

        private void rdbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            dtpDonusTarihi.Enabled = true;
            ciftMi = true;
        }

        private void rdbTekyon_CheckedChanged(object sender, EventArgs e)
        {
            dtpDonusTarihi.Enabled = false;
            ciftMi = false;
        }
    }
}
