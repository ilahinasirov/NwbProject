using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _prductService;

        public ProductController(IProductService prductService)
        {
            _prductService = prductService;
        }

        [HttpGet("getall")]

        public IActionResult Get()
        {
            var result = _prductService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]

        public IActionResult GetById(int productId)
        {
            var result = _prductService.Get(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbycategoryid")]

        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = _prductService.GetByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("add")]

        public IActionResult Add(Product product)
        {
           var result= _prductService.Add(product);
           if (result.Success)
           {
               return Ok(result.Message);
           }
           return BadRequest(result.Message);
        }
        [HttpGet("Update")]

        public IActionResult Update(Product product)
        {
           var result= _prductService.Update(product);
           if (result.Success)
           {
               return Ok(result.Message);
           }
           return BadRequest(result.Message);
        }
        [HttpGet("Delete")]

        public IActionResult Delete(Product product)
        {
           var result = _prductService.Delete(product);
           if (result.Success)
           {
               return Ok(result.Message);
           }
           return BadRequest(result.Message);
        }
        public IActionResult SoftDelete(int ProductId)
        {
            return null;
        }
    }
}
