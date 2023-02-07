using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAAA.Models.Tables
{
    public class PaymentDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //  auto generic by Data Base

        [ForeignKey("OrderDetails")]
        public OrderDetails? OrderId { get; set; } 

        public int Amount { get; set; }

        public bool Satus { get; set; }

        public DateTime CreateAt { get; set; } 

        public DateTime? ModifiedAt { get; set; }
    }
}
