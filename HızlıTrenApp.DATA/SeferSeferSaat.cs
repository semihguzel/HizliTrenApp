using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class SeferSeferSaat
    {
        public int ID { get; set; }
        public int SeferID { get; set; }
        public int SeferSaatID { get; set; }

        public virtual Sefer SaatinSeferi { get; set; }
        public virtual SeferSaat SeferinSaati { get; set; }
        public virtual List<BiletBilgi> BiletlerinSeferi { get; set; }

    }
}
