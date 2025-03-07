using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Data;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDataDbContext dbContext;
        public StudentController(StudentDataDbContext dbContext) 
        {
          this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("StudentId/{id}")]
        public async Task<IActionResult> GetStudentDetails([FromRoute] int id)
        {
            //var StudentData = await dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == id);

          var result =  from s in dbContext.Students
            join d in dbContext.DepartmentGroups on s.StudentDepartmentId equals d.StudentDepartmentId
            join a in dbContext.AddressGroups on s.StudentAddressId equals a.StudentAddressId
            join b in dbContext.BloodGroups on s.StudentBloodGroupId equals b.StudentBloodGroupId
            join y in dbContext.YearNames on s.StudentYearId equals y.StudentYearId

            where s.StudentId == id

            select new
            {
                StudentId = s.StudentId,
                StudentName = s.StudentName,
                StudentDepartment = d.DepartmentName,
                Year = y.YearName,
                BloodGroup = b.BloodGroupName,
                Address = a.AddressName
            };

           
            return Ok(result);

        }
    }
}
