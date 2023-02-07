using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopAAA.Models.ApplicationUserModel;

namespace WebShopAAA.Models.Tables
{

    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("OrderItems")] 
        public ApplicationUser? User { get; set; }  // just one  

        public int Total { get; set; }

        [ForeignKey("PaymentDetails")]
        public PaymentDetails? Payment { get; set; }

        public List<OrderItems>? OrderItemId { get; set; } // List 

        public bool IsPicked { get; set; }

        public DateTime CreateAt { get; set; } 

        public DateTime? ModifiedAt { get; set; }


    }
}
