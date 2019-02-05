using HızlıTrenApp.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HızlıTrenApp.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server=.; database = HizliTrenDb; uid = sa; pwd = 123";
        }
        //saasdasd
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<BiletBilgi> BiletBilgileri { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriDetay> MusteriDetaylari { get; set; }
        public DbSet<RezerveBilet> RezerveBiletler { get; set; }
        public DbSet<SatilanBilet> SatilanBiletler { get; set; }
        public DbSet<Sefer> Seferler { get; set; }
        public DbSet<SeferSaat> SeferSaatleri { get; set; }
        public DbSet<SeferSeferSaat> SeferSeferSaatleri { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BiletMapping());
            modelBuilder.Configurations.Add(new BiletBilgiMapping());
            modelBuilder.Configurations.Add(new SatilanBiletMapping());
            modelBuilder.Configurations.Add(new RezerveBiletMapping());

            modelBuilder.Configurations.Add(new CalisanMapping());
            modelBuilder.Configurations.Add(new UnvanMapping());

            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new MusteriDetayMapping());
            modelBuilder.Configurations.Add(new SeferMapping());
            modelBuilder.Configurations.Add(new SeferSaatMapping());
            modelBuilder.Configurations.Add(new SeferSeferSaatMapping());



            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
