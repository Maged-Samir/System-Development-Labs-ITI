using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDB.Migrations
{
    public partial class UpdateStudentModelV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "StudentInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "StudentInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
