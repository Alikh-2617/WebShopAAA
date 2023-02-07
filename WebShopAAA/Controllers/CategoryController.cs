


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cat = _categoryRepository.GetList();
            return View(cat);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(ProductCategory category)
        {
            ModelState.Remove("Products");
            if (ModelState.IsValid)
            {
                var date = DateTime.Now;
                _categoryRepository.Insert(new ProductCategory { Name = category.Name, Desc= category.Desc, CreateAt = date, ModifiedAt = date });
                _categoryRepository.Save();
                return RedirectToAction("Index");
            }else
            {
                return View(category);
            }

            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cat = _categoryRepository.GetById(id);
            return PartialView("_EditPartial", cat);

        }

        [HttpPost]
        public IActionResult Edit(ProductCategory category)
        {
            if (ModelState.IsValid)
            {
                var cat = _categoryRepository.GetById(category.Id);
                if (cat != null)
                {
                    cat.Desc = category.Desc;
                    cat.Name = category.Name;
                    _categoryRepository.Update(cat);
                    _categoryRepository.Save();
                }
                return RedirectToAction("Index");

            }
            return PartialView("_EditPartial", category);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            _categoryRepository.Delete(id);

            _categoryRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
