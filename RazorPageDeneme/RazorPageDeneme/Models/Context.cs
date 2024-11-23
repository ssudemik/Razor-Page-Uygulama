using Microsoft.EntityFrameworkCore;

namespace RazorPageDeneme.Models
{
    public class Context : DbContext //database set gibi komutları kullanabilmek için miras alma işlemi
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }

    }
}
