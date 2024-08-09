using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class CreateAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "EnrolledCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "CourseSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_AdminId",
                table: "Teachers",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdminId",
                table: "Students",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourses_AdminId",
                table: "EnrolledCourses",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSchedule_AdminId",
                table: "CourseSchedule",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AdminId",
                table: "Courses",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Admins_AdminId",
                table: "Courses",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSchedule_Admins_AdminId",
                table: "CourseSchedule",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnrolledCourses_Admins_AdminId",
                table: "EnrolledCourses",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Admins_AdminId",
                table: "Students",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Admins_AdminId",
                table: "Teachers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Admins_AdminId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseSchedule_Admins_AdminId",
                table: "CourseSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_EnrolledCourses_Admins_AdminId",
                table: "EnrolledCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Admins_AdminId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Admins_AdminId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_AdminId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_AdminId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_EnrolledCourses_AdminId",
                table: "EnrolledCourses");

            migrationBuilder.DropIndex(
                name: "IX_CourseSchedule_AdminId",
                table: "CourseSchedule");

            migrationBuilder.DropIndex(
                name: "IX_Courses_AdminId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "EnrolledCourses");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "CourseSchedule");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Courses");
        }
    }
}
