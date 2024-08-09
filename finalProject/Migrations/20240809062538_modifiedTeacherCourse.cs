using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalProject.Migrations
{
    /// <inheritdoc />
    public partial class modifiedTeacherCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "Teachers",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Teachers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Students",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Students",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Admins",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Admins",
                newName: "Password");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourse_Teachers_TeacherId",
                table: "TeacherCourse",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourse_Teachers_TeacherId",
                table: "TeacherCourse");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Teachers",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Teachers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Students",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Students",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Admins",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Admins",
                newName: "password");
        }
    }
}
