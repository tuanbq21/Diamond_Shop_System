using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service.Services;

namespace CustomerView.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly UserService _accountRepo = new UserService();
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string password { get; set; }


        public async Task<IActionResult> OnPost()
        {
            try
            {
                var account = _accountRepo.GetAccount(email, password);
                if (account != null)
                {
                    TempData["Message"] = "Login Success";
                    Console.WriteLine("Login Success");

                    return RedirectToPage("/HomePage");
                }
                else
                {
                    HttpContext.Session.SetString("UserId", account.Id.ToString());
                    TempData["Message"] = "Tài khoảng hoặc mật khẩu bị sai. Vui lòng nhập lại!";
                    return Page();
                }
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                return Page();
            }

        }
    }
}
