using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentAddressId", "StudentBloodGroupId", "StudentDepartmentId", "StudentName", "StudentYearId" },
                values: new object[,]
                {
                    { 1, 200, 300, 100, "Lakshmi Narayana", 404 },
                    { 2, 202, 301, 101, "Nilotpal", 402 },
                    { 3, 201, 303, 102, "Mani", 401 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
