using System.ComponentModel.DataAnnotations;

namespace StudentDetails.Models
{
    public class AddressData
    {
        [Key]
        public int StudentAddressId { get; set; }
        public string AddressName { get; set; }
    }
}
