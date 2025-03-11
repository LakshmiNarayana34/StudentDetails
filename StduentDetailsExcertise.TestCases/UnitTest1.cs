using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using StudentDetailsExcersie.Controllers;
using StudentDetailsExcersie.Data;
using StudentDetailsExcersie.Dtos;
using StudentDetailsExcersie.Mapping;
using StudentDetailsExcersie.Model;
using StudentDetailsExcersie.Repositories;

namespace TestProject4.Controller
{
    public class UnitTest1
    {
        private readonly Mock<IStudentRepository> studentRepositoryMock;
        private readonly StudentDataController studentDataController;
        private readonly IMapper mapper;



        public UnitTest1()
        {
            studentRepositoryMock = new Mock<IStudentRepository>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMappingProfiles>();
            });
            mapper = config.CreateMapper();
            studentDataController = new StudentDataController(mapper, studentRepositoryMock.Object);// create implementation in memory



        }
        [Fact]
        public async Task GetUserById_ReturnsUser()
        {
            //Arrange
            int id = 1;
            studentRepositoryMock.Setup(repo => repo.GetById(id)).ReturnsAsync((Student)null);

            //Act
            var result = await studentRepositoryMock.Object.GetById(id);
            //Assert
            Assert.Null(result);
        }
        [Fact]
        public async Task GetUser_ReturnsUser()
        {
            //Arrange
            int id = 1;
            List<Student> students = new List<Student>();

            studentRepositoryMock.Setup(repo => repo.GetAll()).ReturnsAsync(students);

            //Act
            var result = await studentDataController.GetStudent();
            //Assert
            Assert.IsType<ActionResult<IEnumerable<Student>>>(result);
        }

        [Fact]
        public async Task StudentByIdReturnsTrue()
        {
            //Arrange
            int id = 2;
            Student students = new Student();
            studentRepositoryMock.Setup(x => x.GetById(id)).ReturnsAsync(students);
            //Act
            var result = await studentDataController.GetById(id);
            //Assert
            //Assert.Equal(id, result.Id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task StudentByIdReturnsNotFound()
        {
            //Arrange
            int id = 2;
            Student students = new();
            studentRepositoryMock.Setup(x => x.GetById(id));
            //Act
            var result = await studentDataController.GetById(id);
            //Assert
            //Assert.Equal(id, result.Id);
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task GetStudent_ShouldReturnOkResponse_WhenDataFound()
        {
            //Arrange
            List<Student> student = new List<Student>();
            studentRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(student);

            //Act
            var result = await studentDataController.GetStudent();

            //Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<ActionResult<IEnumerable<Student>>>();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            studentRepositoryMock.Verify(x => x.GetAll(), Times.Once());



        }

        [Fact]
        public async Task GetStudent_ShouldReturnNotFound_WhenDataNotFound()
        {
            //Arrange
            List<Student> Student = null;
            studentRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(Student);

            //Act
            var result = await studentDataController.GetStudent();

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundObjectResult>();
            studentRepositoryMock.Verify(x => x.GetAll(), Times.Exactly(1));
        }

        [Fact]
        public async Task GetById_ShouldReturnOkResponse_WhenValidInput()
        {
            //Arrange
            Student student = new Student();
            studentRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).ReturnsAsync(student);

            //Act
            var result = studentDataController.GetById(It.IsAny<int>());

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            studentRepositoryMock.Verify(x => x.GetById(It.IsAny<int>()), Times.Exactly(1));

        }

        [Fact]
        public async Task GetById_ShouldReturnNotFound_WhenDataNotFound()
        {
            //Arrange
            int id = 9;
            Student student = new Student();
            studentRepositoryMock.Setup(x => x.GetById(id)).ReturnsAsync(student);

            //Act
            var result = studentDataController.GetById(id);

            //Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundObjectResult>();
        }

        [Fact]
        public async Task GetById_ShouldReturnBadRequest_WhenInputIsEqualsZero()
        {
            //Arrange
            int id = 0;
            Student student = new Student();
            studentRepositoryMock.Setup(x => x.GetById(id)).ReturnsAsync(student);

            //Act
            var result = await studentDataController.GetById(id);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestResult>();
        }

        [Fact]
        public async Task GetById_ShouldReturnBadRequest_WhenInputLessThanZero()
        {
            //Arrange
            int id = int.MinValue;
            Student student = new Student();
            studentRepositoryMock.Setup(x => x.GetById(id)).ReturnsAsync(student);

            //Act
            var result = await studentDataController.GetById(id);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestResult>();
        }

        [Fact]
        public async Task CreateStudentDetails_ShouldReturnOkResponse_WhenValidRequest()
        {
            //Arrange
            //Request
            var student = new Student();
            //Response
            var createStudentDataDto = new CreateStudentDataDto();
            studentRepositoryMock.Setup(x => x.CreateStudent(student)).ReturnsAsync(student);

            //Act
            var result = await studentDataController.CreateStudentDetails(createStudentDataDto);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<OkObjectResult>();
        }

        [Fact]
        public async Task CreateStudentDetails_ShouldReturnBadRequest_WhenInValidRequest()
        {
            //Arrange

            //Request
            var student = new Student();

            //Response
            var createStudentDto = new CreateStudentDataDto()
            {
                FirstName = null
            };

            studentRepositoryMock.Setup(x => x.CreateStudent(student)).ReturnsAsync(student);

            //Act
            var result = await studentDataController.CreateStudentDetails(createStudentDto);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestResult>();

        }


    }
}