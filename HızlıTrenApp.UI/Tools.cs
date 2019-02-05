using HızlıTrenApp.DATA;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıTrenApp.UI
{
    public class Tools
    {
        public static void FormGetir(Form anaForm, MetroForm gelenForm, GroupBox anaKutu, GroupBox kutu, bool kutuVarMi, MetroLink mlBilet)
        {
            if (!kutuVarMi)
            {

                foreach (Control item in anaForm.Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control group in item.Controls)
                        {
                            if (group is GroupBox)
                            {
                                if (group.Name == "kutu")
                                    kutuVarMi = true;
                            }
                        }
                        if (!kutuVarMi)
                        {
                            kutu = new GroupBox();
                            kutuVarMi = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (MetroForm item in kutu.Controls)
                {
                    kutu.Controls.Remove(item);
                }
            }
            kutu.Location = new Point((anaForm.Width - gelenForm.Width) / 2, (anaForm.Height - gelenForm.Height) / 2);
            kutu.Text = "";
            kutu.Width = gelenForm.Width;
            kutu.Height = gelenForm.Height;
            anaKutu.Controls.Add(kutu);
            kutu.Location = new Point(0, (mlBilet.Height + (mlBilet.Top * 2)));
            kutu.Left = (anaKutu.Right - kutu.Right) / 2;
            gelenForm.MdiParent = anaForm;
            kutu.Controls.Add(gelenForm);
            gelenForm.Show();
            gelenForm.Location = Point.Empty;
        }

        public static void FormKontrolluGetir(Form anaForm, MetroForm gelenForm, GroupBox anaKutu, GroupBox kutu, bool istasyonMu, MetroLink mlBilet, MetroLink mlIstasyonTren)
        {
            Form kutuIciForm = null;
            foreach (Control item in anaKutu.Controls)
            {
                foreach (MetroForm form in item.Controls)
                {
                    if (form.Name == gelenForm.Name)
                        istasyonMu = true;
                    else
                    {
                        kutuIciForm = form;
                        break;
                    }
                }
            }
            if (!istasyonMu)
            {

                Tools.FormGetir(anaForm, gelenForm, anaKutu, kutu, istasyonMu, mlBilet);
                mlBilet.Style = MetroColorStyle.Black;
                mlIstasyonTren.Style = MetroColorStyle.Blue;
            }
        }

        public static bool Sorgula(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {

                if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1) return false;
                }
            }
            return true;
        }

        public static string PNRNoYap(BiletBilgi biletBilgi)
        {
            string koltukNo = biletBilgi.KoltukNo;
            string tarih = string.Format($"{biletBilgi.BiletTarihi,0:MM/dd/yy}");

            string t1 = tarih.Substring(0, 2);
            string t2 = tarih.Substring(3, 2);
            string t3 = tarih.Substring(6, 2);
            string sonuc = t1 + t2 + t3 + koltukNo;

            return sonuc;
        }
    }
}
