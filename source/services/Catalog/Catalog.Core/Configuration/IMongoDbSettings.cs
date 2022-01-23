namespace Catalog.Core.Configuration
{

    public interface IMongoDbSettings
    {
        string ConnectionString { get; }

        string DatabaseName { get; }

        string CollectionName { get; }
    }

}
