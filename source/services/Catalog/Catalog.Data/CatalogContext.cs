using Catalog.Core.Configuration;
using Catalog.Core.Entities;
using Catalog.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Data
{

    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }

        public CatalogContext(IConfiguration configuration, IMongoDbSettings mongoDbSettings)
        {
            //var client = new MongoClient(configuration["MongoDbSettings:ConnectionString"]);
            //var database = client.GetDatabase(configuration["MongoDbSettings:DatabaseName"]);
            //Products = database.GetCollection<Product>(configuration["MongoDbSettings:CollectionName"]);

            var client = new MongoClient(mongoDbSettings.ConnectionString);
            var database = client.GetDatabase(mongoDbSettings.DatabaseName);

            Products = database.GetCollection<Product>(mongoDbSettings.CollectionName);
            CatalogContextSeed.SeedData(Products);
        }
    }

}
