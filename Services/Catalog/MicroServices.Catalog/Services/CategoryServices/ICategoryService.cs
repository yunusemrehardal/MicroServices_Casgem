using MicroServices.Catalog.DTOs.CategoryDtos;
using MicroServices.Shared.Dtos;

namespace MicroServices.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetCategoryListAsync();
        Task<Response<ResultCategoryDto>> GetCategoryByIdAsync(string id);
        Task<Response<CreateCategoryDto>> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<Response<UpdateCategoryDto>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);
    }
}
