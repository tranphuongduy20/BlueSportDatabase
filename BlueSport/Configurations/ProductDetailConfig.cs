using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable("ProductDetails");
            builder.HasKey(x => x.id);
            builder.Property(x => x.detail).IsRequired();
            builder.HasOne(x => x.product).WithMany(x => x.productDetails).HasForeignKey(x => x.productId);
        }
    }
}
