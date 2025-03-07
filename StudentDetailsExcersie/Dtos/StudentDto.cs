using StudentDetailsExcersie.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetailsExcersie.Dtos
{
    public class StudentDto
    {
       
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
