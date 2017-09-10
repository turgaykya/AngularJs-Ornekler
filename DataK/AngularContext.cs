using Entities2;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataK
{
    public class AngularContext : DbContext
    {
        public AngularContext() : base("Angular")
        {

        }

        public DbSet<Şehir> Şehir { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Ürünler> Ürünler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ÜrünMap());
            modelBuilder.Configurations.Add(new ŞehirMap());
            modelBuilder.Configurations.Add(new KategoriMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}