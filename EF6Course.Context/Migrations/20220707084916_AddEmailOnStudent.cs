using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF6Course.Context.Migrations
{
    public partial class AddEmailOnStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Etudiant",
                type: "nvarchar(384)",
                maxLength: 384,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Etudiant");
        }
    }
}
