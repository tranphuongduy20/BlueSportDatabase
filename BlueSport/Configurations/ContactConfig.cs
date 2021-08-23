using BlueSport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport.Configurations
{
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.id);
            builder.Property(x => x.title).IsRequired();
            builder.Property(x => x.content).IsRequired();
            builder.Property(x => x.cusEmail).IsRequired();
            builder.Property(x => x.cusEmail).IsRequired();
            builder.Property(x => x.cusPhone).IsRequired();
            builder.HasOne(x => x.topic).WithMany(x => x.contacts).HasForeignKey(x => x.topicId);
        }
    }
}
