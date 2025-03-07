using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetailsExcersie.Model
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }


        [ForeignKey("CurrentAddress")]
        public int CurrentAddressId { get; set; }
        [ForeignKey("PermanentAddress")]
        public int PermanentAddressId { get; set; }
        public CurrentAddress CurrentAddress { get; set; }

        public PermanentAddress PermanentAddress { get; set; }

    }
}
