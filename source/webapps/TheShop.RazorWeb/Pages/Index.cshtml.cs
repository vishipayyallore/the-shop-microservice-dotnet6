using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheShop.RazorWeb.Models;
using TheShop.RazorWeb.Services;

namespace TheShop.RazorWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICatalogService _catalogService;

        public IEnumerable<CatalogModel> ProductList { get; set; } = new List<CatalogModel>();

        public IndexModel(ILogger<IndexModel> logger, ICatalogService catalogService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ProductList = await _catalogService.GetCatalog();
            return Page();
        }

    }
}