using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Configurations
{
    public class ServiceTicketConfiguration : IEntityTypeConfiguration<ServiceTicket>
    {
        public void Configure(EntityTypeBuilder<ServiceTicket> builder)
        {
            builder.ToTable("ServiceTickets");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).HasColumnType("bigint");
        }
    }
}
