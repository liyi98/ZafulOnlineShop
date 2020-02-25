using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZafulApp.Migrations
{
    public partial class Cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Cart_CartId",
                table: "CartProduct");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_CartProduct_CartId",
                table: "CartProduct");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartProduct");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CartProduct",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CartProduct");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "CartProduct",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_CartId",
                table: "CartProduct",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Cart_CartId",
                table: "CartProduct",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
