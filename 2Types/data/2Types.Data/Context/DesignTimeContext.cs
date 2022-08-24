using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Types.Data.Context
{
    public class DesignTimeContext : IDesignTimeDbContextFactory<_2TypesDbContext>
    {
        public _2TypesDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                        .SetBasePath(System.IO.Path.Combine(Directory.GetCurrentDirectory()))
                        .AddJsonFile("appsettings.json", false, true).Build().GetSection("MigrationConnectionString").Value;

            var optionsBuilder = new DbContextOptionsBuilder<_2TypesDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new _2TypesDbContext(optionsBuilder.Options);
        }
    }
}