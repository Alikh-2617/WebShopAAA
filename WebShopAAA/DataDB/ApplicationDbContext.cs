using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.DataDB
{
    // efter scafolding Identity : byta DbContext med IdentityDbContext < ApplicationUser Model > och sen i WebShop project Add scafolding Identity den lägga till själv i program.cs

    public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }


        public DbSet<ProductCategory> Categorys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            int categorysId1 = 1;
            int categorysId2 = 2;
            int categorysId3 = 3;
            int categorysId4 = 4;
            int categorysId5 = 5;
            int categorysId6 = 6;

            int productsId1 = 1;
            int productsId2 = 2;
            int productsId3 = 3;
            int productsId4 = 4;
            int productsId5 = 5;
            int productsId6 = 6;
            int productsId7 = 7;
            int productsId8 = 8;
            int productsId9 = 9;
            int productsId10 = 10;
            int productsId11 = 11;
            int productsId12 = 12;
            int productsId13 = 13;
            int productsId14 = 14;
            int productsId15 = 15;
            int productsId16 = 16;
            int productsId17 = 17;
            int productsId18 = 18;
            int productsId19 = 19;
            int productsId20 = 20;
            int productsId21 = 21;
            int productsId22 = 22;
            int productsId23 = 23;


            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId1, Name = "office", Desc = "office", CreateAt = DateTime.Now });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId2, Name = "living room", Desc = "living room", CreateAt = DateTime.Now });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId3, Name = "kitchen", Desc = "kitchen", CreateAt = DateTime.Now });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId4, Name = "bedroom", Desc = "bedroom", CreateAt = DateTime.Now });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId5, Name = "dining", Desc = "dining", CreateAt = DateTime.Now });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId6, Name = "kids", Desc = "kids", CreateAt = DateTime.Now });


            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId1, Name = "accent chair", Price = 25999, ImagePath = "/images/001.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "marcos", Color = "#00ff00", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId2, Name = "albany sectional", Price = 1099, ImagePath = "/images/002.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "liddy", Color = "#ffb900", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId3, Name = "albany table", Price = 10555, ImagePath = "/images/003.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "liddy", Color = "#ffb900", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId4, Name = "armchair", Price = 15555, ImagePath = "/images/004.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "marcos", Color = "#0000ff", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId5, Name = "bar stool", Price = 155, ImagePath = "/images/005.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "liddy", Color = "#000", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId6, Name = "dining table", Price = 10885, ImagePath = "/images/006.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "ikea", Color = "#ffb900", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId7, Name = "emperor bed", Price = 1775, ImagePath = "/images/007.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "ikea", Color = "#0000ff", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId8, Name = "entertainment center", Price = 1995, ImagePath = "/images/008.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "caressa", Color = "#ff0000", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId9, Name = "high-back bench", Price = 1555, ImagePath = "/images/009.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", ModelName = "ikea", Color = "#00ff00", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId10, Name = "leather chair", Price = 555, ImagePath = "/images/010.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ffb900", ModelName = "caressa", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId11, Name = "leather sofa", Price = 33555, ImagePath = "/images/011.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#0000ff", ModelName = "caressa", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId12, Name = "modern bookshelf", Price = 1255, ImagePath = "/images/012.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ff0000", ModelName = "caressa", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId13, Name = "modern poster", Price = 10555, ImagePath = "/images/013.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#000", ModelName = "liddy", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId14, Name = "shelf", Price = 555, ImagePath = "/images/014.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#00ff00", ModelName = "ikea", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId15, Name = "simple chair", Price = 155, ImagePath = "/images/015.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#0000ff", ModelName = "liddy", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId16, Name = "sofa set", Price = 555, ImagePath = "/images/016.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ffb900", ModelName = "marcos", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId17, Name = "suede armchair", Price = 1555, ImagePath = "/images/017.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#00ff00", ModelName = "caressa", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId18, Name = "utopia sofa", Price = 22555, ImagePath = "/images/018.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#00ff00", ModelName = "liddy", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId19, Name = "vase table", Price = 555, ImagePath = "/images/019.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ff0000", ModelName = "marcos", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId20, Name = "wooden bed", Price = 1555, ImagePath = "/images/020.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ffb900", ModelName = "ikea", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId21, Name = "wooden desk", Price = 555, ImagePath = "/images/021.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#000", ModelName = "ikea", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId22, Name = "wooden desk", Price = 8555, ImagePath = "/images/022.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#0000ff", ModelName = "ikea", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            modelBuilder.Entity<Product>().HasData(new Product { Id = productsId23, Name = "wooden table", Price = 10555, ImagePath = "/images/023.jpg", Desc = "Cloud bread VHS hell of banjo bicycle rights jianbing umami mumblecore etsy 8-bit pok pok +1 wolf. Vexillologist yr dreamcatcher waistcoat, authentic chillwave trust fund. Viral typewriter fingerstache pinterest pork belly narwhal. Schlitz venmo everyday carry kitsch pitchfork chillwave iPhone taiyaki trust fund hashtag kinfolk microdosing gochujang live-edge", Color = "#ffb900", ModelName = "caressa", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });

            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId1 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId2 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId3, ProductsId = productsId3 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId4, ProductsId = productsId4 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId5, ProductsId = productsId5 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId5, ProductsId = productsId6 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId4, ProductsId = productsId7 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId8 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId9 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId4, ProductsId = productsId10 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId11 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId6, ProductsId = productsId12 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId13 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId14 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId15 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId16 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId17 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId2, ProductsId = productsId18 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId19 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId4, ProductsId = productsId20 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId21 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId1, ProductsId = productsId22 }));
            modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId3, ProductsId = productsId23 }));
                                                                                                                                                           

            //modelBuilder.Entity<Product>().HasMany(x => x.Categorys).WithMany(y => y.Products).UsingEntity(j => j.HasData(new { CategorysId = categorysId, ProductsId = productsId }));


            //modelBuilder.Entity<Product>().HasData(new Product { Id = productsId, Name = "cat1", Desc = "En cat bara", ImagePath = "", Price = 10, ModelName = "en model", Color = "vit", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            //modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = categorysId, Name = "animals", Desc = "djur category", CreateAt = DateTime.Now });


            //modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = 2, Name = "things", Desc = "things category", CreateAt = DateTime.Now });
            //modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory { Id = 3, Name = "whater", Desc = "things category", CreateAt = DateTime.Now });

            //modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "cat2", Desc = "En cat bara", ImagePath = "", Price = 10, ModelName = "en model", Color = "vit", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });
            //modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "cat3", Desc = "En cat bara", ImagePath = "", Price = 10, ModelName = "en model", Color = "vit", Size = "medium", Quantity = 3, ArtNumber = "1212", CreateAt = DateTime.Now });

            //int orderDetailsId = 1;
            //int orderItemsId = 1;
            //modelBuilder.Entity<OrderDetails>().HasMany(y => y.OrderItemId).WithMany(g => g.OrderId).UsingEntity(d => d.HasData(new { OrderIdId = orderDetailsId, OrderItemIdId = orderItemsId }));

            //modelBuilder.Entity<OrderDetails>().HasMany(y => y.OrderItemId).WithOne(g => g.Order);
            //modelBuilder.Entity<OrderItems>().HasOne(p => p.Product);

            //modelBuilder.Entity<OrderDetails>().HasData(new OrderDetails { Id = orderDetailsId, Total = 5, IsPicked = true, CreateAt = DateTime.Now });
            //modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = orderItemsId, Quantity = 1, CreateAt = DateTime.Now });

            //modelBuilder.Entity<OrderDetails>().HasData(new OrderDetails { Id = 2, Total = 5, IsPicked = true, CreateAt = DateTime.Now });
            //modelBuilder.Entity<OrderDetails>().HasData(new OrderDetails { Id = 3, Total = 5, IsPicked = true, CreateAt = DateTime.Now });

            //modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = 2, Quantity = 5, CreateAt = DateTime.Now });
            //modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = 3, Quantity = 10, CreateAt = DateTime.Now });


            //modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 1, Amount = 2, Satus = false, CreateAt = DateTime.Now });
            //modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 2, Amount = 2, Satus = false, CreateAt = DateTime.Now });
            //modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 3, Amount = 2, Satus = false, CreateAt = DateTime.Now });





            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            // skapat rolls
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" });

            // skapat User
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "Admin1@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "Admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "admin",
                LastName = "admin",
                PasswordHash = hasher.HashPassword(null, "password"),
                Address = "adminsgatan",
                PostCode = "444 44",
                City = "GBG",
                Country = "Swedan",
                Phonenummer = "0123456",
                Modilephone = "987654321",
                CreateAt = DateTime.Now
            });
            // Ger admin roll till User (så vi har en user vilken är samtidigt Admin )
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId,
            });
        }
    }
}
