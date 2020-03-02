using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();

            var connectionString = configurationRoot.GetConnectionString("VinaC2CContext");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<User> Users { get; set; } 
    }
}
