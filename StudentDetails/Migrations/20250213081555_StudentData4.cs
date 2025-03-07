using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_DepartmentGroups_DepartmentDataStudentDepartmentId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmentDataStudentDepartmentId",
                table: "Students",
                newName: "StudentDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentDataStudentDepartmentId",
                table: "Students",
                newName: "IX_Students_StudentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DepartmentGroups_StudentDepartmentId",
                table: "Students",
                column: "StudentDepartmentId",
                principalTable: "DepartmentGroups",
                principalColumn: "StudentDepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_DepartmentGroups_StudentDepartmentId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentDepartmentId",
                table: "Students",
                newName: "DepartmentDataStudentDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentDepartmentId",
                table: "Students",
                newName: "IX_Students_DepartmentDataStudentDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DepartmentGroups_DepartmentDataStudentDepartmentId",
                table: "Students",
                column: "DepartmentDataStudentDepartmentId",
                principalTable: "DepartmentGroups",
                principalColumn: "StudentDepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
