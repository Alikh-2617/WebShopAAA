
using WebShopAAA.Models.Tables;

namespace WebShopAAA.Repository.Interface
{
    public interface ICategoryRepository
    {
        List<ProductCategory> GetList();
        ProductCategory GetById(int id);
        List<Product> GetListbyCategory(int id);
        int Insert(ProductCategory category);
        int Delete(int id);
        int Update(ProductCategory category);
        void Save();
    }
}

