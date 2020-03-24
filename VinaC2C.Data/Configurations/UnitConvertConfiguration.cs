using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Configurations
{
    public class UnitConvertConfiguration : IEntityTypeConfiguration<UnitConvert>
    {
        public void Configure(EntityTypeBuilder<UnitConvert> builder)
        {
            builder.ToTable("UnitConverts");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).HasColumnType("bigint");
        }
    }
}
