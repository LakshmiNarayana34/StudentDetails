using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentDb.Model
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }


        [ForeignKey("CurrentAddress")]
        public int CurrentAddressId { get; set; }
        public CurrentAddress CurrentAddress { get; set; }

        [ForeignKey("PermanentAddress")]
        public int PermanentAddressId { get; set; }
        public PermanentAddress PermanentAddress { get; set; }

    }
}
