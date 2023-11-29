using BlazorEcommerce.Server.Contracts;
using BlazorEcommerce.Server.Services;

namespace BlazorEcommerce.Server.Mapping
{
    public static class ServiceMapping
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}