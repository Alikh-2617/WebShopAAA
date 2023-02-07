using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Controllers.API
{
    [Route("api/category")]
    [ApiController]
    public class CategoryapiController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryapiController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public List<apiCategoryViewModel> Get()
        {
            List<apiCategoryViewModel> list = new List<apiCategoryViewModel>();
            var cats = _categoryRepository.GetList();

            foreach (var c in cats)
            {
                list.Add(new apiCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Desc
                });

            }

            return list;
        }
    }
}