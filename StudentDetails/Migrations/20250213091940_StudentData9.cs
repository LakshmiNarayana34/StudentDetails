using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AddressGroups_StudentAddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BloodGroups_StudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_DepartmentGroups_StudentDepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_YearNames_StudentYearId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentAddressId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentDepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentYearId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "AddressDataStudentAddressId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BloodGroupDataStudentBloodGroupId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDataStudentDepartmentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearNameDataStudentYearId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AddressGroups_AddressDataStudentAddressId",
                table: "Students",
                column: "AddressDataStudentAddressId",
                principalTable: "AddressGroups",
                principalColumn: "StudentAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BloodGroups_BloodGroupDataStudentBloodGroupId",
                table: "Students",
                column: "BloodGroupDataStudentBloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "StudentBloodGroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DepartmentGroups_DepartmentDataStudentDepartmentId",
                table: "Students",
                column: "DepartmentDataStudentDepartmentId",
                principalTable: "DepartmentGroups",
                principalColumn: "StudentDepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_YearNames_YearNameDataStudentYearId",
                table: "Students",
                column: "YearNameDataStudentYearId",
                principalTable: "YearNames",
                principalColumn: "StudentYearId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AddressGroups_AddressDataStudentAddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BloodGroups_BloodGroupDataStudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_DepartmentGroups_DepartmentDataStudentDepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_YearNames_YearNameDataStudentYearId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AddressDataStudentAddressId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_BloodGroupDataStudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentDataStudentDepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_YearNameDataStudentYearId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddressDataStudentAddressId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BloodGroupDataStudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DepartmentDataStudentDepartmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "YearNameDataStudentYearId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentAddressId",
                table: "Students",
                column: "StudentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentBloodGroupId",
                table: "Students",
                column: "StudentBloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentDepartmentId",
                table: "Students",
                column: "StudentDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentYearId",
                table: "Students",
                column: "StudentYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AddressGroups_StudentAddressId",
                table: "Students",
                column: "StudentAddressId",
                principalTable: "AddressGroups",
                principalColumn: "StudentAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_BloodGroups_StudentBloodGroupId",
                table: "Students",
                column: "StudentBloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "StudentBloodGroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_DepartmentGroups_StudentDepartmentId",
                table: "Students",
                column: "StudentDepartmentId",
                principalTable: "DepartmentGroups",
                principalColumn: "StudentDepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_YearNames_StudentYearId",
                table: "Students",
                column: "StudentYearId",
                principalTable: "YearNames",
                principalColumn: "StudentYearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
