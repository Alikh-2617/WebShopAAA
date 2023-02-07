using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Logging;
using System;
using WebShopAAA.Models.Tables;
using WebShopAAA.Models.ViewModels;
using WebShopAAA.Repository.Interface;

namespace WebShopAAA.Controllers.API
{
    [Route("api/product")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public List<vm>? Get()
        {
            var rand = new Random();
            int count = 0;
            var featureds = new int[3];

            List<vm> list = new List<vm>();
            if(list != null)
            {
                List<Product> Plist = _productRepository.GetList();
 
                do
                {
                    var num = rand.Next(1, Plist.Count);
                    if (!featureds.Contains(num))
                    {
                        featureds[count] = num;
                        count++;

                    }
                } while (count < 3);


                foreach (var item in Plist)
                {
                    bool featured = false;
                    if (featureds.Contains(item.Id))
                    {
                        featured = true;
                    }
                                        
                    list.Add(new vm
                    {

                        Id = item.Id,
                        Name = item.Name,
                        Images = item.ImagePath.Split(",", StringSplitOptions.RemoveEmptyEntries),
                        Company = item.ModelName,
                        Price = item.Price,
                        Colors = item.Color.Split(",", StringSplitOptions.RemoveEmptyEntries),
                        Quantity = item.Quantity,
                        Category = item.Categorys.Count == 0 ? "" : item.Categorys[0].Name.ToString(),
                        Description = item.Desc,
                        Shipping = item.Price <= 1000 ? true: false,
                        featured = featured
                    });
                
                }
                return list;
            }
            return null;
        }

        
        [HttpGet("{id}")]
        public apiproductViewModel? Get(int id)
        {
            
            Product item = _productRepository.GetById(id);
            if ( item != null)
            {
                apiproductViewModel list = new apiproductViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Images = item.ImagePath.Split(",", StringSplitOptions.RemoveEmptyEntries),
                    Company = item.ModelName,
                    Price = item.Price,
                    Colors = item.Color.Split(",", StringSplitOptions.RemoveEmptyEntries),
                    Quantity = item.Quantity,
                    Category = item.Categorys.Count == 0 ? "" : item.Categorys[0].Name.ToString(),
                    Shipping = item.Price <= 1000 ? true : false,
                    Description = item.Desc,
                };

                return list;
            }
            return null;
        }
    }
}
