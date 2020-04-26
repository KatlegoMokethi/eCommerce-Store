using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class AddSweaters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price", "category", "status" },
                values: new object[,]
                {
                    { 12, "", "/images/sweaters/sweater00.png", "Sky Blue Sweater", 350m, 2, 1 },
                    { 13, "", "/images/sweaters/sweater01.png", "Black Sweater", 350m, 2, 0 },
                    { 14, "", "/images/sweaters/sweater02.png", "Orange Sweater", 350m, 2, 0 },
                    { 15, "", "/images/sweaters/sweater03.png", "Blue Sweater", 350m, 2, 1 },
                    { 16, "", "/images/sweaters/sweater04.png", "Yellow Sweater", 350m, 2, 1 },
                    { 17, "", "/images/sweaters/sweater05.png", "3 Coloured Sweater", 350m, 2, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);
        }
    }
}
