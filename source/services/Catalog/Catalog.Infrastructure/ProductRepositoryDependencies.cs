using Catalog.API.Repositories;
using Catalog.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure
{
    public static class ProductRepositoryDependencies
    {

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }

}
