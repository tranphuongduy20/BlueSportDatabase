using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.slug).IsRequired();
            builder.Property(x => x.priceCurrent).IsRequired();
            builder.Property(x => x.priceOld).IsRequired();
            builder.Property(x => x.saleOff).IsRequired();
            builder.Property(x => x.description).IsRequired();
            builder.Property(x => x.isSoldOut).IsRequired();
            builder.Property(x => x.installment).IsRequired();
            builder.HasOne(x => x.brand).WithMany(x => x.products).HasForeignKey(x => x.brandId);
        }
    }
}
