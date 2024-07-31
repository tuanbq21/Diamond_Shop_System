using DSS_SWP.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerView.Pages
{
    public class PaymentModel : PageModel
    {
        private readonly ProductService _productService;

        public PaymentModel(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; }

        public async Task OnGet()
        {
            Products = await _productService.GetList();
        }
    }
}
