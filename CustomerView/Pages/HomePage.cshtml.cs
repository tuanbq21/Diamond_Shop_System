using Microsoft.AspNetCore.Mvc.RazorPages;
using DSS_SWP.Models; // Thêm namespace để truy cập model
using System.Collections.Generic;

namespace CustomerView.Pages
{
    public class HomePageModel : PageModel
    {
        public List<Product>? Products { get; set; }

        public void OnGet()
        {
            // Logic để lấy sản phẩm từ cơ sở dữ liệu
            Products = GetProductsFromDatabase(); // Giả sử bạn có một hàm để lấy sản phẩm
        }

        private List<Product> GetProductsFromDatabase()
        {
            // Kết nối DB và lấy danh sách sản phẩm
            return new List<Product>(); // Trả về danh sách sản phẩm
        }
    }
}
