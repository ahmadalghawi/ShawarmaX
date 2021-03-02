using Microsoft.EntityFrameworkCore.Migrations;

namespace ShawarmaX.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShawarmaId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Shawarmas_ShawarmaId",
                        column: x => x.ShawarmaId,
                        principalTable: "Shawarmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Shawarmas",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://scontent-arn2-1.xx.fbcdn.net/v/t1.0-9/13179290_614365935380238_346645495429938451_n.jpg?_nc_cat=111&ccb=3&_nc_sid=9267fe&_nc_ohc=B2VTtdiDM7oAX-OMK8v&_nc_oc=AQnCscYlcIg74Vw_9QBncQ6aAjzYVuMAjYciFamnSPPp1aX98LFIBSxt9ZJhe19wZ-o&_nc_ht=scontent-arn2-1.xx&oh=12343366a3fc5465c65bf3ace7a58a99&oe=60553F9E");

            migrationBuilder.UpdateData(
                table: "Shawarmas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "https://www.shawarmer.com/assets/api/products/90265.jpg", ". Pepsi Diet klass 400ml.", "Pepsi Diet", 0.50m, " Pepsi klass 400ml !" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShawarmaId",
                table: "ShoppingCartItems",
                column: "ShawarmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Shawarmas",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://en.wikipedia.org/wiki/Kanafeh#/media/File:Kanafeh_Nabulsieh.jpg");

            migrationBuilder.UpdateData(
                table: "Shawarmas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { "https://www.shawarmer.com/assets/api/products/87-2.jpg", ". aquafena Water 500ml.", "water", 0.40m, " water 500ml !" });
        }
    }
}
