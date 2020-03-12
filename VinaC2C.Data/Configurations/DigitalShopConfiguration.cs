using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Configurations
{
    public class DigitalShopConfiguration : IEntityTypeConfiguration<DigitalShop>
    {
        public void Configure(EntityTypeBuilder<DigitalShop> builder)
        {
            builder.ToTable("DigitalShops");
            builder.HasKey(x => x.Id);
        }
    }
}
