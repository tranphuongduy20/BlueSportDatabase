using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ProductMapSizeConfig : IEntityTypeConfiguration<ProductMapSize>
    {
        public void Configure(EntityTypeBuilder<ProductMapSize> builder)
        {
            builder.ToTable("ProductMapSizes");
            builder.HasKey(t => new { t.productId, t.sizeId });
            builder.HasOne(x => x.product).WithMany(x => x.productMapSizes).HasForeignKey(x => x.productId);
            builder.HasOne(x => x.size).WithMany(x => x.productMapSizes).HasForeignKey(x => x.sizeId);
        }
    }
}
