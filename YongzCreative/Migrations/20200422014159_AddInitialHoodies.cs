using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class AddInitialHoodies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "A hoodie to rock your body.", "/images/hoodies/Hoodie01.png", "Hoodie", 300m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "A hoodie to rock your body.", "/images/hoodies/Hoodie02.png", "Hoodie", 300m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "A hoodie to rock your body.", "/images/hoodies/Hoodie03.png", "Hoodie", 300m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "Black cap with a taste of red.", "~/images/Cap01.png", "YONGZ Cap", 275m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "Peach cap styled with maroon.", "~/images/Cap02.png", "YONGZ Cap", 1200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Description", "ImagePath", "Name", "Price" },
                values: new object[] { "Black cap lightened up with white.", "~/images/Cap03.png", "YONGZ Cap", 1200m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price" },
                values: new object[] { 4, "Maroon cap styled with white.", "~/images/Cap04.png", "YONGZ Cap", 1200m });
        }
    }
}
