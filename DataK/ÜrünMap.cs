using Entities2;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataK
{
    public class ÜrünMap : EntityTypeConfiguration<Ürünler>
    {
        public ÜrünMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Ad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            HasRequired(x => x.Kategori).WithMany(x => x.Ürünler).HasForeignKey(x => x.KategoriId).WillCascadeOnDelete(false);

            HasRequired(x => x.Şehir).WithMany(x => x.Ürünler).HasForeignKey(x => x.ŞehirId).WillCascadeOnDelete(false);
        }
    }
}
