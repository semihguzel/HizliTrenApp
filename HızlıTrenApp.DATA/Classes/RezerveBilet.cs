using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class RezerveBilet
    {
        public int RezerveID { get; set; }
        public DateTime RezerveTarihi { get; set; }
        public bool IsBought { get; set; }

        public int BiletID { get; set; }
        public virtual Bilet RezerveAlinanBilet { get; set; }

        public int MusteriID { get; set; }
        public virtual Musteri RezerveAlanMusteri { get; set; }
    }
}
