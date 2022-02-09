using TheShop.RazorWeb.Extensions;
using TheShop.RazorWeb.Models;

namespace TheShop.RazorWeb.Services
{

    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;
        private readonly ILogger<CatalogService> _logger;

        public CatalogService(HttpClient client, ILogger<CatalogService> logger)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalog()
        {
            try
            {

#pragma warning disable CS8603 // Possible null reference return.
                return await _client.GetFromJsonAsync<IEnumerable<CatalogModel>>("/api/v1/Catalog");
#pragma warning restore CS8603 // Possible null reference return.
                              // var response = await _client.GetAsync("/api/v1/Catalog");
                              // return await response.ReadContentAs<List<CatalogModel>>();
            }
            catch (Exception error)
            {
                _logger.LogError(error.Message);
                throw;
            }
            
        }

    }

}
