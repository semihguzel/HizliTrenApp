using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TamAdi
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

        public virtual MusteriDetay DetayinMusterisi { get; set; }
        public virtual List<BiletBilgi> BiletlerinMusterisi { get; set; }
        public virtual List<SatilanBilet> SatinAlinanlarinMusterisi { get; set; }
        public virtual List<RezerveBilet> RezerveAlinanlarinMusterisi { get; set; }


    }
}
