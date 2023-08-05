using MicroServices.Catalog.DTOs.ProductDtos;
using MicroServices.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductsController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }


        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _ProductService.GetProductListAsync();
            return Ok(values);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetProduct(string id)
        {
            var value = await _ProductService.GetProductByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _ProductService.CreateProductAsync(createProductDto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _ProductService.UpdateProductAsync(updateProductDto);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _ProductService.DeleteProductAsync(id);
            return Ok();
        }
    }

}

