using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class OrderItems_ViewModel
    {

        public OrderDetails? Order { get; set; }

        public Product? Product { get; set; }

        public Product? ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
