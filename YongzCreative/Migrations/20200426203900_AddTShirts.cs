using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class AddTShirts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price", "category", "status" },
                values: new object[,]
                {
                    { 29, "A collection of BAD ARD T-Shirts at only R200 each", "/images/tshirts/_0000_Tshirt.jpg", "T-Shirts", 200m, 3, 0 },
                    { 30, "", "/images/tshirts/_0001_Tshirt.jpg", "White Top", 200m, 3, 0 },
                    { 31, "Black", "/images/tshirts/_0002_Tshirt.jpg", "YONGZ Top", 200m, 3, 0 },
                    { 32, "White", "/images/tshirts/_0003_Tshirt.jpg", "YONGZ Top", 200m, 3, 0 },
                    { 33, "Pitch", "/images/tshirts/_0004_Tshirt.jpg", "YONGZ Top", 200m, 3, 0 },
                    { 34, "BAD ART Stickman", "/images/tshirts/_0005_Tshirt.jpg", "White Top", 200m, 3, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);
        }
    }
}
