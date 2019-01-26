using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class Unvan
    {
        public int UnvanID { get; set; }
        public string UnvanAdi { get; set; }
        public decimal Maas { get; set; }

        public virtual List<Calisan> UnvaninCalisanlari { get; set; }
    }
}
