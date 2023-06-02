using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.API.Extensions;
using ShopOnline.API.Responsities.Contracts;
using ShopOnline.Models.DTOs;
using System.Collections;
using static ShopOnline.API.Extensions.DtoConversions;

namespace ShopOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductResponsity productResponsity;

        public ProductController(IProductResponsity productResponsity)
        {
            this.productResponsity = productResponsity;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProductDtos()
        {
            try
            {
                var products = await this.productResponsity.GetItems();
                var categories = await this.productResponsity.GetCategories();
                if(products == null || categories == null) { 
                return NotFound();
                }
                var productsDtos = products.ConvertToProductDto(categories);
                return Ok(productsDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult<ProductDto>> GetProductDetail(int ID)
        {
            try
            {
                var product = await productResponsity.GetItem(ID);
                if (product == null)
                {
                    return BadRequest();
                }
                var productCategory = await productResponsity.GetCategory(product.CategoryID);
                if(productCategory == null)
                {
                    return BadRequest();
                }
                return product.ConvertToProductDto(productCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
