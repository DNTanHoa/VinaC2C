using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VinaC2C.Data.Configurations;
using VinaC2C.Data.Models;

namespace VinaC2C.Data.Context
{
    public class VinaC2CContext : DbContext
    {
        public VinaC2CContext(DbContextOptions<VinaC2CContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; } 
    }
}
