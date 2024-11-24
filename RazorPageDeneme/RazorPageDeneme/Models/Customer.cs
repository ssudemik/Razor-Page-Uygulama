using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPageDeneme.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = " Customer Name ")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "You can not pass this field empty!")]
        public string? CustomerName { get; set; }

        [Display(Name = " Customer Surname ")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "You can write up to 30 characters :) ")]
        public string? CustomerSurname { get; set; }

        [Display(Name = " Customer City ")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "You can write up to 30 characters :) ")]
        public string? CustomerCity { get; set; }

        [Display(Name = " Customer Mail ")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "You can write up to 50 characters :) ")]
        public string? CustomerMail { get; set; }

        public bool Status { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }

    }
}
