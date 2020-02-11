using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImagePath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Black cap with a taste of red.", "~\\images\\Cap01.png", "YONGZ Cap", 275m },
                    { 2, "Peach cap styled with maroon.", "~\\images\\Cap02.png", "YONGZ Cap", 1200m },
                    { 3, "Black cap lightened up with white.", "~\\images\\Cap03.png", "YONGZ Cap", 1200m },
                    { 4, "Maroon cap styled with white.", "~\\images\\Cap04.png", "YONGZ Cap", 1200m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");
        }
    }
}
