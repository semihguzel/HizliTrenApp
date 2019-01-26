using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class UnvanMapping : EntityTypeConfiguration<Unvan>
    {
        public UnvanMapping()
        {
            HasKey(x => x.UnvanID);

            Property(x => x.UnvanAdi).HasMaxLength(50);
            Property(x => x.Maas).HasColumnType("money");

            ToTable("Unvanlar");
        }
    }
}
