using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Octy.Persistence;

public class OctyDbContextFactory 
    : IDesignTimeDbContextFactory<OctyDbContext>
{
    public OctyDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<OctyDbContext>();
        var connectionString = configuration
            .GetConnectionString("OctyConnectionString");

        builder.UseSqlServer(connectionString);

        return new OctyDbContext(builder.Options);
    }
}