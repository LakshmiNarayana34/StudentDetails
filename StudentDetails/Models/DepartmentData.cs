using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{
    public class DepartmentData
    {
        [Key]
        public int StudentDepartmentId {  get; set; }
        public string DepartmentName { get; set; }

    }
}
