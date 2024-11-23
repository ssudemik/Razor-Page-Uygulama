using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageDeneme.Models;

namespace RazorPageDeneme.Pages
{
    public class ProductModel : PageModel
    {
        private readonly Context _context;

        public List<Product> Products { get; set; } = new List<Product>();

        [BindProperty]
        public Product NewProduct { get; set; }

        public ProductModel(Context context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            Products = _context.Products.ToList();
        }

        public IActionResult OnPost() 
        {
            _context.Products.Add(NewProduct);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
