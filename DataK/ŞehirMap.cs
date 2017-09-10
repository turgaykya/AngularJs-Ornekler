using Entities2;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataK
{
    public class ŞehirMap : EntityTypeConfiguration<Şehir>
    {
        public ŞehirMap()
        {
            HasKey(x => x.Id);

            Property(x => x.Ad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
        }
    }
}
