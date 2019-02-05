using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class BiletMapping : EntityTypeConfiguration<Bilet>
    {
        public BiletMapping()
        {
            HasKey(x => x.BiletID);
            HasRequired(x => x.BiletinBilgisi).WithRequiredPrincipal(x => x.BilgininBileti);

            Property(x => x.PNRNo).HasMaxLength(10);

            ToTable("Biletler");
        }
    }
}
