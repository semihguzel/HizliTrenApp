using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class SeferSeferSaatMapping : EntityTypeConfiguration<SeferSeferSaat>
    {
        public SeferSeferSaatMapping()
        {
            HasKey(x => x.ID);

            HasRequired(x => x.SaatinSeferi).WithMany(x => x.SeferinSaatleri).HasForeignKey(x => x.SeferID);
            HasRequired(x => x.SeferinSaati).WithMany(x => x.SaatinSeferleri).HasForeignKey(x => x.SeferSaatID);

            ToTable("SeferlerSeferSaatleri");
        }
    }
}
