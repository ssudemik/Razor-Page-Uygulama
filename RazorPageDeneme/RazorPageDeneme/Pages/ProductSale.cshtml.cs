using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageDeneme.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageDeneme.Pages
{
    public class ProductSaleModel : PageModel
    {
        private readonly Context _context;

        public ProductSaleModel(Context context)
        {
            _context = context;
        }

        public SalesTransaction SalesTransaction { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public decimal ProductPrice { get; set; }

        public void OnGet(int id)
        {
            // Ürün bilgilerini al
            var product = _context.Products.Find(id);
            if (product != null)
            {
                SalesTransaction = new SalesTransaction
                {
                    ProductID = product.ProductID,
                    Price = product.SalePrice
                };
                ProductPrice = product.SalePrice;
            }

          
        }

        public IActionResult OnPost(SalesTransaction salesTransaction)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Satýþ iþlemi tarihini ayarla
            salesTransaction.Date = DateTime.Now;
            _context.SalesTransactions.Add(salesTransaction);
            _context.SaveChanges();

            return RedirectToPage("/Sale/Index"); // Satýþlar listesine yönlendir
        }
    }
}
