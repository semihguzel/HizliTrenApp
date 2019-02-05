using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class MusteriMapping : EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            HasKey(x => x.MusteriID);
            Property(x => x.Ad).HasMaxLength(30);
            Property(x => x.Soyad).HasMaxLength(30);
            Property(x => x.DogumTarihi).HasColumnType("datetime2");

            Ignore(x => x.TamAdi);
            Ignore(x => x.Yas);

            ToTable("Musteriler");

            HasRequired(x => x.DetayinMusterisi).WithRequiredPrincipal(x => x.DetayinMusterisi);
        }
    }
}
