using Microsoft.EntityFrameworkCore;

namespace RazorPageDeneme.Models
{
    public class Context : DbContext //database set gibi komutları kullanabilmek için miras alma işlemi
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }
        //sınıf isimleri ile tablo isimlerinin karışmaması için
        public DbSet<Product>? Products { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<SalesTransaction>? SalesTransactions { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Eğer DbContextOptions dışarıdan geçilmemişse, OnConfiguring çalışır.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HRJR15F\\MSSQLSERVER12;Initial Catalog=dataproje;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework;");
            }
        }
    }
}
