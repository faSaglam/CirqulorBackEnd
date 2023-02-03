using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class taxonomyandmetarial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxonomies",
                columns: table => new
                {
                    TaxonomyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxonomyName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxonomies", x => x.TaxonomyID);
                });

            migrationBuilder.CreateTable(
                name: "Metarials",
                columns: table => new
                {
                    MetarialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetarialName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    TaxonomyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metarials", x => x.MetarialID);
                    table.ForeignKey(
                        name: "FK_Metarials_Taxonomies_TaxonomyID",
                        column: x => x.TaxonomyID,
                        principalTable: "Taxonomies",
                        principalColumn: "TaxonomyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Taxonomies",
                columns: new[] { "TaxonomyID", "TaxonomyName" },
                values: new object[,]
                {
                    { 1, "Carbon" },
                    { 2, "Ceramic Replacement" },
                    { 3, "Engineering Material" },
                    { 4, "Fluid" },
                    { 5, "Polymer" }
                });

            migrationBuilder.InsertData(
                table: "Metarials",
                columns: new[] { "MetarialID", "MetarialName", "TaxonomyID" },
                values: new object[,]
                {
                    { 31, "Aerogel ", 3 },
                    { 32, "Composite Fibers ", 3 },
                    { 33, "Additive/Filler for Polymer  ", 3 },
                    { 34, "Catalyst/Initiator", 3 },
                    { 35, "Composite Core Material ", 3 },
                    { 37, "Semiconductor ", 3 },
                    { 38, "Metal Foam, Mesh, or Honeycomb  ", 3 },
                    { 39, "Metal Matrix Composite ", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Metarials_TaxonomyID",
                table: "Metarials",
                column: "TaxonomyID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryID",
                table: "Product",
                column: "SubCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Metarials");

            migrationBuilder.DropTable(
                name: "Taxonomies");
        }
    }
}
