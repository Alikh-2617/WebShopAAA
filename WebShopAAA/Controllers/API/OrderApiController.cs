using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Implementation;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Controllers.API
{
    [Route("api/order")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemsRepository _itemsRepository;
        private readonly IProductRepository _productRepository;
        private readonly IPaymentRepository _paymentRepository;
        readonly UserManager<ApplicationUser> _userManager;

        public OrderApiController(IOrderRepository orderRepository, IProductRepository productRepository, IPaymentRepository paymentRepository, UserManager<ApplicationUser> userManager, IOrderItemsRepository itemsRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _paymentRepository = paymentRepository;
            _userManager = userManager;
            _itemsRepository = itemsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(apiCheckOutViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(viewModel.Id);
                if (user != null)
                {
                    int total = 0;

                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.User = user;
                    orderDetails.Total = viewModel.Total;   
                    orderDetails.IsPicked = false;
                    orderDetails.CreateAt = DateTime.Now;
                    OrderDetails order = _orderRepository.Insert(orderDetails);

                    foreach (var item in viewModel.Data)
                    {
                        var product = _productRepository.GetById(Convert.ToInt32(item.Id));
                        OrderItems orderItems = new OrderItems
                        {
                            OrderId = orderDetails.Id,
                            ProductId = Convert.ToInt32(item.Id),
                            Quantity = Convert.ToInt32(item.Quantity),
                            CreateAt = order.CreateAt,
                        };
                        _itemsRepository.Insert(orderItems, orderDetails);

                        total += product.Price * Convert.ToInt32(item.Quantity);
                    }
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public List<OrderDetails> GetOrders(string id)
        {
            return _orderRepository.GetList(id);
        }
    }
}