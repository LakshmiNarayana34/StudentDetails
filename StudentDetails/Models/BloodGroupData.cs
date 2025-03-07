using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{
    public class BloodGroupData
    {
        [Key]
        public int StudentBloodGroupId { get; set; }
        public string BloodGroupName { get; set; }
    }
}
