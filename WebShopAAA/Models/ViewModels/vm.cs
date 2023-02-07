namespace WebShopAAA.Models.ViewModels
{
    public class vm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; }
        public string Category { get; set; }
        public bool Shipping { get; set; } = true;
        public int Price { get; set; }
        public string Company { get; set; }
        public int Quantity { get; set; }
        public int Reviews { get; set; } = 100;
        public float Stars { get; set; } = 3.0f;
        public string[] Images { get; set; }
        public bool featured { get; set; }
    }
}
