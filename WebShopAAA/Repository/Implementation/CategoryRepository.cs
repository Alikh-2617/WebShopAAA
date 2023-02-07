using WebShopAAA.Models.ViewModels;
﻿using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;
using WebShopAAA.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace WebShopAAA.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        
        public List<ProductCategory> GetList()  
        {
            List<ProductCategory> category = _context.Categorys.ToList();
            return category;
        }

        public List<Product> GetListbyCategory(int id)
        {
            List<Product> list = _context.Products.Include(p=>p.Categorys).Where(c=>c.Id == id).ToList();       
            if(list.Count > 0)
            {
                return list;
            }
            return null; 
        }


        public ProductCategory GetById(int id)
        {

            var category = _context.Categorys.FirstOrDefault(y => y.Id == id);
            if (category != null)
            {
                return category;
            }
            return null;

        }


        public int Insert(ProductCategory category)
        {
            var category1 = _context.Categorys.Find(category.Id);
            if(category1 == null)
            {
                _context.Categorys.Add(category);
                return 200;
            }
            return 404; 
        }

        public void Save() 
        {
            _context.SaveChanges(); 
        }

        public int Update(ProductCategory category)
        {
            var category1 = _context.Categorys.Find(category.Id);
            if( category1 != null)
            {
                category.ModifiedAt = DateTime.Now;
                _context.Categorys.Update(category);
                return 200;
            }
            return 404;
        }

        public int Delete(int id)
        {
            var category = _context.Categorys.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Categorys.Remove(category);
                return 200;
            }
            return 404;
        }


    }
}
