using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class RezerveBiletMapping : EntityTypeConfiguration<RezerveBilet>
    {
        public RezerveBiletMapping()
        {
            HasKey(x => x.RezerveID);
            Property(x => x.RezerveTarihi).HasColumnType("datetime2");

            ToTable("RezerveBiletler");

            HasRequired(x => x.RezerveAlanMusteri).WithMany(x => x.RezerveAlinanlarinMusterisi).HasForeignKey(x => x.MusteriID);
            HasRequired(x => x.RezerveAlinanBilet).WithMany(x => x.RezerveBiletler).HasForeignKey(x => x.BiletID);
        }
    }
}
