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

        private void frmKoltukSecimi_Load(object sender, EventArgs e)
        {
            KoltuklariOlustur();
        }

        private void KoltuklariOlustur()
        {
            PictureBox pb1;
            PictureBox pb2;
            Label lbl1;
            Label lbl2;
            for (int i = 0; i < 4; i++)
            {
                pb1 = new PictureBox();
                lbl1 = new Label();
                BusinessKoltuk(pb1, lbl1);
                pb1.Name = "B" + i;
                lbl1.Text = pb1.Name;
                grpBusiness1.Controls.Add(pb1);
                grpBusiness1.Controls.Add(lbl1);
                if (i < 4)
                {
                    pb1.Location = new Point((i * 60) + 13, 10);
                    lbl1.Location = new Point(pb1.Location.X, pb1.Height + 7);
                }
                else
                {
                    pb1.Location = new Point(lbl1.loca, lbl1.);
                }
            }
        }

        private void BusinessKoltuk(PictureBox pb, Label lbl)
        {
            pb.Width = 40;
            pb.Height = 20;
            pb.BackColor = Color.Crimson;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Width = pb.Width;
            lbl.Height = 15;
        }
    }
}
