using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Configurations
{
    public class DigitalShopRoleConfiguration : IEntityTypeConfiguration<DigitalShopRole>
    {
        public void Configure(EntityTypeBuilder<DigitalShopRole> builder)
        {
            builder.ToTable("DigitalShopRoles");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).HasColumnType("bigint");
            builder.Property(p => p.DigitalShopID).HasColumnType("bigint");
            builder.Property(p => p.UserID).HasColumnType("bigint");
        }
    }
}
