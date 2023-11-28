using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "IdProduct", "Description", "Image_Url", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A smoothy and sweetness tobacco", "", 9.99m, "Black Cavendish Tobacco" },
                    { 2, "This books tells about comunism destroy our world", "", 19.99m, "1984 - George Orhwell" },
                    { 3, "SmartWatch to monitore your heartbeats", "", 29.99m, "SmartWatch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "IdProduct",
                keyValue: 3);
        }
    }
}
