using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Configurations
{
    public class FeatureRoleConfiguration : IEntityTypeConfiguration<FeatureRole>
    {
        public void Configure(EntityTypeBuilder<FeatureRole> builder)
        {
            builder.ToTable("FeatureRoles");
            builder.HasKey(x => x.Id);
        }
    }
}
