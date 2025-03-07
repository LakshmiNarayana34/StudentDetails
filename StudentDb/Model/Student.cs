using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentDb.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBarth { get; set; }
        public string Department { get; set; }
        public int year { get; set; }

        [ForeignKey("ContactDetails")]
        public int ContactDetailsId { get; set; }
        public ContactDetails ContactDetails { get; set; }

        [ForeignKey("BloodGroup")]
        public int BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
