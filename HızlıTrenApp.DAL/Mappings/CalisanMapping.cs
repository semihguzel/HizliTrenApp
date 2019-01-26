using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class CalisanMapping : EntityTypeConfiguration<Calisan>
    {
        public CalisanMapping()
        {
            HasKey(x => x.CalisanID);
            Property(x => x.Ad).HasMaxLength(30);
            Property(x => x.Soyad).HasMaxLength(30);
            Property(x => x.Adres).HasMaxLength(150);
            Property(x => x.TcNo).HasColumnType("nchar").HasMaxLength(11);
            Property(x => x.IseAlimTarihi).HasColumnType("datetime2");
            Property(x => x.DogumTarihi).HasColumnType("datetime2");

            Ignore(x => x.TamAdi);

            ToTable("Calisanlar");

            HasRequired(x => x.CalisaninUnvani).WithMany(x => x.UnvaninCalisanlari).HasForeignKey(x => x.UnvanID);


        }
    }
}
