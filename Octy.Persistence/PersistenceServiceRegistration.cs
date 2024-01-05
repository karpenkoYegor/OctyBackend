using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Octy.Application.Contracts.Persistence;
using Octy.Persistence.Repositories;

namespace Octy.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OctyDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("OctyConnectionString"));
        });
        
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        
        services.AddScoped<IChapterRepository, ChapterRepository>();
        services.AddScoped<IElementRepository, ElementRepository>();
        services.AddScoped<IElementAttributeRepository, ElementAttributeRepository>();
        services.AddScoped<ITopicRepository, TopicRepository>();
        services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        
        return services;
    }
}