using ShoppingNightMongo.Dtos.ProductDtos;

namespace ShoppingNightMongo.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetProductByIdDto> GetProductByIdAsync(string id);
    }
}
