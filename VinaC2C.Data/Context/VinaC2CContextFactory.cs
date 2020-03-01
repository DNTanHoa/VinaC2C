using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VinaC2C.Data.Context
{
    public class VinaC2CContextFactory : IDesignTimeDbContextFactory<VinaC2CContext>
    {
        public VinaC2CContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Directory.GetCurrentDirectory())
                                                        .AddJsonFile("appsettings.json")
                                                        .Build();

            var connectionString = configurationRoot.GetConnectionString("VinaC2CContext");
            var optionsBuilder = new DbContextOptionsBuilder<VinaC2CContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new VinaC2CContext(optionsBuilder.Options);
        }
    }
}
