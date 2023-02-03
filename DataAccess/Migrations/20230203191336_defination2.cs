using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class defination2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Definition_Metarials_MetarialID",
                table: "Definition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Definition",
                table: "Definition");

            migrationBuilder.RenameTable(
                name: "Definition",
                newName: "Definitions");

            migrationBuilder.RenameIndex(
                name: "IX_Definition_MetarialID",
                table: "Definitions",
                newName: "IX_Definitions_MetarialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Definitions",
                table: "Definitions",
                column: "DefinitionID");

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "DefinitionID", "DefinitionName", "MetarialID" },
                values: new object[] { 331, "Organic", 33 });

            migrationBuilder.InsertData(
                table: "Definitions",
                columns: new[] { "DefinitionID", "DefinitionName", "MetarialID" },
                values: new object[] { 332, "Inorganic", 33 });

            migrationBuilder.AddForeignKey(
                name: "FK_Definitions_Metarials_MetarialID",
                table: "Definitions",
                column: "MetarialID",
                principalTable: "Metarials",
                principalColumn: "MetarialID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Definitions_Metarials_MetarialID",
                table: "Definitions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Definitions",
                table: "Definitions");

            migrationBuilder.DeleteData(
                table: "Definitions",
                keyColumn: "DefinitionID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Definitions",
                keyColumn: "DefinitionID",
                keyValue: 332);

            migrationBuilder.RenameTable(
                name: "Definitions",
                newName: "Definition");

            migrationBuilder.RenameIndex(
                name: "IX_Definitions_MetarialID",
                table: "Definition",
                newName: "IX_Definition_MetarialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Definition",
                table: "Definition",
                column: "DefinitionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Definition_Metarials_MetarialID",
                table: "Definition",
                column: "MetarialID",
                principalTable: "Metarials",
                principalColumn: "MetarialID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
