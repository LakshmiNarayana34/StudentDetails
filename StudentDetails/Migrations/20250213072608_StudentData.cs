using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressGroups",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressGroups", x => x.StudentAddressId);
                });

            migrationBuilder.CreateTable(
                name: "BloodGroups",
                columns: table => new
                {
                    StudentBloodGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups", x => x.StudentBloodGroupId);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentGroups",
                columns: table => new
                {
                    StudentDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentGroups", x => x.StudentDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "YearNames",
                columns: table => new
                {
                    StudentYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearNames", x => x.StudentYearId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    BloodGroupId = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    DepartmentDataStudentDepartmentId = table.Column<int>(type: "int", nullable: false),
                    AddressDataStudentAddressId = table.Column<int>(type: "int", nullable: false),
                    BloodGroupDataStudentBloodGroupId = table.Column<int>(type: "int", nullable: false),
                    YearNameDataStudentYearId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_AddressGroups_AddressDataStudentAddressId",
                        column: x => x.AddressDataStudentAddressId,
                        principalTable: "AddressGroups",
                        principalColumn: "StudentAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_BloodGroups_BloodGroupDataStudentBloodGroupId",
                        column: x => x.BloodGroupDataStudentBloodGroupId,
                        principalTable: "BloodGroups",
                        principalColumn: "StudentBloodGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_DepartmentGroups_DepartmentDataStudentDepartmentId",
                        column: x => x.DepartmentDataStudentDepartmentId,
                        principalTable: "DepartmentGroups",
                        principalColumn: "StudentDepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_YearNames_YearNameDataStudentYearId",
                        column: x => x.YearNameDataStudentYearId,
                        principalTable: "YearNames",
                        principalColumn: "StudentYearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AddressDataStudentAddressId",
                table: "Students",
                column: "AddressDataStudentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BloodGroupDataStudentBloodGroupId",
                table: "Students",
                column: "BloodGroupDataStudentBloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentDataStudentDepartmentId",
                table: "Students",
                column: "DepartmentDataStudentDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_YearNameDataStudentYearId",
                table: "Students",
                column: "YearNameDataStudentYearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AddressGroups");

            migrationBuilder.DropTable(
                name: "BloodGroups");

            migrationBuilder.DropTable(
                name: "DepartmentGroups");

            migrationBuilder.DropTable(
                name: "YearNames");
        }
    }
}
