using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class PromotionDetailConfig : IEntityTypeConfiguration<PromotionDetail>
    {
        public void Configure(EntityTypeBuilder<PromotionDetail> builder)
        {
            builder.ToTable("PromotionDetails");
            builder.HasKey(x => x.id);
            builder.Property(x => x.info).IsRequired();
            builder.Property(x => x.isOnline).IsRequired();
            builder.Property(x => x.isMore).IsRequired();
            builder.HasOne(x => x.promotion).WithMany(x => x.promotionDetails).HasForeignKey(x => x.promotionId);
        }
    }
}
