using Microsoft.AspNetCore.Mvc.RazorPages;
using DSS_SWP.Models; // Thêm namespace để truy cập model
using System.Collections.Generic;
using Service.Services;
using System.Threading.Tasks;

namespace CustomerView.Pages
{
    public class HomePageModel : PageModel
    {
        private readonly ProductService _productService;

        public HomePageModel(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _productService.GetLatestProducts();
        }
    }
}
