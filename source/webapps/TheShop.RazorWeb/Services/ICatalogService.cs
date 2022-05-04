using TheShop.RazorWeb.Models;

namespace TheShop.RazorWeb.Services
{

    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();
    }

}
