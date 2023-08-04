using MicroServices.Catalog.DTOs.CategoryDtos;
using MicroServices.Catalog.DTOs.ProductDtos;
using MicroServices.Shared.Dtos;

namespace MicroServices.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetProductListAsync();
        Task<Response<ResultProductDto>> GetProductByIdAsync(string id);
        Task<Response<CreateProductDto>> CreateProductAsync(CreateProductDto createProductDto);
        Task<Response<UpdateProductDto>> UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteProductAsync(string id);
        Task<Response<List<ResultProductDto>>> GetProductListWithCategoryAsync();
    }
}
