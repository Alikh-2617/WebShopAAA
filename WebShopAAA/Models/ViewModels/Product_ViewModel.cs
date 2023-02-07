using System.ComponentModel.DataAnnotations;
using WebShopAAA.Models.Concetant;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class Product_ViewModel
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string? Company { get; set; } = null!;

        [Required]
        public string? Color { get; set; } = null!;

        [Required]
        public int Category { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}
