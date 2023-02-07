
﻿using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;

namespace WebShopAAA.Repository.Interface
{
    public interface IOrderRepository
    {
        List<OrderDetails> GetList();
        List<OrderDetails> GetList(string id);
        OrderDetails GetById(int id);
        OrderDetails Insert(OrderDetails orderDetails); // int 
        int Delete(int id);                    // int return 
        int Update(OrderDetails orderDetails);
        void Save();
    }
}
