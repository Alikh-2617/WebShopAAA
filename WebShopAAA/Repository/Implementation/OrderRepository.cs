
using Microsoft.AspNetCore.Identity;
using WebShopAAA.DataDB;
using WebShopAAA.Models.ApplicationUserModel;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public OrderRepository(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _context = applicationDbContext;
            _userManager = userManager;
        }


        public List<OrderDetails> GetList()
        {
            List<OrderDetails> orders = _context.OrderDetails.ToList();
            return orders;
        }

        public OrderDetails GetById(int id)
        {
            var orderDetails = _context.OrderDetails.FirstOrDefault(x => x.Id == id);
            if (orderDetails != null) return orderDetails;
            return null;
        }



        public OrderDetails Insert(OrderDetails orderDetails)
        {

            var orderDetails1 = _context.OrderDetails.FirstOrDefault(x => x.Id == orderDetails.Id);
            if (orderDetails1 == null)
            {
                _context.OrderDetails.Add(orderDetails);
                _context.SaveChanges();

                orderDetails.Payment = new PaymentDetails
                {
                    OrderId = orderDetails,
                    Satus = true,
                    Amount = orderDetails.Total,
                    CreateAt = DateTime.Now,
                };

                _context.OrderDetails.Update(orderDetails);
                _context.SaveChanges();

                return orderDetails;
            }
            return null;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public int Update(OrderDetails orderDetails)
        {
            var orderDetails1 = _context.OrderDetails.FirstOrDefault(x => x.Id == orderDetails.Id);
            if (orderDetails1 != null)
            {
                _context.OrderDetails.Update(orderDetails1);
                _context.SaveChanges();
                return 200;
            }
            return 404;
        }

        public int Delete(int id)
        {
            var orderDetails = _context.OrderDetails.FirstOrDefault(x => x.Id == id);
            if (orderDetails != null)
            {
                _context.OrderDetails.Remove(orderDetails);
                _context.SaveChanges();
                return 200;
            }
            return 404;
        }

        public List<OrderDetails> GetList(string id)
        {

            List<OrderDetails> orders = _context.OrderDetails.Where(x => x.User.Id == id).ToList();
            if (orders.Count == 0) return null;
            return orders; 
        }
    }
}


