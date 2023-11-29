namespace BlazorEcommerce.Server.Contracts
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProducts();
    }
}