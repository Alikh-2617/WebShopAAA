namespace WebShopAAA.Models.ViewModels
{
    public class apiCheckOutViewModel
    {
        public string Id { get; set; }

        public int Total { get; set; }

        //public string Color { get; set; }

        public List<CheckoutproductViewModel> Data { get; set; }
    }
}
