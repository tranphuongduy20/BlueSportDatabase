using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ProductImageConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(x => x.id);
            builder.Property(x => x.path).IsRequired();
            builder.Property(x => x.alt).IsRequired();
            builder.HasOne(x => x.product).WithMany(x => x.productImages).HasForeignKey(x => x.productId);
        }
    }
}
