using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class MusteriDetayMapping : EntityTypeConfiguration<MusteriDetay>
    {
        public MusteriDetayMapping()
        {
            HasKey(x => x.MusteriDetayID);
            Property(x => x.Adres).HasMaxLength(150);
            Property(x => x.Telefon).HasColumnType("nchar").HasMaxLength(15);
            Property(x => x.Email).HasMaxLength(30);

            ToTable("MusteriDetaylari");
        }
    }
}
