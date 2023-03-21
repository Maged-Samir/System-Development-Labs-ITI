using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDay09.Migrations
{
    /// <inheritdoc />
    public partial class CreateMainModelsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrackInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TraineeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TraineeInfo_TrackInfo_TrackID",
                        column: x => x.TrackID,
                        principalTable: "TrackInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TraineeInfo_TrackID",
                table: "TraineeInfo",
                column: "TrackID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.DropTable(
                name: "CourseInfo");

            migrationBuilder.DropTable(
                name: "TraineeInfo");

            migrationBuilder.DropTable(
                name: "TrackInfo");
        }
    }
}
