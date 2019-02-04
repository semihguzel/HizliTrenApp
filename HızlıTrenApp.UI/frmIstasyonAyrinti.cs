using HızlıTrenApp.DAL.Repository.Concrete;
using HızlıTrenApp.DATA;
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
    public partial class frmIstasyonAyrinti : MetroFramework.Forms.MetroForm
    {
        public frmIstasyonAyrinti(frmIstasyonTrenBilgileri frmIstasyonTrenBilgileri)
        {
            InitializeComponent();
            gelenForm = frmIstasyonTrenBilgileri;
            _seferlerDal = new SeferlerDal();
            _seferSaatleri = new SeferSaatleriDal();
        }
        frmIstasyonTrenBilgileri gelenForm;
        SeferlerDal _seferlerDal;
        SeferSaatleriDal _seferSaatleri;
        List<Sefer> seferler;
        List<SeferSaat> seferSaatleri;

        private void frmIstasyonAyrinti_Load(object sender, EventArgs e)
        {
            ListeyiDoldur(1, gelenForm.istasyon);
        }

        private void ListeyiDoldur(int secim, string istasyon)
        {
            lstIstasyonSeferleri.Items.Clear();
            seferSaatleri = new List<SeferSaat>();
            seferSaatleri = _seferSaatleri.GetAll();
            seferler = new List<Sefer>();
            if (secim == 1)
            {
                seferler = _seferlerDal.GetSeferlerByStartWith(istasyon);
            }
            else if (secim == 2)
            {
                seferler = _seferlerDal.GetSeferlerByEndWith(istasyon);
            }

            foreach (var item in seferler)
            {
                foreach (var items in seferSaatleri)
                {
                    string[] kalkisVaris = item.SeferYonu.Split('-');
                    ListViewItem lstItem = new ListViewItem();
                    lstItem.Text = kalkisVaris[0];
                    lstItem.SubItems.Add(kalkisVaris[1]);
                    lstItem.SubItems.Add(items.SeferSaatBilgisi);
                    lstItem.SubItems.Add(item.TahminiVarisSuresi);
                    lstItem.SubItems.Add(gelenForm.tarih.ToShortDateString());
                    lstIstasyonSeferleri.Items.Add(lstItem);
                }
            }
        }

        private void btnVaris_Click(object sender, EventArgs e)
        {
            ListeyiDoldur(2, gelenForm.istasyon);
        }

        private void btnKalkis_Click(object sender, EventArgs e)
        {
            ListeyiDoldur(1, gelenForm.istasyon);
        }

        private void frmIstasyonAyrinti_FormClosed(object sender, FormClosedEventArgs e)
        {
            gelenForm.Show();
        }
    }
}
