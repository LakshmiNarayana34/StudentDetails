using System.ComponentModel.DataAnnotations;

namespace StudentDetailsExcersie.Model
{
    public class PermanentAddress
    {
        [Key]
        public int PermanentAddressId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }

        

    }
}
