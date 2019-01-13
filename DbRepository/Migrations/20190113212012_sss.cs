using Microsoft.EntityFrameworkCore.Migrations;

namespace DbRepository.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivatedUserCourses_Courses_ActivatedCourseID",
                table: "ActivatedUserCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ActivatedUserCourses_Users_UserID",
                table: "ActivatedUserCourses");

            migrationBuilder.DropIndex(
                name: "IX_ActivatedUserCourses_ActivatedCourseID",
                table: "ActivatedUserCourses");

            migrationBuilder.DropIndex(
                name: "IX_ActivatedUserCourses_UserID",
                table: "ActivatedUserCourses");

            migrationBuilder.DropColumn(
                name: "ActivatedCourseID",
                table: "ActivatedUserCourses");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ActivatedUserCourses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "ActivatedUserCourses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "ActivatedUserCourses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "ActivatedUserCourses");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "ActivatedUserCourses");

            migrationBuilder.AddColumn<int>(
                name: "ActivatedCourseID",
                table: "ActivatedUserCourses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "ActivatedUserCourses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivatedUserCourses_ActivatedCourseID",
                table: "ActivatedUserCourses",
                column: "ActivatedCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ActivatedUserCourses_UserID",
                table: "ActivatedUserCourses",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivatedUserCourses_Courses_ActivatedCourseID",
                table: "ActivatedUserCourses",
                column: "ActivatedCourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivatedUserCourses_Users_UserID",
                table: "ActivatedUserCourses",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
