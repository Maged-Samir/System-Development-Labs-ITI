using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI.Revision.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_teachers_teacherId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_teachers_teacherId",
                table: "courses",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_teachers_teacherId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_teachers_teacherId",
                table: "courses",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }
    }
}
