using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.level).IsRequired();
            builder.Property(x => x.parentId).IsRequired();
            builder.Property(x => x.slug).IsRequired();
        }
    }
}
