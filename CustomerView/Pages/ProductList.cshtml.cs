using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerView.Pages
{
    public class ProductListModel : PageModel
    {
        public List<Product>? Products { get; set; }

        public void OnGet()
        {
            // Tạo dữ liệu giả để hiển thị
            Products = new List<Product>
            {
                new Product { Id = 1, ProductName = "Nhẫn Kim Cương 1", ProductCode = "NKD001", Image = "diamond1.jpg", TotalPrice = 15000000 },
                new Product { Id = 2, ProductName = "Nhẫn Kim Cương 2", ProductCode = "NKD002", Image = "diamond2.jpg", TotalPrice = 20000000 }
                // Thêm sản phẩm khác
            };
        }

        public class Product
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductCode { get; set; }
            public string Image { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }
}