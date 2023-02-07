using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Models.Seeding
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context = applicationBuilder
                .ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<ApplicationDbContext>()!;

            //if (!context.Categorys.Any())
            //{
            //    context.Categorys.AddRange(Categorys.Select(c => c.Value));
            //    context.SaveChanges();
            //}
            //if (!context.Products.Any())
            //{
            //    context.Products.AddRange(Products.Select(p => p.Value));
            //    context.SaveChanges();
            //}
            if (context.OrderDetails.Any())
            {
                context.OrderDetails.AddRange(Orders.Select(p => p.Value));
                context.SaveChanges();
            }
            if (context.OrderItems.Any())
            {
                context.OrderItems.AddRange(OrderI.Select(p => p.Value));
                context.SaveChanges();
            }

        }

        private static Dictionary<int, OrderDetails>? _orders;
        public static Dictionary<int, OrderDetails>? Orders
        {
            get
            {
                if(_orders== null)
                {
                    var oderlist = new OrderDetails[]
                    {
                        new OrderDetails { Total = 5, IsPicked = true, CreateAt = DateTime.Now },
                        new OrderDetails { Total = 5, IsPicked = true, CreateAt = DateTime.Now },
                        new OrderDetails { Total = 5, IsPicked = false, CreateAt = DateTime.Now },
                    };
                    _orders = new Dictionary<int, OrderDetails>();
                    int count = 0;
                    foreach (var item in oderlist)
                    {
                        _orders.Add(count, item);
                        count++;
                    }

                   
                }
             return _orders;
            }
        }

        private static Dictionary<int, OrderItems>? _ordersI;
        public static Dictionary<int, OrderItems>? OrderI
        {
            get
            {
                if (_ordersI == null)
                {
                    var oderlist = new OrderItems[]
                    {
                        //new OrderItems { Order = Orders[0], Product = Products["Skrivbord"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[0], Product = Products["Stol"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[0], Product = Products["Sim"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[1], Product = Products["Skrivbord"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[1], Product = Products["Stol"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[1], Product = Products["Sim"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[2], Product = Products["Skrivbord"], CreateAt = DateTime.Now },
                        //new OrderItems { Order = Orders[2], Product = Products["Stol"], CreateAt = DateTime.Now },

                    };
                    _ordersI = new Dictionary<int, OrderItems>();
                    int count = 0;
                    foreach (var item in oderlist)
                    {
                        _ordersI.Add(count, item);
                        count++;
                    }


                }
                return _ordersI;
            }
        }


        private static Dictionary<string, ProductCategory>? _categorys;
        public static Dictionary<string, ProductCategory> Categorys
        {
            get
            {
                if (_categorys == null)
                {
                    var catList = new ProductCategory[]
                    {
                        new ProductCategory {  Name = "Skrivbord", Desc = "Dator skriv bord"},
                        new ProductCategory { Name = "Stol", Desc = "Kontors och gaming stolar"},
                        new ProductCategory { Name = "Sim", Desc = "Simulator utrösning"},
                    };
                    _categorys = new Dictionary<string, ProductCategory>();
                    foreach (var item in catList)
                    {
                        _categorys.Add(item.Name, item);
                    }
                }

                return _categorys;
            }
        }

        private static Dictionary<string, Product>? _products;
        public static Dictionary<string, Product> Products
        {


            get
            {
                if (_products == null)
                {
                    var date = DateTime.Now;
                    var proList = new Product[]
                    {
                        new Product { ArtNumber = "198-456", Name= "Anna", Desc = "Ett skrivbord som är höj och sänkbart med ben i metall, 80 X 60 cm stor bordsskiva.", Color = "black", Quantity = 15, Size = "Large", Price = 1500, ModelName = "Ike", ImagePath = "bb.jpg" , CreateAt = DateTime.Now, ModifiedAt = DateTime.Now},
                        new Product { ArtNumber = "198-456", Name= "Anna", Desc = "Ett skrivbord som är höj och sänkbart med ben i metall, 80 X 60 cm stor bordsskiva.", Color = "black", Quantity = 15, Size = "Large", Price = 1500, ModelName = "Ike", ImagePath = "bb.jpg" , CreateAt = DateTime.Now, ModifiedAt = DateTime.Now },
                        new Product { ArtNumber = "198-556", Name= "Serla", Desc = "Serla är en racingstol som har försetts med en patenterad ställning med hjul.", Color = "Red", Quantity = 15, Price = 1500, Size = "Large", ModelName = "Ike", ImagePath = "", CreateAt = DateTime.Now, ModifiedAt = DateTime.Now  },
                        new Product { ArtNumber = "456-789", Name= "X-Drive", Desc = "X-Drive är en stålram som man kan installera valfri racingstol i. Den har även försetts med ett glasfiberskal så det ser ut som en formel 1 bil.", Color = "Silver", Price = 3500, Quantity = 2, Size = "", ModelName = "Ike", ImagePath = "", CreateAt = DateTime.Now, ModifiedAt = DateTime.Now  },
                    };
                    _products = new Dictionary<string, Product>();
                    foreach (var item in proList)
                    {
                        _products.Add(item.Name, item);
                    }
                }
                return _products;
            }
        }
    }

    
}/*);*/
//modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = orderItemsId, Quantity = 1, CreateAt = DateTime.Now });
//modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = 2, Quantity = 5, CreateAt = DateTime.Now });
//modelBuilder.Entity<OrderItems>().HasData(new OrderItems { Id = 3, Quantity = 10, CreateAt = DateTime.Now });


//modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 1, Amount = 2, Satus = false, CreateAt = DateTime.Now });
//modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 2, Amount = 2, Satus = false, CreateAt = DateTime.Now });
//modelBuilder.Entity<PaymentDetails>().HasData(new PaymentDetails { Id = 3, Amount = 2, Satus = false, CreateAt = DateTime.Now });
//}
