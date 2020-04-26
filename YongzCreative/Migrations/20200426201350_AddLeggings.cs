using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class AddLeggings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price", "category", "status" },
                values: new object[,]
                {
                    { 18, "", "/images/leggings/leggings00.png", "Black Leggings", 180m, 5, 0 },
                    { 19, "", "/images/leggings/leggings01.png", "Grey Leggings", 180m, 5, 0 },
                    { 20, "with white stripes", "/images/leggings/leggings02.png", "Black Leggings", 180m, 5, 0 },
                    { 21, "", "/images/leggings/leggings03.png", "Black Leggings", 180m, 5, 0 },
                    { 22, "", "/images/leggings/leggings04.png", "Pink Leggings", 180m, 5, 1 },
                    { 23, "", "/images/leggings/leggings05.png", "Navy Blue Leggings", 180m, 5, 1 },
                    { 24, "", "/images/leggings/leggings06.png", "Grey Leggings", 180m, 5, 1 },
                    { 25, "", "/images/leggings/leggings07.png", "Dark Blue Leggings", 180m, 5, 1 },
                    { 26, "", "/images/leggings/leggings08.png", "Double Grey Leggings", 180m, 5, 1 },
                    { 27, "", "/images/leggings/leggings09.png", "Blue and Black Leggings", 180m, 5, 1 },
                    { 28, "", "/images/leggings/leggings10.png", "Black Leggings", 180m, 5, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);
        }
    }
}
