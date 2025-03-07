using StudentDetailsExcersie.Model;

namespace StudentDetailsExcersie.Dtos
{
    public class AddressDto
    {
        public CurrentAddressDto CurrentAddress { get; set; }

        public PermenentAddressDto PermanentAddress { get; set; }
    }
}
