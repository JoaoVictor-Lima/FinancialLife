using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.DbServices.Interface;
using FinancialLifeInfrastructureData.DbServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class ConsoleProgram
{
    static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "FrontEnd.Server");
                config.SetBasePath(basePath)
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<FinancialLifeDbContext>(options =>
                {
                    var configuration = context.Configuration;
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                    options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
                    options.EnableSensitiveDataLogging();
                });

                services.AddScoped<IMigrationEnums, MigrationEnums>();

            })
            .Build();

        using (var scope = host.Services.CreateScope())
        {
            var migrationEnums = scope.ServiceProvider.GetRequiredService<IMigrationEnums>();
            await migrationEnums.MigrateEnums();
        }
    }
}