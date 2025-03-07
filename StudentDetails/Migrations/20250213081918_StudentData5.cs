using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class StudentData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AddressGroups_AddressDataStudentAddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BloodGroups_BloodGroupDataStudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_YearNames_YearNameDataStudentYearId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "YearNameDataStudentYearId",
                table: "Students",
                newName: "StudentYearId");

            migrationBuilder.RenameColumn(
                name: "BloodGroupDataStudentBloodGroupId",
                table: "Students",
                newName: "StudentBloodGroupId");

            migrationBuilder.RenameColumn(
                name: "AddressDataStudentAddressId",
                table: "Students",
                newName: "StudentAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_YearNameDataStudentYearId",
                table: "Students",
                newName: "IX_Students_StudentYearId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_BloodGroupDataStudentBloodGroupId",
                table: "Students",
                newName: "IX_Students_StudentBloodGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_AddressDataStudentAddressId",
                table: "Students",
                newName: "IX_Students_StudentAddressId");

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
                name: "FK_Students_YearNames_StudentYearId",
                table: "Students",
                column: "StudentYearId",
                principalTable: "YearNames",
                principalColumn: "StudentYearId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AddressGroups_StudentAddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_BloodGroups_StudentBloodGroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_YearNames_StudentYearId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentYearId",
                table: "Students",
                newName: "YearNameDataStudentYearId");

            migrationBuilder.RenameColumn(
                name: "StudentBloodGroupId",
                table: "Students",
                newName: "BloodGroupDataStudentBloodGroupId");

            migrationBuilder.RenameColumn(
                name: "StudentAddressId",
                table: "Students",
                newName: "AddressDataStudentAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentYearId",
                table: "Students",
                newName: "IX_Students_YearNameDataStudentYearId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentBloodGroupId",
                table: "Students",
                newName: "IX_Students_BloodGroupDataStudentBloodGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentAddressId",
                table: "Students",
                newName: "IX_Students_AddressDataStudentAddressId");

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
                name: "FK_Students_YearNames_YearNameDataStudentYearId",
                table: "Students",
                column: "YearNameDataStudentYearId",
                principalTable: "YearNames",
                principalColumn: "StudentYearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
