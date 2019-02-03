using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class BiletBilgiMapping : EntityTypeConfiguration<BiletBilgi>
    {
        public BiletBilgiMapping()
        {
            HasKey(x => x.BiletBilgiID);
            Property(x => x.KoltukNo).HasColumnType("tinyint");
            Property(x => x.AlimTarihi).HasColumnType("datetime2");
            Property(x => x.BiletFiyati).HasColumnType("money");
            Property(x => x.BiletTarihi).HasColumnType("datetime2");
            Property(x => x.SeferSaati).HasColumnType("nvarchar").HasMaxLength(5);

            ToTable("BiletBilgileri");
            
            HasRequired(x => x.MusterininBileti).WithMany(x => x.BiletlerinMusterisi).HasForeignKey(x => x.MusteriID);
            HasRequired(x => x.SeferinBileti).WithMany(x => x.BiletlerinSeferi).HasForeignKey(x => x.SeferSeferSaatID);
        }
    }
}
