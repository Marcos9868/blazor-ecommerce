namespace BlazorEcommerce.Shared
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image_Url { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}