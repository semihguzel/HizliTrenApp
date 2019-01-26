using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class SatilanBiletMapping : EntityTypeConfiguration<SatilanBilet>
    {
        public SatilanBiletMapping()
        {
            HasKey(x => x.SatilanID);
            Property(x => x.SatisTarihi).HasColumnType("datetime2");

            ToTable("SatilanBiletler");

            HasRequired(x => x.SatinAlanMusteri).WithMany(x => x.SatinAlinanlarinMusterisi).HasForeignKey(x => x.MusteriID);
            HasRequired(x => x.SatinAlinanBilet).WithMany(x => x.SatilanBiletler).HasForeignKey(x => x.BiletID);
        }
    }
}
