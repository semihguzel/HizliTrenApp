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
    public partial class frmKoltukSecimi : MetroFramework.Forms.MetroForm
    {
        Form gelenForm;
        public frmKoltukSecimi(Form form)
        {
            InitializeComponent();
            gelenForm = form;
        }
        List<BiletBilgi> biletListesi;
        private void frmKoltukSecimi_Load(object sender, EventArgs e)
        {
            BiletBilgiDal biletBilgiDal = new BiletBilgiDal();
            biletListesi = biletBilgiDal.TicketList();
            KoltuklariOlustur();
        }

        private void KoltuklariOlustur()
        {
            //Business pb ve lbl
            PictureBox pbB1;
            PictureBox pbB2;
            Label lblB1;
            Label lblB2;
            Label lblB1Masa;
            Label lblB2Masa;

            //Business Degiskenleri

            int businessSoldanBosluk = 60;
            int businessKoltukArasi = 20;
            int businessUsttenBosluk = 20;
            int businessKoltukSayisi = 8;
            for (int i = 0; i < 8; i++)
            {
                //grpBusiness1
                pbB1 = new PictureBox();
                lblB1 = new Label();
                lblB1Masa = new Label();
                pbB1.Name = "B" + i;
                lblB1.Text = pbB1.Name;
                BusinessKoltuk(pbB1, lblB1);

                lblB1Masa.AutoSize = false;
                lblB1Masa.TextAlign = ContentAlignment.MiddleCenter;
                lblB1Masa.Width = 269;
                lblB1Masa.Height = pbB1.Height;
                lblB1Masa.Text = "MASA";
                lblB1Masa.BackColor = Color.DimGray;

                grpBusiness1.Controls.Add(lblB1Masa);
                grpBusiness1.Controls.Add(pbB1);
                grpBusiness1.Controls.Add(lblB1);

                //grpBusiness2
                pbB2 = new PictureBox();
                lblB2 = new Label();
                lblB2Masa = new Label();
                pbB2.Name = "B" + businessKoltukSayisi;
                lblB2.Text = pbB2.Name;
                businessKoltukSayisi++;
                BusinessKoltuk(pbB2, lblB2);

                lblB2Masa.AutoSize = false;
                lblB2Masa.TextAlign = ContentAlignment.MiddleCenter;
                lblB2Masa.Width = 269;
                lblB2Masa.Height = pbB1.Height;
                lblB2Masa.Text = "MASA";
                lblB2Masa.BackColor = Color.DimGray;

                grpBusiness2.Controls.Add(lblB2Masa);
                grpBusiness2.Controls.Add(pbB2);
                grpBusiness2.Controls.Add(lblB2);

                if (i < 4)
                {
                    //grpBusiness1'de ust 4 koltuk
                    pbB1.Location = new Point((i * businessSoldanBosluk) + businessKoltukArasi, businessUsttenBosluk);
                    lblB1.Location = new Point(pbB1.Location.X, pbB1.Height + businessUsttenBosluk);


                    //grpBusiness2'de ust 4 koltuk
                    pbB2.Location = new Point((i * businessSoldanBosluk) + businessKoltukArasi, businessUsttenBosluk);
                    lblB2.Location = new Point(pbB2.Location.X, pbB2.Height + businessUsttenBosluk);
                }
                else
                {
                    //grpBusiness1'de alt 4 koltuk
                    pbB1.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblB1.Height + pbB1.Height + (businessUsttenBosluk * 4));
                    lblB1.Location = new Point(pbB1.Location.X, pbB1.Location.Y + (businessUsttenBosluk * 2));

                    //grpBusiness2'de alt 4 koltuk
                    pbB2.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblB2.Height + pbB2.Height + (businessUsttenBosluk * 4));
                    lblB2.Location = new Point(pbB2.Location.X, pbB2.Location.Y + (businessUsttenBosluk * 2));
                }
                lblB1Masa.Location = new Point(0, 80);
                lblB2Masa.Location = new Point(0, 80);
            }
            //Economy pb ve lbl
            PictureBox pbE1;
            PictureBox pbE2;
            Label lblE1;
            Label lblE2;
            //Economy Degiskenleri

            int economySoldanBosluk = 60;
            int economyKoltukArasi = 20;
            int economyUsttenBosluk = 20;
            int economyLabelBosluk = 15;
            int economyKoltukSayisi = 12;
            for (int i = 0; i < 12; i++)
            {
                //grpEconomy1
                pbE1 = new PictureBox();
                lblE1 = new Label();
                pbE1.Name = "E" + i;
                lblE1.Text = pbE1.Name;
                EconomyKoltuk(pbE1, lblE1);
                grpEconomy1.Controls.Add(pbE1);
                grpEconomy1.Controls.Add(lblE1);

                //grpEconomy2
                pbE2 = new PictureBox();
                lblE2 = new Label();
                pbE2.Name = "E" + economyKoltukSayisi;
                lblE2.Text = pbE2.Name;
                economyKoltukSayisi++;
                EconomyKoltuk(pbE2, lblE2);
                grpEconomy2.Controls.Add(pbE2);
                grpEconomy2.Controls.Add(lblE2);

                if (i < 4)
                {
                    //grpEconomy1'de ust 4 koltuk
                    pbE1.Location = new Point((i * economySoldanBosluk) + economyKoltukArasi, economyUsttenBosluk);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Height + economyUsttenBosluk + 2);

                    //grpEconomy2'de ust 4 koltuk
                    pbE2.Location = new Point((i * economySoldanBosluk) + economyKoltukArasi, economyUsttenBosluk);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Height + economyUsttenBosluk + 2);
                }
                else if (i >= 4 && i < 8)
                {
                    //grpEconomy1'de orta 4 koltuk
                    pbE1.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblE1.Height + pbE1.Height + economyUsttenBosluk + 5);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Location.Y + economyUsttenBosluk + economyLabelBosluk);

                    //grpEconomy2'de orta 4 koltuk
                    pbE2.Location = new Point(((i - 4) * businessSoldanBosluk) + businessKoltukArasi, lblE2.Height + pbE2.Height + economyUsttenBosluk + 5);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Location.Y + economyUsttenBosluk + economyLabelBosluk);
                }
                else
                {
                    //grpEconomy1'de alt 4 koltuk
                    pbE1.Location = new Point(((i - 8) * businessSoldanBosluk) + businessKoltukArasi, lblE1.Height + pbE1.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + 5);
                    lblE1.Location = new Point(pbE1.Location.X, pbE1.Location.Y + economyUsttenBosluk + 15);

                    //grpEconomy2'de alt 4 koltuk
                    pbE2.Location = new Point(((i - 8) * businessSoldanBosluk) + businessKoltukArasi, lblE2.Height + pbE2.Height + economyUsttenBosluk + (economyUsttenBosluk * 3) + 5);
                    lblE2.Location = new Point(pbE2.Location.X, pbE2.Location.Y + economyUsttenBosluk + 15);
                }
            }
        }

        private void EconomyKoltuk(PictureBox pb, Label lbl)
        {
            pb.Width = 40;
            pb.Height = 30;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Width = pb.Width;
            lbl.Height = 20;
            foreach (var item in biletListesi)
            {
                if (item.KoltukNo == pb.Name && item.MusterininBileti.Cinsiyet && pb.Name.Contains("E"))
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_woman_resized_economy.png");
                else if (item.KoltukNo.Contains(pb.Name) && !item.MusterininBileti.Cinsiyet && pb.Name.Contains("E"))
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_woman_resized_economy.png");
                else
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_available_resized_economy.png");
            }
        }

        private void BusinessKoltuk(PictureBox pb, Label lbl)
        {
            pb.Width = 50;
            pb.Height = 40;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Width = pb.Width;
            lbl.Height = 15;
            foreach (var item in biletListesi)
            {
                if (item.KoltukNo == pb.Name && item.MusterininBileti.Cinsiyet == true && pb.Name.Contains("B"))
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_man_resized_business.png");
                else if (item.KoltukNo.Contains(pb.Name) && item.MusterininBileti.Cinsiyet == false && pb.Name.Contains("B"))
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_woman_resized_business.png");
                else
                    pb.Image = Image.FromFile(@"..\..\Images\Resized_Seats\seat_available_resized_business.png");
            }
        }
    }
}
