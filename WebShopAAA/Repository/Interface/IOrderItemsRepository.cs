using WebShopAAA.Models.Tables;

namespace WebShopAAA.Repository.Interface
{
    public interface IOrderItemsRepository
    {
        List<OrderItems> GetListByOrder(int id);
        int Insert(OrderItems orderItems, OrderDetails orderDetails);
        void Save();
    }
}
