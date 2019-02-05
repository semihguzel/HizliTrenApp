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
            _seferSaatleriDal = new SeferSaatleriDal();
            _biletBilgiDal = new BiletBilgiDal();
        }

        private SeferlerDal _seferlerDal;
        private SeferSaatleriDal _seferSaatleriDal;
        private BiletBilgiDal _biletBilgiDal;
        Sefer gdsSefer;
        List<SeferSaat> seferSaatleri;

        //Gidiş ve dönüş seferleri listviewdeki sıraya göre listeye doldurulmuştur.
        public List<string> secilenGidisSeferi;
        public List<string> secilenDonusSeferi;

        private void frmSeferler_Load(object sender, EventArgs e)
        {
            secilenGidisSeferi = new List<string>();
            lstSeferlerDonus.Enabled = false;
            if (gelenForm.ciftMi)
            {
                secilenDonusSeferi = new List<string>();
                lstSeferlerDonus.Enabled = true;
            }
            gdsSefer = new Sefer();
            gdsSefer = _seferlerDal.GetSeferIDByFilter(gelenForm.nereden, gelenForm.nereye);
            int id1 = gdsSefer.SeferID;

            seferSaatleri = new List<SeferSaat>();
            seferSaatleri = _seferSaatleriDal.GetAll();

            SeferleriDoldur();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            //Burada bir sonraki sayfaya geçmeden önce seferin gidiş ve dönüş bilgilerinin dolu olup olmadığını kontrol ettiriyorum.
            if (secilenGidisSeferi.Count > 0)
            {
                if (gelenForm.ciftMi)
                {
                    if (secilenDonusSeferi.Count > 0)
                    {
                        KoltukSecimiFormunaGecis();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bir Dönüş Seferi Seçiniz...");
                    }
                }
                else
                {
                    KoltukSecimiFormunaGecis();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gidiş Seferi Seçiniz...");
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfayaGec();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (gelenForm.donusTarihi.Day == gelenForm.gidisTarihi.Day)
            {
                MessageBox.Show("Gidiş tarihi dönüş tarihinden sonra olamaz!");
                btnIleri.Enabled = false;
            }
            else
            {
                gelenForm.gidisTarihi = gelenForm.gidisTarihi.Date.AddDays(1);
                SeferleriDoldur();
                btnGeri.Enabled = true;
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (gelenForm.gidisTarihi.Day > DateTime.Now.Day)
            {
                gelenForm.gidisTarihi = gelenForm.gidisTarihi.Date.AddDays(-1);
                SeferleriDoldur();
                btnIleri.Enabled = true;
            }
            else
            {
                MessageBox.Show("Şimdiki tarihten önceki seferleri görüntülenmemektedir.");
                btnGeri.Enabled = false;
            }
        }

        private void lstSeferlerGidis_MouseClick(object sender, MouseEventArgs e)
        {
            secilenGidisSeferi.Clear();
            secilenGidisSeferi.AddRange(ListeleriDoldur(secilenGidisSeferi, lstSeferlerGidis));
        }

        private void lstSeferlerDonus_MouseClick(object sender, MouseEventArgs e)
        {
            secilenDonusSeferi.Clear();
            secilenDonusSeferi.AddRange(ListeleriDoldur(secilenDonusSeferi, lstSeferlerDonus));
        }

        private void frmSeferler_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfayaGec();
        }

        //Bu metodda gidiş ve dönüş seferleri olan ana veriler toplanıp, daha sonra dinamik bir metod olan SeferleriDoldur2() methoduna gönderdik.
        private void SeferleriDoldur()
        {

            List<BiletBilgi> biletler = new List<BiletBilgi>();
            biletler = _biletBilgiDal.GetByDate(gelenForm.gidisTarihi.Date);
            int[] biletSaat = new int[] { 0, 0, 0, 0, 0 };
            biletSaat = BiletSayilariniHesapla(biletler, biletSaat);

            SeferleriDoldur2(ref lstSeferlerGidis, biletSaat, gelenForm.gidisTarihi, gelenForm.nereden, gelenForm.nereye);

            if (gelenForm.ciftMi)
            {
                List<BiletBilgi> biletler2 = new List<BiletBilgi>();
                biletler2 = _biletBilgiDal.GetByDate(gelenForm.donusTarihi.Date);
                int[] biletSaat2 = new int[] { 0, 0, 0, 0, 0 };
                biletSaat2 = BiletSayilariniHesapla(biletler2, biletSaat2);

                SeferleriDoldur2(ref lstSeferlerDonus, biletSaat2, gelenForm.donusTarihi, gelenForm.nereye, gelenForm.nereden);
            }
        }

        public void SeferleriDoldur2(ref ListView listView, int[] biletSaat, DateTime seferTarihi, string nereden, string nereye)
        {
            listView.Items.Clear();
            int sayac = 0;
            foreach (SeferSaat item in seferSaatleri)
            {
                int kapasite = 0;
                ListViewItem lvi = new ListViewItem(nereden);
                lvi.SubItems.Add(nereye);
                lvi.SubItems.Add(gdsSefer.TahminiVarisSuresi);
                if (gelenForm.yolcuTipi == "Economy")
                {
                    kapasite = 24;
                }
                else
                {
                    kapasite = 16;
                }
                kapasite = kapasite - biletSaat[sayac];
                if (kapasite >= gelenForm.yolcuSayisi)
                {
                    lvi.SubItems.Add(kapasite.ToString());
                    lvi.SubItems.Add(seferTarihi.ToShortDateString());
                    int saat = Convert.ToInt32(item.SeferSaatBilgisi.Substring(0, 2));
                    if (saat <= DateTime.Now.Hour && seferTarihi.Date == DateTime.Now.Date)
                    {
                        sayac++;
                        continue;
                    } 
                    lvi.SubItems.Add(item.SeferSaatBilgisi);
                    listView.Items.Add(lvi);
                }
                sayac++;
            }
        }

        //Seçilen seferin Verilerini doldurmak için böyle bir metod yazıldı.
        private List<string> ListeleriDoldur(List<string> liste, ListView lst)
        {
            int sayac = 0;
            foreach (var item in lst.FocusedItem.SubItems)
            {
                liste.Add(lst.FocusedItem.SubItems[sayac].Text);
                sayac++;
            }
            return liste;
        }

        //Bu metod sayesinde gidiş ve dönüş biletlerini saatlerini göre gruplandırarak sayısını hesapladık.
        public int[] BiletSayilariniHesapla(List<BiletBilgi> biletler, int[] biletSaat)
        {
            foreach (var item in biletler)
            {
                if (item.BiletTipi == gelenForm.yolcuTipi)
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
            }
            return biletSaat;
        }

        //Ana Sayfaya Geçiş Kodlarını method haline getirdim.
        private void AnaSayfayaGec()
        {
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

        //Koltuk Seçimi formuna geçiş kodlarını metod haline getirdim.
        private void KoltukSecimiFormunaGecis()
        {
            frmKoltukSecimi gelenForm2 = new frmKoltukSecimi(this);
            Hide();
            GroupBox kutu = (GroupBox)this.Parent;
            Form anaForm = (Form)kutu.Parent.Parent;
            gelenForm2.Width = kutu.Width;
            gelenForm2.Height = kutu.Height;
            gelenForm2.MdiParent = anaForm;
            kutu.Controls.Remove(this);
            kutu.Controls.Add(gelenForm2);
            gelenForm2.Show();
            gelenForm2.Location = Point.Empty;
        }
    }
}
