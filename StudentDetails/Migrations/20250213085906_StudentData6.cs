using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentGroups",
                columns: new[] { "StudentDepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 100, "CSE" },
                    { 101, "ECE" },
                    { 102, "CIVIL" },
                    { 103, "MECH" },
                    { 104, "EEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentGroups",
                keyColumn: "StudentDepartmentId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "DepartmentGroups",
                keyColumn: "StudentDepartmentId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "DepartmentGroups",
                keyColumn: "StudentDepartmentId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "DepartmentGroups",
                keyColumn: "StudentDepartmentId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "DepartmentGroups",
                keyColumn: "StudentDepartmentId",
                keyValue: 104);
        }
    }
}
