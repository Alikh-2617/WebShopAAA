namespace WebShopAAA.Models.ViewModels
{
    public class apiproductViewModel
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
    }
}
//{
//    "id": "recZkNf2kwmdBcqd0",
//        "name": "accent chair",
//        "price": 25999,
//        "image": "https://v5.airtableusercontent.com/v1/14/14/1674489600000/a-S_YjGwFfWHAPlgscn46A/1FCQrbRT4ndGlQoioRflCSc5j3OllzL_7BNpGJ7MXgo5gS6rZvMtP6oRKW7kQgsnz6LFNREdhf9NLv6gwLFzTQ/xEb7ALCFO913MbTNSxMdQnCaoNEiDSf132V-d5Pi9aA",
//        "colors": [
//            "#ff0000",
//            "#00ff00",
//            "#0000ff"
//        ],
//        "company": "marcos",
//        "description": "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge",
//        "category": "office",
//        "shipping": true
//    }