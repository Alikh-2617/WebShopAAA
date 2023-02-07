using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using WebShopAAA.DataDB;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ApplicationDbContext _context;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, ApplicationDbContext context = null)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            //ViewBag.Cat = 
            return View(_productRepository.GetList());
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetById(id);
            //ViewBag.image = product.
            //return View(temp);
            return PartialView("_ProductDetailsPartial", product);
        }

        public IActionResult Create()
        {
            var cat = _categoryRepository?.GetList();

            ViewBag.Category = new SelectList(_context.Categorys.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product_ViewModel product, int cat)
        {
            //ModelState.Remove("Categorys");
            if (ModelState.IsValid)
            {
                Product pro = new Product();
                var date = DateTime.Now;
                pro.Name = product.Name;
                pro.Desc = product.Desc;
                pro.ImagePath = product.Image;
                pro.Price = product.Price;
                pro.Quantity = product.Quantity;
                pro.Color = product.Color;
                pro.ModelName = product.Company;
                
                pro.CreateAt = date;
                pro.ModifiedAt = date;

                _productRepository.Insert(pro, cat);
                return RedirectToAction("Index");
            }

            ViewBag.Category = new SelectList(_context.Categorys.ToList(), "Id", "Name");

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Category = new SelectList(_context.Categorys, "Id", "Name");
            var product = _productRepository.GetById(id);
            ViewBag.cat = product.Categorys[0].Id;
            return PartialView("_EditDetailsPartial", product);
        }

        [HttpPost]
        public IActionResult Edit(Product product, int cat)
        {
            var pro = _productRepository.GetById(product.Id);
            if (pro != null)
            {
                var tempcat = _categoryRepository.GetById(cat);
                pro.Name = product.Name;
                pro.ArtNumber = product.ArtNumber;
                pro.ImagePath = product.ImagePath;
                pro.Desc = product.Desc;
                pro.Price = product.Price;
                pro.Quantity = product.Quantity;
                pro.Size = product.Size;
                pro.Color = product.Color;
                pro.ModelName = product.ModelName;
                //pro.Categorys[0] = tempcat;
                _productRepository.Update(pro);

            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) 
        {
            _productRepository.Delete(id);
            _productRepository.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Change(int id)
        {
            var product = _productRepository.GetById(id);
            ViewBag.Category = new SelectList(_context.Categorys.ToList(), "Id", "Name");
            ViewBag.Category = _categoryRepository.GetList();

            ViewBag.Name = product.Name;
            ViewBag.Id = product.Id;
            ViewBag.cat = product.Categorys[0].Id;
            return View();
        }

        [HttpPost]
        public IActionResult Change(int id, int categorys)
        {
            var pro = _productRepository.GetById(id);
            if (pro != null)
            {
                var tempcat = _categoryRepository.GetById(categorys);
                pro.Categorys[0] = tempcat;
                _productRepository.Update(pro);

            }

            return RedirectToAction("Index");
        }
    }
}
