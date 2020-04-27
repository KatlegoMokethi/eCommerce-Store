using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class AddSweatpants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price", "category", "status" },
                values: new object[,]
                {
                    { 35, "", "/images/sweatpants/Sweatpants00.png", "Grey Sweatpants", 300m, 4, 1 },
                    { 36, "", "/images/sweatpants/Sweatpants01.png", "Red Sweatpants", 300m, 4, 0 },
                    { 37, "", "/images/sweatpants/Sweatpants02.png", "Yellow Sweatpants", 300m, 4, 1 },
                    { 38, "", "/images/sweatpants/Sweatpants03.png", "Grey Sweatpants", 300m, 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);
        }
    }
}
