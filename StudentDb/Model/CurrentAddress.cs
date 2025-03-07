using System.ComponentModel.DataAnnotations;

namespace StudentDb.Model
{
    public class CurrentAddress
    {

        [Key]
        public int CurrentAddressId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
    }
}
