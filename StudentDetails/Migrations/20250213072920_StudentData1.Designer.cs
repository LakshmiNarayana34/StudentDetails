﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentDetails.Data;

#nullable disable

namespace StudentDetails.Migrations
{
    [DbContext(typeof(StudentDataDbContext))]
    [Migration("20250213072920_StudentData1")]
    partial class StudentData1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentDetails.Models.AddressData", b =>
                {
                    b.Property<int>("StudentAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentAddressId"));

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentAddressId");

                    b.ToTable("AddressGroups");
                });

            modelBuilder.Entity("StudentDetails.Models.BloodGroupData", b =>
                {
                    b.Property<int>("StudentBloodGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentBloodGroupId"));

                    b.Property<string>("BloodGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentBloodGroupId");

                    b.ToTable("BloodGroups");
                });

            modelBuilder.Entity("StudentDetails.Models.DepartmentData", b =>
                {
                    b.Property<int>("StudentDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentDepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentDepartmentId");

                    b.ToTable("DepartmentGroups");
                });

            modelBuilder.Entity("StudentDetails.Models.StudentData", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("AddressDataStudentAddressId")
                        .HasColumnType("int");

                    b.Property<int>("BloodGroupDataStudentBloodGroupId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentDataStudentDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearNameDataStudentYearId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("AddressDataStudentAddressId");

                    b.HasIndex("BloodGroupDataStudentBloodGroupId");

                    b.HasIndex("DepartmentDataStudentDepartmentId");

                    b.HasIndex("YearNameDataStudentYearId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentDetails.Models.YearNameData", b =>
                {
                    b.Property<int>("StudentYearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentYearId"));

                    b.Property<string>("YearName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentYearId");

                    b.ToTable("YearNames");
                });

            modelBuilder.Entity("StudentDetails.Models.StudentData", b =>
                {
                    b.HasOne("StudentDetails.Models.AddressData", "AddressData")
                        .WithMany()
                        .HasForeignKey("AddressDataStudentAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDetails.Models.BloodGroupData", "BloodGroupData")
                        .WithMany()
                        .HasForeignKey("BloodGroupDataStudentBloodGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDetails.Models.DepartmentData", "DepartmentData")
                        .WithMany()
                        .HasForeignKey("DepartmentDataStudentDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDetails.Models.YearNameData", "YearNameData")
                        .WithMany()
                        .HasForeignKey("YearNameDataStudentYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressData");

                    b.Navigation("BloodGroupData");

                    b.Navigation("DepartmentData");

                    b.Navigation("YearNameData");
                });
#pragma warning restore 612, 618
        }
    }
}
