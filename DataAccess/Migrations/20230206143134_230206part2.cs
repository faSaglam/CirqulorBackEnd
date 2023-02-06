using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class _230206part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialMetrics",
                columns: table => new
                {
                    MaterialMetricID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicalPropertyID = table.Column<int>(type: "int", nullable: true),
                    PhysicalPropertyID = table.Column<int>(type: "int", nullable: true),
                    ElectricalPropertyID = table.Column<int>(type: "int", nullable: true),
                    ThermalPropertyID = table.Column<int>(type: "int", nullable: true),
                    OpticalPropertyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMetrics", x => x.MaterialMetricID);
                });

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
                name: "ElectricalProperties",
                columns: table => new
                {
                    ElectricalPropertyID = table.Column<int>(type: "int", nullable: false),
                    ElectricalResistivity = table.Column<int>(type: "int", nullable: true),
                    DielectricConstant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalProperties", x => x.ElectricalPropertyID);
                    table.ForeignKey(
                        name: "FK_ElectricalProperties_MaterialMetrics_ElectricalPropertyID",
                        column: x => x.ElectricalPropertyID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MechanicalProperties",
                columns: table => new
                {
                    MechanicalPropertyID = table.Column<int>(type: "int", nullable: false),
                    TensileStr = table.Column<int>(type: "int", nullable: true),
                    ElongationOfBreak = table.Column<int>(type: "int", nullable: true),
                    ModulusofElasticity = table.Column<int>(type: "int", nullable: true),
                    PoissonsRatio = table.Column<int>(type: "int", nullable: true),
                    ShearModulus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalProperties", x => x.MechanicalPropertyID);
                    table.ForeignKey(
                        name: "FK_MechanicalProperties_MaterialMetrics_MechanicalPropertyID",
                        column: x => x.MechanicalPropertyID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpticalProperties",
                columns: table => new
                {
                    OpticalPropertyID = table.Column<int>(type: "int", nullable: false),
                    RefractiveIndex = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpticalProperties", x => x.OpticalPropertyID);
                    table.ForeignKey(
                        name: "FK_OpticalProperties_MaterialMetrics_OpticalPropertyID",
                        column: x => x.OpticalPropertyID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalProperties",
                columns: table => new
                {
                    PhysicalPropertyID = table.Column<int>(type: "int", nullable: false),
                    Density = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalProperties", x => x.PhysicalPropertyID);
                    table.ForeignKey(
                        name: "FK_PhysicalProperties_MaterialMetrics_PhysicalPropertyID",
                        column: x => x.PhysicalPropertyID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThermalProperties",
                columns: table => new
                {
                    ThermalPropertyID = table.Column<int>(type: "int", nullable: false),
                    CTE = table.Column<int>(type: "int", nullable: true),
                    SpecificHeatCapacity = table.Column<int>(type: "int", nullable: true),
                    SofteningPoint = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThermalProperties", x => x.ThermalPropertyID);
                    table.ForeignKey(
                        name: "FK_ThermalProperties_MaterialMetrics_ThermalPropertyID",
                        column: x => x.ThermalPropertyID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Definitions",
                columns: table => new
                {
                    DefinitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefinitionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetarialID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Definitions", x => x.DefinitionID);
                    table.ForeignKey(
                        name: "FK_Definitions_Metarials_MetarialID",
                        column: x => x.MetarialID,
                        principalTable: "Metarials",
                        principalColumn: "MetarialID",
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

            migrationBuilder.CreateTable(
                name: "Origins",
                columns: table => new
                {
                    OriginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefinationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.OriginID);
                    table.ForeignKey(
                        name: "FK_Origins_Definitions_DefinationID",
                        column: x => x.DefinationID,
                        principalTable: "Definitions",
                        principalColumn: "DefinitionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.FormID);
                    table.ForeignKey(
                        name: "FK_Forms_Origins_OriginID",
                        column: x => x.OriginID,
                        principalTable: "Origins",
                        principalColumn: "OriginID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormID = table.Column<int>(type: "int", nullable: false),
                    PlantOfMaterialMetricID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantID);
                    table.ForeignKey(
                        name: "FK_Plants_Forms_FormID",
                        column: x => x.FormID,
                        principalTable: "Forms",
                        principalColumn: "FormID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plants_MaterialMetrics_PlantOfMaterialMetricID",
                        column: x => x.PlantOfMaterialMetricID,
                        principalTable: "MaterialMetrics",
                        principalColumn: "MaterialMetricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MaterialMetrics",
                columns: new[] { "MaterialMetricID", "ElectricalPropertyID", "MechanicalPropertyID", "Notes", "OpticalPropertyID", "PhysicalPropertyID", "ThermalPropertyID" },
                values: new object[] { 1, null, null, "Test test test", null, null, null });

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

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "DefinitionID", "DefinitionName", "MetarialID" },
                values: new object[] { 331, "Organic", 33 });

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "DefinitionID", "DefinitionName", "MetarialID" },
                values: new object[] { 332, "Inorganic", 33 });

            migrationBuilder.InsertData(
                table: "Origins",
                columns: new[] { "OriginID", "DefinationID", "OriginName" },
                values: new object[] { 3311, 331, "Lignocelulosic" });

            migrationBuilder.InsertData(
                table: "Origins",
                columns: new[] { "OriginID", "DefinationID", "OriginName" },
                values: new object[] { 3312, 331, "Agri-waste" });

            migrationBuilder.InsertData(
                table: "Origins",
                columns: new[] { "OriginID", "DefinationID", "OriginName" },
                values: new object[] { 3313, 331, "Other" });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "FormID", "FormName", "OriginID" },
                values: new object[] { 33111, "Fiber", 3311 });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantID", "FormID", "PlantName", "PlantOfMaterialMetricID" },
                values: new object[] { 331111, 33111, "Sisal", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Definitions_MetarialID",
                table: "Definitions",
                column: "MetarialID");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_OriginID",
                table: "Forms",
                column: "OriginID");

            migrationBuilder.CreateIndex(
                name: "IX_Metarials_TaxonomyID",
                table: "Metarials",
                column: "TaxonomyID");

            migrationBuilder.CreateIndex(
                name: "IX_Origins_DefinationID",
                table: "Origins",
                column: "DefinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_FormID",
                table: "Plants",
                column: "FormID");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_PlantOfMaterialMetricID",
                table: "Plants",
                column: "PlantOfMaterialMetricID",
                unique: true,
                filter: "[PlantOfMaterialMetricID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategoryID",
                table: "Product",
                column: "SubCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricalProperties");

            migrationBuilder.DropTable(
                name: "MechanicalProperties");

            migrationBuilder.DropTable(
                name: "OpticalProperties");

            migrationBuilder.DropTable(
                name: "PhysicalProperties");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ThermalProperties");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "MaterialMetrics");

            migrationBuilder.DropTable(
                name: "Origins");

            migrationBuilder.DropTable(
                name: "Definitions");

            migrationBuilder.DropTable(
                name: "Metarials");

            migrationBuilder.DropTable(
                name: "Taxonomies");
        }
    }
}
