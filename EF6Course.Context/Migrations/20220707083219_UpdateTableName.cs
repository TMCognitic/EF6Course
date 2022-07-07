using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF6Course.Context.Migrations
{
    public partial class UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etudiants",
                table: "Etudiants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cours",
                table: "Cours");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameTable(
                name: "Etudiants",
                newName: "Etudiant");

            migrationBuilder.RenameTable(
                name: "Cours",
                newName: "Cour");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etudiant",
                table: "Etudiant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cour",
                table: "Cour",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etudiant",
                table: "Etudiant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cour",
                table: "Cour");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameTable(
                name: "Etudiant",
                newName: "Etudiants");

            migrationBuilder.RenameTable(
                name: "Cour",
                newName: "Cours");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etudiants",
                table: "Etudiants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cours",
                table: "Cours",
                column: "Id");
        }
    }
}
