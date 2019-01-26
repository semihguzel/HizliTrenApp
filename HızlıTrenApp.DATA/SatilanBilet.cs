using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class SatilanBilet
    {
        public int SatilanID { get; set; }
        public DateTime SatisTarihi { get; set; }

        public int BiletID { get; set; }
        public virtual Bilet SatinAlinanBilet { get; set; }

        public int MusteriID { get; set; }
        public virtual Musteri SatinAlanMusteri { get; set; }

    }
}
