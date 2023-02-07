using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopAAA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemsRepository _itemsRepository;
        private readonly IProductRepository _productRepository;
        private readonly IPaymentRepository _paymentRepository;
        readonly UserManager<ApplicationUser> _userManager;

        public OrderController(IOrderRepository orderRepository, IOrderItemsRepository itemsRepository
            , IProductRepository productRepository, UserManager<ApplicationUser> userManager
            , IPaymentRepository paymentRepository)
        {
            _orderRepository = orderRepository;
            _itemsRepository = itemsRepository;
            _productRepository = productRepository;
            _userManager = userManager;
            _paymentRepository = paymentRepository;
        }

        public IActionResult Index()
        {
            var order = _orderRepository.GetList();
            return View(order);
        }

        public IActionResult Details(int id)
        {
            OrderViewModel vm = new OrderViewModel();

            vm.Detail = _orderRepository.GetById(id);


            List<OrderItems> items = _itemsRepository.GetListByOrder(vm.Detail.Id);
            List<Product> products = new List<Product>();
            foreach (var item in items)
            {
                int ID = Convert.ToInt32( item.ProductId );
                Product temp = _productRepository.GetById(ID);
                vm.Products.Add(new OrderListProductsViewModel 
                {
                    Id = temp.Id,
                    Name = temp.Name,
                    Color= temp.Color,
                    Quantity = item.Quantity
                });
                //products.Add(new OrderListProductsViewModel
                //{
                //    Id = temp.Id,
                //    Color = temp.Color,
                //    Quantity = temp.Quantity
                //});
                //products.Add(temp);
            }
            //ViewBag.Products = products;
            //vm.Items.AddRange(products);

            return View(vm);
        }

        public IActionResult Pick(int id)
        {
            var order = _orderRepository.GetById(id);
            order.IsPicked = true;
            _orderRepository.Update(order);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Test()
        {
            var rand = new Random();
            var adminid = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var admin = await _userManager.FindByIdAsync(adminid);


            OrderDetails orderDetails = new OrderDetails();

            orderDetails.User = admin;
            orderDetails.Total = 1500;
            orderDetails.IsPicked = false;
            orderDetails.CreateAt = DateTime.Now;

            OrderDetails order = _orderRepository.Insert(orderDetails);

            var cartItem = _productRepository.GetList();
            OrderDetails order1 = _orderRepository.GetById(orderDetails.Id);

            //OrderItems orderItems = new OrderItems
            //{
            //    Order = order1,
            //    CreateAt = order.CreateAt,
            //};
            //_itemsRepository.Insert(orderItems, orderDetails);


            foreach (var item in cartItem)
            {
                OrderItems orderItems = new OrderItems
                {
                    OrderId = orderDetails.Id,
                    ProductId = item.Id,
                    Quantity = rand.Next(1, item.Quantity),
                    CreateAt = order.CreateAt,
                };
                _itemsRepository.Insert(orderItems, orderDetails);
                //_itemsRepository.Insert(new OrderItems {Product = item, Quantity = rand.Next(1, item.Quantity), CreateAt = order.CreateAt }, order1);
               //order1.OrderItem.Add(new OrderItems { OrderId = order1, ProductId= item, Quantity = rand.Next(1, item.Quantity), CreateAt = order.CreateAt });
            }



            //var user = await GetCurrentUserAsync();

            //orderDetails.UserId = User;



            return RedirectToAction("Index");
        }

    }
}
