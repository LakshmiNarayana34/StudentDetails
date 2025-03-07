using System.ComponentModel.DataAnnotations;

namespace StudentDetailsExcersie.Model
{
    public class BloodGroup
    {
        [Key]
        public int BloodGroupId { get; set; }
        public string BloodGroupName { get; set; }  

      

    }
}
