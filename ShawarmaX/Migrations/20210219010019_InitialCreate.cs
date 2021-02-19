using Microsoft.EntityFrameworkCore.Migrations;

namespace ShawarmaX.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Shawarmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOffer = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shawarmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shawarmas_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Meals", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Desserts", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Drinks and snacks", null });

            migrationBuilder.InsertData(
                table: "Shawarmas",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "InStock", "IsOffer", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://www.shawarmer.com/assets/api/products/172.jpg", true, false, ".Chicken shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.", "Shawarma Chicken", 1.95m, "Turkish Chicken Shawarma Sandwich!" },
                    { 16, 3, "https://www.shawarmer.com/assets/api/products/80025-2.jpg", true, false, ". any sauce : cheese , mayounez , katchap , hot , trkish sauce , halpenus and shawrma sauce.", "sauce box", 0.50m, " sauce 30ml !" },
                    { 15, 3, "https://www.shawarmer.com/assets/api/products/87-2.jpg", true, false, ". aquafena Water 500ml.", "water", 0.40m, " water 500ml !" },
                    { 14, 3, "https://www.shawarmer.com/assets/api/products/84.jpg", true, false, ". Mirinda klass 400ml.", "Mirinda", 0.50m, " Mirinda klass 400ml !" },
                    { 13, 3, "https://www.shawarmer.com/assets/api/products/80.jpg", true, false, ". 7up klass 400ml.", "7up", 0.50m, " 7up klass 400ml !" },
                    { 12, 3, "https://www.shawarmer.com/assets/api/products/76.jpg", true, false, ". Pepsi klass 400ml.", "Pepsi", 0.50m, " Pepsi klass 400ml !" },
                    { 11, 2, "https://www.shawarmer.com/assets/api/products/40032-2.jpg", true, true, ".A box contains 15 pieces of chocolate cookies stuffed with brownie particles.", "cookies", 1.50m, " cookies chocklate !" },
                    { 10, 2, "https://www.shawarmer.com/assets/api/products/40075-2.jpg", true, true, ".Dough  pistachios and topped with syrup.", "Basbousah", 1.00m, " Arabic Desserts !" },
                    { 9, 2, "https://www.shawarmer.com/assets/api/products/40075-2.jpg", true, false, ".Dough  pistachios and topped with syrup.", "Basbousah", 1.50m, " Arabic Desserts !" },
                    { 8, 2, "https://en.wikipedia.org/wiki/Kanafeh#/media/File:Kanafeh_Nabulsieh.jpg", true, false, ".Dough contains goat cheese and pistachios and topped with syrup.", "kunafeh", 1.50m, " Turkish Desserts !" },
                    { 7, 1, "https://www.shawarmer.com/assets/api/products/130016.jpg", true, true, ".Turkish Chicken OR meat Shawarma Box! with potato and Pepsi with sauce and pickles.", "Shawarma Box Offers", 4.95m, " Turkish Chicken OR meat Shawarma !" },
                    { 6, 1, "https://www.shawarmer.com/assets/api/products/130145.jpg", true, true, ".30 pics Turkish Chicken OR meat Shawarma ! with 6 favorite sauce .", "Shawarma Mega Offers", 7.95m, " Turkish Chicken OR meat Shawarma Mega Box!" },
                    { 5, 1, "https://www.shawarmer.com/assets/api/products/130013.jpg", true, true, ".3 Turkish Chicken OR meat Shawarma Sandwich! with potato and Pepsi with sauce and pickles.", "Shawarma Chicken Offers", 5.95m, " Turkish Chicken OR meat Shawarma Sandwich!" },
                    { 4, 1, "https://www.shawarmer.com/assets/api/products/148.jpg", true, false, ".Chicken and meat shawarma with potato and sauce pickles and lettuce.", "Shawarma Dubble X", 2.95m, "Turkish Chicken and meat Shawarma Sandwich!" },
                    { 3, 1, "https://www.shawarmer.com/assets/api/products/130249.jpg", true, false, ".Chicken and meat shawarma with 3 favorite sauce with taco bread and potato and pickles.", "Shawarma Box", 5.95m, "Turkish Chicken and meat Shawarma Sandwich!" },
                    { 2, 1, "https://www.shawarmer.com/assets/api/products/174.jpg", true, false, ".Meat shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.", "Turkish meat Shawarma Sandwich!", 1.95m, "You'll love it!" },
                    { 17, 3, "https://www.shawarmer.com/assets/api/products/177.jpg", true, false, ". potato box 300ml with any sauce.", "potato box", 0.80m, " potato box 300ml !" },
                    { 18, 3, "https://www.shawarmer.com/assets/api/products/80019-2.jpg", true, false, ". Pickled and jalapeno box 100ml .", "Pickled and jalapeno box", 0.80m, " Pickled and jalapeno 100ml !" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shawarmas_CategoryId",
                table: "Shawarmas",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shawarmas");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
