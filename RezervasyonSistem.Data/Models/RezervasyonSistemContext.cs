using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistem.Data.Models
{
    public class RezervasyonSistemContext : DbContext
    {

        public DbSet<Oda> Odalar { get; set; }
        public DbSet<OdaResimleri> OdaResimleri { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriOdaMapping> MusteriOdaMappingler { get; set; }
        public DbSet<AdminUser> AdminUserlar { get; set; }
        public RezervasyonSistemContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-VL74U27;Database=RezervasyonSistemi;User Id=sa; Password=Password1;MultipleActiveResultSets=True";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            
            Database.SetInitializer<RezervasyonSistemContext>(new CreateDatabaseIfNotExists<RezervasyonSistemContext>());
        }
    }
}
