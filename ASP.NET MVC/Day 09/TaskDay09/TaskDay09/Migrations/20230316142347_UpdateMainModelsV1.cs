using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDay09.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMainModelsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.AddColumn<int>(
                name: "TraineeID",
                table: "CourseInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseInfo_TraineeID",
                table: "CourseInfo",
                column: "TraineeID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInfo_TraineeInfo_TraineeID",
                table: "CourseInfo",
                column: "TraineeID",
                principalTable: "TraineeInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInfo_TraineeInfo_TraineeID",
                table: "CourseInfo");

            migrationBuilder.DropIndex(
                name: "IX_CourseInfo_TraineeID",
                table: "CourseInfo");

            migrationBuilder.DropColumn(
                name: "TraineeID",
                table: "CourseInfo");

            migrationBuilder.CreateTable(
                name: "CourseTrainee",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    TraineesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainee", x => new { x.CoursesId, x.TraineesId });
                    table.ForeignKey(
                        name: "FK_CourseTrainee_CourseInfo_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "CourseInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTrainee_TraineeInfo_TraineesId",
                        column: x => x.TraineesId,
                        principalTable: "TraineeInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainee_TraineesId",
                table: "CourseTrainee",
                column: "TraineesId");
        }
    }
}
