namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    IdProduct = 1,
                    Title = "Black Cavendish Tobacco",
                    Description = "A smoothy and sweetness tobacco",
                    Image_Url = "",
                    Price = 9.99m
                },
                new Product
                {
                    IdProduct = 2,
                    Title = "1984 - George Orhwell",
                    Description = "This books tells about comunism destroy our world",
                    Image_Url = "",
                    Price = 19.99m
                },
                new Product
                {
                    IdProduct = 3,
                    Title = "SmartWatch",
                    Description = "SmartWatch to monitore your heartbeats",
                    Image_Url = "",
                    Price = 29.99m
                }
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}