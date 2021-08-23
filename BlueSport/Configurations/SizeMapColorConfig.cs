using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class SizeMapColorConfig : IEntityTypeConfiguration<SizeMapColor>
    {
        public void Configure(EntityTypeBuilder<SizeMapColor> builder)
        {
            builder.ToTable("SizeMapColors");
            builder.HasKey(t => new { t.colorId, t.sizeId });
            builder.HasOne(x => x.size).WithMany(x => x.sizeMapColors).HasForeignKey(x => x.sizeId);
            builder.HasOne(x => x.color).WithMany(x => x.sizeMapColors).HasForeignKey(x => x.colorId);
        }
    }
}
