using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF6Course.Context.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Periode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cour", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Etudiant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(384)", maxLength: 384, nullable: false),
                    DateInscription = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GETDATE()"),
                    Resultat = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiant", x => x.Id);
                    table.CheckConstraint("CK_Etudiant_Resultat", "(Resultat BETWEEN 0 AND 20)");
                    table.ForeignKey(
                        name: "FK_Etudiant_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inscription",
                columns: table => new
                {
                    EtudiantId = table.Column<int>(type: "int", nullable: false),
                    CourId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscription", x => new { x.EtudiantId, x.CourId, x.Year });
                    table.ForeignKey(
                        name: "FK_Inscription_Cour_CourId",
                        column: x => x.CourId,
                        principalTable: "Cour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscription_Etudiant_EtudiantId",
                        column: x => x.EtudiantId,
                        principalTable: "Etudiant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_Email",
                table: "Etudiant",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_SectionId",
                table: "Etudiant",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscription_CourId",
                table: "Inscription",
                column: "CourId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscription");

            migrationBuilder.DropTable(
                name: "Cour");

            migrationBuilder.DropTable(
                name: "Etudiant");

            migrationBuilder.DropTable(
                name: "Section");
        }
    }
}
