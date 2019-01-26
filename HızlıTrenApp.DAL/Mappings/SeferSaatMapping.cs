using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class SeferSaatMapping : EntityTypeConfiguration<SeferSaat>
    {
        public SeferSaatMapping()
        {
            HasKey(x => x.SeferSaatID);
            Property(x => x.SeferSaatBilgisi).HasMaxLength(10);

            ToTable("SeferSaatleri");
        }
    }
}
