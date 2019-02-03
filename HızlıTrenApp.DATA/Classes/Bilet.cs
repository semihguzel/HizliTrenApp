using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class Bilet
    {
        public int BiletID { get; set; }
        public string PNRNo { get; set; }

        public virtual BiletBilgi BiletinBilgisi { get; set; }
        public virtual List<SatilanBilet> SatilanBiletler { get; set; }
        public virtual List<RezerveBilet> RezerveBiletler { get; set; }

    }
}
