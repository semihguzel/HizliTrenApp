using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class SeferSaat
    {
        public int SeferSaatID { get; set; }
        public string SeferSaatBilgisi { get; set; }

        public virtual List<SeferSeferSaat> SaatinSeferleri { get; set; }
    }
}
