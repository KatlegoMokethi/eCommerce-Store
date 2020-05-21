using Microsoft.EntityFrameworkCore.Migrations;

namespace YongzCreative.Migrations
{
    public partial class InitiateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Cap" },
                    { 2, "Hoodie" },
                    { 3, "Sweater" },
                    { 4, "T Shirt" },
                    { 5, "Sweatpants" },
                    { 6, "Leggings" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "Description", "ImagePath", "Name", "Price", "status" },
                values: new object[,]
                {
                    { 7, 1, "Meroon Cap", "/images/caps/cap04.png", "YONGZ Cap", 130m, 0 },
                    { 33, 4, "Pitch", "/images/tshirts/_0004_Tshirt.jpg", "YONGZ Top", 200m, 0 },
                    { 34, 4, "BAD ART Stickman", "/images/tshirts/_0005_Tshirt.jpg", "White Top", 200m, 0 },
                    { 35, 5, "", "/images/sweatpants/Sweatpants00.png", "Grey Sweatpants", 300m, 1 },
                    { 36, 5, "", "/images/sweatpants/Sweatpants01.png", "Red Sweatpants", 300m, 0 },
                    { 37, 5, "", "/images/sweatpants/Sweatpants02.png", "Yellow Sweatpants", 300m, 1 },
                    { 38, 5, "", "/images/sweatpants/Sweatpants03.png", "Grey Sweatpants", 300m, 1 },
                    { 18, 6, "", "/images/leggings/leggings00.png", "Black Leggings", 180m, 0 },
                    { 19, 6, "", "/images/leggings/leggings01.png", "Grey Leggings", 180m, 0 },
                    { 20, 6, "with white stripes", "/images/leggings/leggings02.png", "Black Leggings", 180m, 0 },
                    { 21, 6, "", "/images/leggings/leggings03.png", "Black Leggings", 180m, 0 },
                    { 22, 6, "", "/images/leggings/leggings04.png", "Pink Leggings", 180m, 1 },
                    { 23, 6, "", "/images/leggings/leggings05.png", "Navy Blue Leggings", 180m, 1 },
                    { 24, 6, "", "/images/leggings/leggings06.png", "Grey Leggings", 180m, 1 },
                    { 25, 6, "", "/images/leggings/leggings07.png", "Dark Blue Leggings", 180m, 1 },
                    { 26, 6, "", "/images/leggings/leggings08.png", "Double Grey Leggings", 180m, 1 },
                    { 32, 4, "White", "/images/tshirts/_0003_Tshirt.jpg", "YONGZ Top", 200m, 0 },
                    { 31, 4, "Black", "/images/tshirts/_0002_Tshirt.jpg", "YONGZ Top", 200m, 0 },
                    { 30, 4, "", "/images/tshirts/_0001_Tshirt.jpg", "White Top", 200m, 0 },
                    { 29, 4, "A collection of BAD ARD T-Shirts at only R200 each", "/images/tshirts/_0000_Tshirt.jpg", "T-Shirts", 200m, 0 },
                    { 8, 1, "Black Cap", "/images/caps/cap03.png", "YONGZ Cap", 130m, 0 },
                    { 9, 1, "Pitch Cap", "/images/caps/cap02.png", "YONGZ Cap", 130m, 0 },
                    { 10, 1, "Green Cap", "/images/caps/cap01.png", "BAD ART CAP", 130m, 1 },
                    { 11, 1, "Yellow Cap", "/images/caps/cap05.png", "BAD ART CAP", 130m, 1 },
                    { 1, 2, "A hoodie to rock your body.", "/images/hoodies/Hoodie01.png", "Blue Hoodie", 350m, 0 },
                    { 2, 2, "", "/images/hoodies/Hoodie02.png", "Orange Hoodie", 350m, 1 },
                    { 3, 2, "A splashed hoodie that adds taste to your body.", "/images/hoodies/Hoodie03.png", "Black Hoodie", 350m, 0 },
                    { 27, 6, "", "/images/leggings/leggings09.png", "Blue and Black Leggings", 180m, 1 },
                    { 4, 2, "Black and yellow kinda taste.", "/images/hoodies/Hoodie00.png", "Black Hoodie", 350m, 1 },
                    { 6, 2, "", "/images/hoodies/Hoodie05.png", "Grey and Blue Hoodie", 350m, 1 },
                    { 12, 3, "", "/images/sweaters/sweater00.png", "Sky Blue Sweater", 350m, 1 },
                    { 13, 3, "", "/images/sweaters/sweater01.png", "Black Sweater", 350m, 0 },
                    { 14, 3, "", "/images/sweaters/sweater02.png", "Orange Sweater", 350m, 0 },
                    { 15, 3, "", "/images/sweaters/sweater03.png", "Blue Sweater", 350m, 1 },
                    { 16, 3, "", "/images/sweaters/sweater04.png", "Yellow Sweater", 350m, 1 },
                    { 17, 3, "", "/images/sweaters/sweater05.png", "3 Coloured Sweater", 350m, 1 },
                    { 5, 2, "", "/images/hoodies/Hoodie04.png", "Black Hoodie", 350m, 0 },
                    { 28, 6, "", "/images/leggings/leggings10.png", "Black Leggings", 180m, 1 }
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);
        }
    }
}
