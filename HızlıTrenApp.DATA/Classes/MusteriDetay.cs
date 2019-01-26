using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class MusteriDetay
    {
        public int MusteriDetayID { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public virtual Musteri DetayinMusterisi { get; set; }

    }
}
