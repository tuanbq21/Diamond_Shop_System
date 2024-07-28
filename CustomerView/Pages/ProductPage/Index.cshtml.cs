using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DSS_SWP.Models;

namespace CustomerView.Pages.ProductPage
{
    public class IndexModel : PageModel
    {
        private readonly DSS_SWP.Models.DSS_CustomerContext _context;

        public IndexModel(DSS_SWP.Models.DSS_CustomerContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.DiamondShell)
                .Include(p => p.ExtraDiamond)
                .Include(p => p.MainDiamond).ToListAsync();
        }
    }
}
