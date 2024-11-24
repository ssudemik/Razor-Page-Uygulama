using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPageDeneme.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = " Product Name ")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string? ProductName { get; set; }

        [Display(Name = " Product Size ")]
        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string? ProductSize { get; set; }

        public short Stock { get; set; }

        [Display(Name = " Sale Price ")]
        public decimal SalePrice { get; set; } //satış fiyatı
        public bool Status { get; set; } //ürünler için kritik seviye belirleme

        [Display(Name = " Product Visual ")]
        [Column(TypeName = "Varchar")]
        [StringLength(8000)]
        public string? ProductVisual { get; set; }

        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}
