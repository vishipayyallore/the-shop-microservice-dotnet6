using Catalog.Core.Interfaces;
using Catalog.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{

    public static class CatalogContextDependencies
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();

            return services;
        }
    }

}
