using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AddressGroups",
                columns: new[] { "StudentAddressId", "AddressName" },
                values: new object[,]
                {
                    { 200, "Bangalore" },
                    { 201, "Vizag" },
                    { 202, "Hydrabad" },
                    { 203, "Cheinnai" },
                    { 204, "Mumbai" }
                });

            migrationBuilder.InsertData(
                table: "BloodGroups",
                columns: new[] { "StudentBloodGroupId", "BloodGroupName" },
                values: new object[,]
                {
                    { 300, "O+ve" },
                    { 301, "A+ve" },
                    { 302, "AB+ve" },
                    { 303, "B+ve" }
                });

            migrationBuilder.InsertData(
                table: "YearNames",
                columns: new[] { "StudentYearId", "YearName" },
                values: new object[,]
                {
                    { 401, "FirstYear" },
                    { 402, "SecondYear" },
                    { 403, "ThirdYear" },
                    { 404, "FouthYear" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddressGroups",
                keyColumn: "StudentAddressId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "AddressGroups",
                keyColumn: "StudentAddressId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "AddressGroups",
                keyColumn: "StudentAddressId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "AddressGroups",
                keyColumn: "StudentAddressId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "AddressGroups",
                keyColumn: "StudentAddressId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "StudentBloodGroupId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "StudentBloodGroupId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "StudentBloodGroupId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "BloodGroups",
                keyColumn: "StudentBloodGroupId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "YearNames",
                keyColumn: "StudentYearId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "YearNames",
                keyColumn: "StudentYearId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "YearNames",
                keyColumn: "StudentYearId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "YearNames",
                keyColumn: "StudentYearId",
                keyValue: 404);
        }
    }
}
