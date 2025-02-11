using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllCategoryAsync();

        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();

        void CreateCategory(CreateProductDto categoryDto);

        void UpdateCategory(UpdateProductDto categoryDto);

        void DeleteCategory(int id);

        Task ProductDealOfTheDayStatusChangeToTrue(int id);

        Task ProductDealOfTheDayStatusChangeToFalse(int id);
    }
}
