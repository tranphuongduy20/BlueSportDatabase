using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ProductMapCateConfig : IEntityTypeConfiguration<ProductMapCate>
    {
        public void Configure(EntityTypeBuilder<ProductMapCate> builder)
        {
            builder.ToTable("ProductMapCates");
            builder.HasKey(t => new { t.productId, t.cateId });
            builder.HasOne(x => x.category).WithMany(x => x.productMapCates).HasForeignKey(x => x.cateId);
            builder.HasOne(x => x.product).WithMany(x => x.productMapCates).HasForeignKey(x => x.productId);
        }
    }
}
