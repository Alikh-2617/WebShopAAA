namespace WebShopAAA.Models.ViewModels
{
    public class OrderListProductsViewModel
    {
        public int Id { get; set; } // Guid // chenge it to int !! 
        public string Name { get; set; }
        public string? Color { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
