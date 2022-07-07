using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF6Course.Context.Migrations
{
    public partial class AddCourseConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Cour",
                type: "nchar(64)",
                fixedLength: true,
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Cour",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(64)",
                oldFixedLength: true,
                oldMaxLength: 64);
        }
    }
}
