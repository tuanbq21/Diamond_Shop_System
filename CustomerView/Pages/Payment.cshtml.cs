using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CustomerView.Pages
{
    public class PaymentModel : PageModel
    {
        public List<ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            Products = GetProductsFromCart();
        }

        public IActionResult OnPost(string email, string name, string address_line1, string address_line2, string address_line3, string phone, string shippingMethod, string paymentMethod)
        {
            // Xử lý dữ liệu thanh toán
            // TODO: Lưu đơn hàng vào cơ sở dữ liệu hoặc thực hiện các bước cần thiết khác

            // Chuyển hướng đến trang xác nhận hoặc trang khác
            return RedirectToPage("OrderConfirmation");
        }

        private List<ProductViewModel> GetProductsFromCart()
        {
            // TODO: Lấy danh sách sản phẩm từ giỏ hàng
            return new List<ProductViewModel>
            {
                new ProductViewModel { ProductName = "Sản phẩm 1", ProductCode = "SP001", TotalPrice = 1000000, Image = "/images/product1.jpg" },
                new ProductViewModel { ProductName = "Sản phẩm 2", ProductCode = "SP002", TotalPrice = 2000000, Image = "/images/product2.jpg" }
            };
        }
    }

    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int TotalPrice { get; set; }
        public string Image { get; set; }
    }
}
