using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class defination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Definition",
                columns: table => new
                {
                    DefinitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefinitionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetarialID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Definition", x => x.DefinitionID);
                    table.ForeignKey(
                        name: "FK_Definition_Metarials_MetarialID",
                        column: x => x.MetarialID,
                        principalTable: "Metarials",
                        principalColumn: "MetarialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Definition_MetarialID",
                table: "Definition",
                column: "MetarialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Definition");
        }
    }
}
