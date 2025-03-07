using AutoMapper;
using StudentDetailsExcersie.Dtos;
using StudentDetailsExcersie.Model;
namespace StudentDetailsExcersie.Mapping
{
    public class AutoMappingProfiles : Profile
    {
        public AutoMappingProfiles()
        {
           CreateMap<Student,StudentDto>().ReverseMap();
           CreateMap<ContactDetails,ContactDetailsDto>().ReverseMap();
           CreateMap<BloodGroup,BloodGroupDto>().ReverseMap();
           CreateMap<Address,AddressDto>().ReverseMap();
           CreateMap<CurrentAddress,CurrentAddressDto>().ReverseMap();
           CreateMap<PermanentAddress,PermenentAddressDto>().ReverseMap();
           CreateMap<CreateStudentDataDto,Student>().ReverseMap();
        }
    }
}
