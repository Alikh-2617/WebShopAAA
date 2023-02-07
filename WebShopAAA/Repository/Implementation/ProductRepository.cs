
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Repository.Implementation
{
    
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        //private readonly DbSet<Product> _product;        // vi kan använda oss av den typ av injection DbSet<Product> !! 

        public ProductRepository(ApplicationDbContext applicationDbContext )
        {
            _context = applicationDbContext;
            //_context = applicationDbContext.Set<Product>();
        }

        public List<Product> GetList()
        {
            List<Product> products = _context.Products.Include( x => x.Categorys ).ToList();
            return products;  
        }

        public Product GetById(int id)
        {
            var product = _context.Products.Include(x => x.Categorys).FirstOrDefault(x => x.Id == id);
            if (product != null) return product;
            return null;
        }

        public int Delete(int id)
        {
            var productToDelete = _context.Products.FirstOrDefault(x => x.Id == id);
            if( productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                return 200;
            }
            return 404;
        }

        public int Insert(Product product, int id)
        {
            var product1 = _context.Products.Find(product.Id);
            if(product1 == null)
            {
                var category = _context.Categorys.Include(x => x.Products).FirstOrDefault(x => x.Id == id);
                if (category != null) 
                {
                    category.Products.Add(product);
                    _context.SaveChanges();
                }
                //_context.Products.Categorys.Add(_context.Categorys.Find(product.Id));
                //_context.Products.Add(product);
                return 200;
            }
            return 404;
        }

        public void Save()
        {
            _context.SaveChanges(); 
        }

        
        public int Update(Product product)
        {
            var product1 = _context.Products.Find(product.Id);
            if(product1 != null)
            {
                //var category = _context.Categorys.Include(x => x.Products).FirstOrDefault(x => x.Id == id);
                //product.Categorys. = _context.Categorys.Find(id);
                product.ModifiedAt = DateTime.Now;
                _context.Products.Update(product);
                _context.SaveChanges();
                return 200;
            }
            return 404;
        }

    }
}

