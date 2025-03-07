using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentDetailsExcersie.Data;
using StudentDetailsExcersie.Model;

namespace StudentDetailsExcersie.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly StudentContext dbContext;
        private readonly IMapper mapper;
        public SQLStudentRepository(StudentContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<Student?> GetById(int id)
        {
           return await dbContext.Students
                .Include(cd => cd.ContactDetails)
                .Include(bg => bg.BloodGroup)
                .Include(ad => ad.Address)
                .ThenInclude(ca => ca.CurrentAddress)
                .Include(ad => ad.Address)
                .ThenInclude(pa => pa.PermanentAddress).FirstOrDefaultAsync(x => x.StudentId == id);
        }

        public async Task<List<Student>> GetAll()
        {
           var StudentData = await dbContext.Students
                                            .Include(cd => cd.ContactDetails)
                                            .Include(bg => bg.BloodGroup)
                                            .Include(ad => ad.Address)
                                            .ThenInclude(ca => ca.CurrentAddress)
                                            .Include(ad => ad.Address)
                                            .ThenInclude(pa => pa.PermanentAddress).ToListAsync();
            return StudentData;

        }

        public async Task<Student> CreateStudent(Student student)
        {
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudent(int id,Student student)
        {
          var StudentData =  await dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == id);
          // var updateStudent = mapper.Map<Student>(student);
          if(StudentData == null)
            {
                return null;
            }
            StudentData.FirstName = student.FirstName;
            StudentData.LastName = student.LastName;
            StudentData.DateOfBarth = student.DateOfBarth;
            StudentData.Department = student.Department;
            StudentData.year = student.year;
            StudentData.ContactDetails = student.ContactDetails;
            StudentData.Address = student.Address;
            StudentData.BloodGroup = student.BloodGroup;
            await dbContext.SaveChangesAsync();
            return StudentData;
        }
    }
}
