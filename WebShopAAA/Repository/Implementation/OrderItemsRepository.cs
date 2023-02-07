using Microsoft.EntityFrameworkCore;
using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Repository.Implementation
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public OrderItemsRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<OrderItems> GetListByOrder(int id)
        {
            List<OrderItems> list = _applicationDbContext.OrderItems.Where(x => x.OrderId == id).ToList();
            //List<OrderItems> list = _applicationDbContext.OrderItems.Include(p => p.ProductId).Where(or => or.Id == id).ToList();
            if(list.Count > 0)
            {
                return list; 
            }
            return null; 
        }

        public int Insert(OrderItems orderItems, OrderDetails orderDetails)
        {
            if(orderItems != null || orderDetails != null)
            {

                //var temp = _applicationDbContext.OrderDetails.Include(d => d.OrderItemId).FirstOrDefault(x => x.Id == orderDetails.Id);

                //if(temp != null)
                //{
                    _applicationDbContext.OrderItems.Add(orderItems);
                    //temp.OrderItemId.Add(orderItems);
                //}
                //_applicationDbContext.OrderItems.Add(orderItems);
                _applicationDbContext.SaveChanges();
                return 200;
            }
            return 404;
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges(); //  :*
        }
    }
}
