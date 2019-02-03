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
            _seferSaatleriDal = new SeferSaatleriDal();
            _biletBilgiDal = new BiletBilgiDal();
        }

        private SeferlerDal _seferlerDal;
        private SeferlerSeferSaatleriDal _seferlerSeferSaatleriDal;
        private SeferSaatleriDal _seferSaatleriDal;
        private BiletBilgiDal _biletBilgiDal;
        List<SeferSeferSaat> gdsSeferSeferSaatleri;
        List<SeferSeferSaat> dnsSeferSeferSaatleri;
        Sefer gdsSefer;
        List<SeferSaat> seferSaatleri;
        Sefer dnsSefer;

        private void frmSeferler_Load(object sender, EventArgs e)
        {
            dnsSefer = new Sefer();
            dnsSefer = _seferlerDal.GetSeferIDByFilter(gelenForm.nereye, gelenForm.nereden);
            gdsSefer = new Sefer();
            gdsSefer = _seferlerDal.GetSeferIDByFilter(gelenForm.nereden, gelenForm.nereye);
            int id1 = gdsSefer.SeferID;
            int id2 = dnsSefer.SeferID;

            seferSaatleri = new List<SeferSaat>();
            seferSaatleri = _seferSaatleriDal.GetAll();

            gdsSeferSeferSaatleri = new List<SeferSeferSaat>();
            gdsSeferSeferSaatleri = _seferlerSeferSaatleriDal.GetBySeferID(id1);

            dnsSeferSeferSaatleri = new List<SeferSeferSaat>();
            dnsSeferSeferSaatleri = _seferlerSeferSaatleriDal.GetBySeferID(id2);

            SeferleriDoldur();
        }


        private void SeferleriDoldur()
        {
            lstSeferler.Items.Clear();
            List<BiletBilgi> biletler = new List<BiletBilgi>();
            biletler = _biletBilgiDal.GetByDate(gelenForm.gidisTarihi.Date);
            int[] biletSaat = new int[] { 0, 0, 0, 0, 0 };
            foreach (var item in biletler)
            {
                if (item.SeferSaati == "09:00")
                {
                    biletSaat[0]++;
                }
                else if (item.SeferSaati == "12:00")
                {
                    biletSaat[1]++;
                }
                else if (item.SeferSaati == "15:00")
                {
                    biletSaat[2]++;
                }
                else if (item.SeferSaati == "18:00")
                {
                    biletSaat[3]++;
                }
                else if (item.SeferSaati == "21:00")
                {
                    biletSaat[4]++;
                }
            }
            int sayac = 0;
            foreach (SeferSaat item in seferSaatleri)
            {
                ListViewItem lstItem = new ListViewItem(gelenForm.nereden);
                lstItem.SubItems.Add(gelenForm.nereye);
                lstItem.SubItems.Add(gdsSefer.TahminiVarisSüresi);
                lstItem.SubItems.Add((gdsSefer.YolcuKapasitesi - biletSaat[sayac]).ToString());
                lstItem.SubItems.Add(gelenForm.gidisTarihi.ToShortDateString());
                lstItem.SubItems.Add(item.SeferSaatBilgisi);
                lstSeferler.Items.Add(lstItem);
                sayac++;
            }

            if (gelenForm.donusTarihi >= gelenForm.gidisTarihi)
            {

                List<BiletBilgi> biletler2 = new List<BiletBilgi>();
                biletler2 = _biletBilgiDal.GetByDate(gelenForm.donusTarihi.Date);
                int[] biletSaat2 = new int[] { 0, 0, 0, 0, 0 };
                foreach (var item in biletler2)
                {
                    if (item.SeferSaati == "09:00")
                    {
                        biletSaat2[0]++;
                    }
                    else if (item.SeferSaati == "12:00")
                    {
                        biletSaat2[1]++;
                    }
                    else if (item.SeferSaati == "15:00")
                    {
                        biletSaat2[2]++;
                    }
                    else if (item.SeferSaati == "18:00")
                    {
                        biletSaat2[3]++;
                    }
                    else if (item.SeferSaati == "21:00")
                    {
                        biletSaat2[4]++;
                    }
                }
                int sayac1 = 0;
                foreach (SeferSaat item in seferSaatleri)
                {
                    ListViewItem lstItem = new ListViewItem(gelenForm.nereye);
                    lstItem.SubItems.Add(gelenForm.nereden);
                    lstItem.SubItems.Add(dnsSefer.TahminiVarisSüresi);
                    lstItem.SubItems.Add((dnsSefer.YolcuKapasitesi - biletSaat2[sayac1]).ToString());
                    lstItem.SubItems.Add(gelenForm.donusTarihi.ToShortDateString());
                    lstItem.SubItems.Add(item.SeferSaatBilgisi);
                    lstSeferler.Items.Add(lstItem);
                    sayac1++;
                }
            }
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
