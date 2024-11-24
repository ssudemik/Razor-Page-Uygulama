using System.ComponentModel.DataAnnotations;

namespace RazorPageDeneme.Models
{
    public class SalesTransaction
    {
        [Key]
        public int SalesID { get; set; }
        public DateTime Date { get; set; }
        public int Piece { get; set; } //adet,tane
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; } //toplam tutar

        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        

        public virtual Product Product { get; set; }//ürün                                        
        public virtual Customer Customer { get; set; }//müşteri                        
       
    }
}
