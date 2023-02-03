using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class origin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Origins_DefinationID",
                table: "Origins",
                column: "DefinationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Origins");
        }
    }
}
