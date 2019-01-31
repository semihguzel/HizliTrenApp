using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DATA
{
    public class Calisan
    {
        public int CalisanID { get; set; }
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public bool Cinsiyet { get; set; }  
        public DateTime DogumTarihi { get; set; }
        public DateTime IseAlimTarihi { get; set; }
        public string TamAdi
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
        public int UnvanID { get; set; }
        public virtual Unvan CalisaninUnvani { get; set; }
    }
}
