using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageDeneme.Models;

namespace RazorPageDeneme.Pages
{
    public class CustomerModel : PageModel
    {
        private readonly Context _context;

        public List<Customer> Customers { get; set; } = new List<Customer>();

        [BindProperty]
        public Customer NewCustomer { get; set; }

        public CustomerModel(Context context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Customers = _context.Customers.ToList();
        }
        public IActionResult OnPost()
        {
            _context.Customers.Add(NewCustomer);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
