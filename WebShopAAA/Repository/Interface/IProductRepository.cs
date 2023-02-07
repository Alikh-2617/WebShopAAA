
﻿using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;

namespace WebShopAAA.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);
        int Insert(Product product, int id);
        int Delete(int id);
        int Update(Product product);
        void Save();
    }
}

