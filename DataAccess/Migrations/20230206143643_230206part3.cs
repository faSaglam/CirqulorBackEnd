using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class _230206part3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Metarials_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "Metarials",
                        principalColumn: "MetarialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryID",
                table: "Product",
                column: "SubCategoryID");
        }
    }
}
