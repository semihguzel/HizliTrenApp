using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class Sefer
    {
        public int SeferID { get; set; }
        public string SeferYonu { get; set; }
        public string TahminiVarisSuresi { get; set; }
        public byte YolcuKapasitesi { get; set; }


        public virtual List<SeferSeferSaat> SeferinSaatleri { get; set; }
    }
}
