using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class OrderViewModel
    {
        public OrderDetails Detail { get; set; }

        public List<OrderListProductsViewModel> Products { get; set; } = new List<OrderListProductsViewModel>();

        public PaymentDetails PaymentDetails { get; set; }
    }
}
