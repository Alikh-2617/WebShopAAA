using System.ComponentModel.DataAnnotations;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class ProductCategory_VIewModel
    {

        public List<Product>? Products { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Desc { get; set; }

    }
}
