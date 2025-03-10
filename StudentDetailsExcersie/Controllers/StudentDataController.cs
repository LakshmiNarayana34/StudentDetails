using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetailsExcersie.Data;
using StudentDetailsExcersie.Dtos;
using StudentDetailsExcersie.Model;
using StudentDetailsExcersie.Repositories;
using StudentDetailsExcersie.Dtos.ErrorResponse;

namespace StudentDetailsExcersie.Controllers
{
    [Route("api/[controller]")]////
    [ApiController]///
    public class StudentDataController : ControllerBase
    {
        //   private readonly StudentContext _studentContext;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public StudentDataController( IMapper _mapper, IStudentRepository _studentRepository)
        {
            //this._studentContext = _studentContext;
            this._mapper = _mapper;
            this._studentRepository = _studentRepository;
        }
/*
        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] StudentUpdateDto studentUpdateDto)
        {
            var StudentData = new Student()
            {
               
                FirstName = studentUpdateDto.FirstName,
                LastName = studentUpdateDto.LastName,
                DateOfBarth = studentUpdateDto.DateOfBarth,
                Department = studentUpdateDto.Department,
                year = studentUpdateDto.year,
                


            };

            await _studentContext.AddAsync(StudentData);
            await _studentContext.SaveChangesAsync();
            return Ok(StudentData);
        }
*/

        [HttpPost("passData")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(StudentDto))]

        public async Task<IActionResult> CreateStudentDetails([FromBody] CreateStudentDataDto createStudentDataDto)
        {

            if (ModelState.IsValid)
            {
                var student = _mapper.Map<Student>(createStudentDataDto);
                await _studentRepository.CreateStudent(student);

                var studentDto = _mapper.Map<StudentDto>(student);
                return Ok(studentDto);
            }
            return BadRequest();
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StudentDto>), 200)]
      
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        {
            /* var ResultSet = await _studentContext.Students
                  .Include(cd => cd.ContactDetails)
                  .Include(bg => bg.BloodGroup)
                  .Include(ad => ad.Address)
                  .ThenInclude(ca => ca.CurrentAddress)
                  .Include(ad =>ad.Address)
                  .ThenInclude(pa => pa.PermanentAddress).ToListAsync(); */

           var ResultSet = await _studentRepository.GetAll();

            var studentDto = _mapper.Map<List<StudentDto>>(ResultSet);
           
                return Ok(studentDto);

           

            
        }
        [HttpGet("StudentId")]
        [ProducesResponseType(typeof(IEnumerable<StudentDto>), 200)]
        [ProducesResponseType(typeof(StudentErrorResponse), 404)]
      
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StudentDto))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            /*  var resultSet = await _studentContext.Students
                   .Include(cd => cd.ContactDetails)
                   .Include(bg => bg.BloodGroup)
                   .Include(ad => ad.Address)
                   .ThenInclude(ca => ca.CurrentAddress)
                   .Include(ad => ad.Address)
                   .ThenInclude(pa => pa.PermanentAddress).FirstOrDefaultAsync(x => x.StudentId == id);*/
            if(id == 0 || id < 0) 
            {
                return BadRequest();
            }
            var resultSet = await _studentRepository.GetById(id);

            var studentDto =  _mapper.Map<StudentDto>(resultSet);


            if (resultSet != null)
            {
                return Ok(studentDto);

            }
            return NotFound(new StudentErrorResponse());
        }


        [HttpPut("UpdateStudentData")]
        [ProducesResponseType(typeof(StudentDto),200)]
        public async Task<IActionResult> UpdateStudentData([FromQuery] int id,[FromBody] CreateStudentDataDto createStudentDataDto)
        {
           var student = _mapper.Map<Student>(createStudentDataDto);
           var UpdateStudentDto = await _studentRepository.UpdateStudent(id, student);
           var studentDto = _mapper.Map<StudentDto>(UpdateStudentDto);
           return Ok(studentDto);

        }


    }
}