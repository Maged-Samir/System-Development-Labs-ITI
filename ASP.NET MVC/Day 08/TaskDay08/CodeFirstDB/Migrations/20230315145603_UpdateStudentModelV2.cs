using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDB.Migrations
{
    public partial class UpdateStudentModelV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "StudentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "StudentInfo");
        }
    }
}
