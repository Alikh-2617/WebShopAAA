using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.ViewModels
{
    public class PaymentDetails_ViewModel
    {

        public OrderDetails? OrderId { get; set; }

        public int Amount { get; set; }

        public bool Satus { get; set; }

    }
}
