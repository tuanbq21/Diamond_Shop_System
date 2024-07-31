using Microsoft.AspNetCore.Mvc.RazorPages;
using DSS_SWP.Models;
using Service.Services;

public class ProductDetailModel : PageModel
{
    private readonly ProductService _productService;

    public ProductDetailModel(ProductService productService)
    {
        _productService = productService;
    }

    public Product Product { get; set; }

    public async Task OnGetAsync(long id)
    {
        Product = _productService.GetProductById(id);
    }
}
