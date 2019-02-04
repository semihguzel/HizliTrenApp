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
        //Gidiş ve dönüş seferleri listviewdeki sıraya göre listeye doldurulmuştur.
        public List<string> secilenGidisSeferi;
        public List<string> secilenDonusSeferi;

        private void frmSeferler_Load(object sender, EventArgs e)
        {
            secilenGidisSeferi = new List<string>();
            if (gelenForm.ciftMi)
            {
                secilenDonusSeferi = new List<string>();
            }
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
            lstSeferlerGidis.Items.Clear();

            List<BiletBilgi> biletler = new List<BiletBilgi>();
            biletler = _biletBilgiDal.GetByDate(gelenForm.gidisTarihi.Date);
            int[] biletSaat = new int[] { 0, 0, 0, 0, 0 };

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

            int sayac = 0;
            foreach (SeferSaat item in seferSaatleri)
            {
                int kapasite = 0;
                ListViewItem lstItem = new ListViewItem(gelenForm.nereden);
                lstItem.SubItems.Add(gelenForm.nereye);
                lstItem.SubItems.Add(gdsSefer.TahminiVarisSuresi);
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
                    lstItem.SubItems.Add((kapasite).ToString());
                    lstItem.SubItems.Add(gelenForm.gidisTarihi.ToShortDateString());
                    int saat = Convert.ToInt32(item.SeferSaatBilgisi.Substring(0, 2));
                    if (saat <= DateTime.Now.Hour && gelenForm.gidisTarihi.Date == DateTime.Now.Date) continue;
                    lstItem.SubItems.Add(item.SeferSaatBilgisi);
                    lstSeferlerGidis.Items.Add(lstItem);
                }
                sayac++;
            }


            if (gelenForm.ciftMi)
            {
                lstSeferlerDonus.Items.Clear();
                List<BiletBilgi> biletler2 = new List<BiletBilgi>();
                biletler2 = _biletBilgiDal.GetByDate(gelenForm.donusTarihi.Date);
                int[] biletSaat2 = new int[] { 0, 0, 0, 0, 0 };
                foreach (var item in biletler2)
                {
                    if (item.BiletTipi == gelenForm.yolcuTipi)
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
                }
                int sayac1 = 0;
                foreach (SeferSaat item in seferSaatleri)
                {
                    int kapasite = 0;
                    ListViewItem lstItem = new ListViewItem(gelenForm.nereye);
                    lstItem.SubItems.Add(gelenForm.nereden);
                    lstItem.SubItems.Add(dnsSefer.TahminiVarisSuresi);
                    if (gelenForm.yolcuTipi == "Economy")
                    {
                        kapasite = 24;
                    }
                    else
                    {
                        kapasite = 16;
                    }
                    kapasite = kapasite - biletSaat2[sayac1];
                    if (kapasite >= gelenForm.yolcuSayisi)
                    {
                        lstItem.SubItems.Add((kapasite).ToString());
                        lstItem.SubItems.Add(gelenForm.donusTarihi.ToShortDateString());
                        int saat = Convert.ToInt32(item.SeferSaatBilgisi.Substring(0, 2));
                        if (saat <= DateTime.Now.Hour && gelenForm.donusTarihi.Date == DateTime.Now.Date) continue;
                        lstItem.SubItems.Add(item.SeferSaatBilgisi);
                        lstSeferlerDonus.Items.Add(lstItem);
                    }
                    sayac1++;
                }
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (secilenGidisSeferi.Count>0)
            {
                if (gelenForm.ciftMi && secilenDonusSeferi.Count>0)
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
                else
                {
                    MessageBox.Show("Lütfen Bir Dönüş Seferi Seçiniz...");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Gidiş Seferi Seçiniz...");
            }
            
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
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

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (gelenForm.donusTarihi.Day == gelenForm.gidisTarihi.Day)
            {
                MessageBox.Show("Gidiş tarihi dönüş tarihinden sonra olamaz!");
            }
            else
            {
                gelenForm.gidisTarihi = gelenForm.gidisTarihi.Date.AddDays(1);
                SeferleriDoldur();
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (gelenForm.gidisTarihi.Day > DateTime.Now.Day)
            {
                gelenForm.gidisTarihi = gelenForm.gidisTarihi.Date.AddDays(-1);
                SeferleriDoldur();
            }
            else
            {
                MessageBox.Show("Şimdiki tarihten önceki seferleri görüntülenmemektedir.");
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
    }
}
