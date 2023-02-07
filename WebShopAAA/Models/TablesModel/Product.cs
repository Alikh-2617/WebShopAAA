using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAAA.Models.Tables
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Guid // chenge it to int !! 

        
        public string Name { get; set; }

        
        public string Desc { get; set; }

        
        public string ImagePath { get; set; }

        
        public int Price { get; set; }

        
        public string? ModelName { get; set; } = null!;

        
        public string? Color { get; set; } = null!;

        public string? Size { get; set; } = null!;

        public List<ProductCategory>? Categorys { get; set; }

        [ForeignKey("OrderItems")]
        public OrderItems? OrderId { get; set; }

        
        public int Quantity { get; set; }


        public string? ArtNumber { get; set; }


        public DateTime CreateAt { get; set; } 

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
