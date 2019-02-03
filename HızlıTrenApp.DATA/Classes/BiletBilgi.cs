using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class BiletBilgi
    {
        public int BiletBilgiID { get; set; }
        public DateTime AlimTarihi { get; set; }
        public string BiletTipi { get; set; }
        public string KoltukNo { get; set; }
        public decimal BiletFiyati { get; set; }

        public virtual Bilet BilgininBileti { get; set; }

        public int MusteriID { get; set; }
        public virtual Musteri MusterininBileti { get; set; }

        public int SeferSeferSaatID { get; set; }
        public virtual SeferSeferSaat SeferinBileti { get; set; }
    }
}
