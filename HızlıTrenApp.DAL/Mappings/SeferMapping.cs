﻿using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class SeferMapping : EntityTypeConfiguration<Sefer>
    {
        public SeferMapping()
        {
            HasKey(x => x.SeferID);
            Property(x => x.SeferYonu).HasMaxLength(40);
            Property(x => x.YolcuKapasitesi).HasColumnType("tinyint");
            Property(x => x.TahminiVarisSuresi).HasMaxLength(15);

            ToTable("Seferler");
        }
    }
}
