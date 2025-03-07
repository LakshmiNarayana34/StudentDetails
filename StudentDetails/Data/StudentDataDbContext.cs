using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;

namespace StudentDetails.Data
{
    public class StudentDataDbContext : DbContext
    {
        public StudentDataDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
           var departmentData = new List<DepartmentData>
            {//test
                    new DepartmentData()
                    {
                        StudentDepartmentId = 100,
                        DepartmentName = "CSE"
                    },
                    new DepartmentData()
                    {
                        StudentDepartmentId = 101,
                        DepartmentName = "ECE"
                    },
                    new DepartmentData()
                    {
                        StudentDepartmentId = 102,
                        DepartmentName = "CIVIL"
                    },
                    new DepartmentData()
                    {
                        StudentDepartmentId = 103,
                        DepartmentName = "MECH"
                    },
                    new DepartmentData()
                    {
                        StudentDepartmentId = 104,
                        DepartmentName = "EEE"
                    }

            };

            var addressData = new List<AddressData>
            {
                new AddressData()
                {
                    StudentAddressId = 200,
                    AddressName = "Bangalore"
                },
                new AddressData()
                {
                    StudentAddressId = 201,
                    AddressName = "Vizag"
                },
                new AddressData()
                {
                StudentAddressId = 202,
                AddressName = "Hydrabad"
                },
                new AddressData()
                {
                StudentAddressId = 203,
                AddressName = "Cheinnai"
                },
                new AddressData()
                {
                StudentAddressId = 204,
                AddressName = "Mumbai"
                }
            };

            var bloodGroupData = new List<BloodGroupData>
            {
                new BloodGroupData()
                {
                    StudentBloodGroupId = 300,
                    BloodGroupName = "O+ve"
                },
                new BloodGroupData()
                {
                    StudentBloodGroupId = 301,
                    BloodGroupName = "A+ve"
                },
                 new BloodGroupData()
                {
                    StudentBloodGroupId = 302,
                    BloodGroupName = "AB+ve"
                },
                  new BloodGroupData()
                  {
                    StudentBloodGroupId = 303,
                    BloodGroupName = "B+ve"
                  }
            };

            var yearData = new List<YearNameData>
            {
                new YearNameData()
                {
                    StudentYearId = 401,
                    YearName = "FirstYear"
                },
                new YearNameData()
                {
                    StudentYearId = 402,
                    YearName = "SecondYear"
                },
                new YearNameData()
                {
                    StudentYearId = 403,
                    YearName = "ThirdYear"
                },
                new YearNameData()
                {
                    StudentYearId = 404,
                    YearName = "FouthYear"
                }

            };

            var studentDetails = new List<StudentData>
            {
                new StudentData()
                {
                    StudentId = 1,
                    StudentName ="Lakshmi Narayana",
                    StudentDepartmentId = 100,
                    StudentAddressId = 200,
                    StudentBloodGroupId = 300,
                    StudentYearId = 404

                },
                 new StudentData()
                 {
                    StudentId = 2,
                    StudentName ="Nilotpal",
                    StudentDepartmentId = 101,
                    StudentAddressId = 202,
                    StudentBloodGroupId = 301,
                    StudentYearId = 402

                 },
                  new StudentData()
                  {
                    StudentId = 3,
                    StudentName ="Mani",
                    StudentDepartmentId = 102,
                    StudentAddressId = 201,
                    StudentBloodGroupId = 303,
                    StudentYearId = 401

                  },
                   new StudentData()
                  {
                    StudentId = 4,
                    StudentName ="Mani",
                    StudentDepartmentId = 106,
                    StudentAddressId = 201,
                    StudentBloodGroupId = 303,
                    StudentYearId = 401

                  }
            };

            modelbuilder.Entity<DepartmentData>().HasData(departmentData);
            modelbuilder.Entity<AddressData>().HasData(addressData);
            modelbuilder.Entity<BloodGroupData>().HasData(bloodGroupData);
            modelbuilder.Entity<YearNameData>().HasData(yearData);
            modelbuilder.Entity<StudentData>().HasData(studentDetails);



        }

        public DbSet<StudentData> Students { get; set; }
        public DbSet<BloodGroupData> BloodGroups { get; set; }
        public DbSet<DepartmentData> DepartmentGroups { get; set; }
        public DbSet<AddressData> AddressGroups { get; set; }

        public DbSet<YearNameData> YearNames { get; set; }
    }
}
