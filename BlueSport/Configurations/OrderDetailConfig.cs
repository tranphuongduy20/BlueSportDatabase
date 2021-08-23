using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("Banners");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.image).IsRequired();
            builder.Property(x => x.alt).IsRequired();
            builder.Property(x => x.text).IsRequired();
            builder.HasOne(x => x.type).WithMany(x => x.banners).HasForeignKey(x => x.typeId);
        }
    }
}
