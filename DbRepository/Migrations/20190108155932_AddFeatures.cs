using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbRepository.Migrations
{
    public partial class AddFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MinTempoStep",
                table: "Lesson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RepeatNumber",
                table: "Lesson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartBpm",
                table: "Lesson",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivatedUserCourses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: true),
                    ActivatedCourseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivatedUserCourses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ActivatedUserCourses_Courses_ActivatedCourseID",
                        column: x => x.ActivatedCourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivatedUserCourses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivatedUserCourses_ActivatedCourseID",
                table: "ActivatedUserCourses",
                column: "ActivatedCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ActivatedUserCourses_UserID",
                table: "ActivatedUserCourses",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivatedUserCourses");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MinTempoStep",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "RepeatNumber",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "StartBpm",
                table: "Lesson");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");
        }
    }
}
