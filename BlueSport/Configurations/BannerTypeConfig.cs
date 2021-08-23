using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class BannerTypeConfig : IEntityTypeConfiguration<BannerType>
    {
        public void Configure(EntityTypeBuilder<BannerType> builder)
        {
            builder.ToTable("BannerTypes");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
        }
    }
}
