using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetails.Models
{
    public class StudentData
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName {  get; set; }

        public int StudentAddressId { get; set; }
        public int StudentDepartmentId { get; set; }
        public int StudentBloodGroupId { get; set; }
        public int StudentYearId { get; set; }

        [ForeignKey(nameof(StudentDepartmentId))]
        public DepartmentData DepartmentData { get; set; }
        
        [ForeignKey(nameof(StudentAddressId))]
        public AddressData AddressData { get; set; }
        
        [ForeignKey(nameof(StudentBloodGroupId))]
        public BloodGroupData BloodGroupData { get; set; }
        
        [ForeignKey(nameof(StudentYearId))]
        public YearNameData YearNameData { get; set; }
    }
}
