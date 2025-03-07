using System.ComponentModel.DataAnnotations;

namespace StudentDetailsExcersie.Dtos
{
    public class CreateStudentDataDto
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBarth { get; set; }
        public string Department { get; set; }
        public int year { get; set; }
        public ContactDetailsDto ContactDetails { get; set; }
        public BloodGroupDto BloodGroup { get; set; }
        public AddressDto Address { get; set; }
    }
}
