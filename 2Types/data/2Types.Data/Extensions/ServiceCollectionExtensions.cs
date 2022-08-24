using _2Types.Common;
using _2Types.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
    {
        var section = configuration.GetSection($"{nameof(Settings)}:Database");
        var settings = section.Get<Settings.DatabaseConfiguration>();
        services.AddDbContext<_2TypesDbContext>(builder =>
        {
            builder.UseSqlServer(settings.ConnectionString);
        });
        services.AddScoped<DbContext, _2TypesDbContext>();
        return services;
    }
}