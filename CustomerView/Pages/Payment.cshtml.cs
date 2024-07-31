using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace CustomerView.Pages
{
    public class PaymentModel : PageModel
    {
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();

        // Thông tin thanh toán
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string AddressLine1 { get; set; }
        [BindProperty]
        public string AddressLine2 { get; set; }
        [BindProperty]
        public string AddressLine3 { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public string ShippingMethod { get; set; }
        [BindProperty]
        public string PaymentMethod { get; set; }

        public void OnGet(string name, string product_code, int total_price, string image)
        {
            // Nhận thông tin sản phẩm từ URL
            Products.Add(new ProductViewModel
            {
                ProductName = name,
                ProductCode = product_code,
                TotalPrice = total_price,
                Image = image
            });
        }

        public IActionResult OnPost()
        {
            // Xử lý dữ liệu thanh toán
            // Bạn có thể lưu đơn hàng vào cơ sở dữ liệu hoặc thực hiện các bước cần thiết khác

            // Ví dụ: Ghi lại thông tin thanh toán vào log (hoặc lưu vào cơ sở dữ liệu)
            System.Diagnostics.Debug.WriteLine($"Email: {Email}");
            System.Diagnostics.Debug.WriteLine($"Name: {Name}");
            System.Diagnostics.Debug.WriteLine($"Address: {AddressLine1}, {AddressLine2}, {AddressLine3}");
            System.Diagnostics.Debug.WriteLine($"Phone: {Phone}");
            System.Diagnostics.Debug.WriteLine($"Shipping Method: {ShippingMethod}");
            System.Diagnostics.Debug.WriteLine($"Payment Method: {PaymentMethod}");

            // Chuyển hướng đến trang xác nhận hoặc trang khác
            return RedirectToPage("OrderConfirmation");
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
