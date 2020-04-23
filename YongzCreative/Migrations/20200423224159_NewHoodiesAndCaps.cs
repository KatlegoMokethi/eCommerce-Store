using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class NewHoodiesAndCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "category",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "category" },
                values: new object[] { "Blue Hoodie", 350m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "category", "status" },
                values: new object[] { "", "Orange Hoodie", 350m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "category" },
                values: new object[] { "Black Hoodie", 350m, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price", "category", "status" },
                values: new object[,]
                {
                    { 4, "Black and yellow kinda taste.", "/images/hoodies/Hoodie00.png", "Black Hoodie", 350m, 1, 1 },
                    { 5, "", "/images/hoodies/Hoodie04.png", "Black Hoodie", 350m, 1, 0 },
                    { 6, "", "/images/hoodies/Hoodie05.png", "Grey and Blue Hoodie", 350m, 1, 1 },
                    { 7, "Meroon Cap", "/images/caps/cap04.png", "YONGZ Cap", 130m, 0, 0 },
                    { 8, "Black Cap", "/images/caps/cap03.png", "YONGZ Cap", 130m, 0, 0 },
                    { 9, "Pitch Cap", "/images/caps/cap02.png", "YONGZ Cap", 130m, 0, 0 },
                    { 10, "Green Cap", "/images/caps/cap01.png", "BAD ART CAP", 130m, 0, 1 },
                    { 11, "Yellow Cap", "/images/caps/cap05.png", "BAD ART CAP", 130m, 0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Hoodie", 300m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "A hoodie to rock your body.", "Hoodie", 300m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Hoodie", 300m });
        }
    }
}
