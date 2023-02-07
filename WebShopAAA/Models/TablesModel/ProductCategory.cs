using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAAA.Models.Tables
{
    public class ProductCategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Guid

        public List<Product>? Products { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public DateTime CreateAt { get; set; } 

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
