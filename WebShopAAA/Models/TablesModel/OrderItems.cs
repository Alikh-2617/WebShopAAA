using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAAA.Models.Tables
{
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ForeignKey("Product")]
        public int Id { get; set; }  // Guid

        public int? OrderId { get; set; }

        public int? ProductId { get; set; } 

        public int Quantity { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? ModifiedAt { get; set; }


    }
}
