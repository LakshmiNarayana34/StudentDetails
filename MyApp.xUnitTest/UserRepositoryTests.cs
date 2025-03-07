using Moq;
using MyApp.Model;
namespace MyApp.xUnitTest
{
    public class UserRepositoryTests
    {
        private readonly UserRepository _userRepository;
        public UserRepositoryTests()
        {
            _userRepository = new UserRepository();
        }

        [Fact]
        public void GetUserById_ReturnsCorrectUser()
        {
            //Arrange

            var userId = 1;

            //Act
            var result = _userRepository.GetUserById(userId);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(userId, result.Id);
        }

        // Test to verify that GetUserById returns null when the user is not found
        [Fact]
        public void GetUserById_ReturnsNullWhenUserNotFound()
        {
            //Arrange
            // Arrange
            // Assuming this ID does not exist
            var userId = 99;

            //Act
           var result = _userRepository.GetUserById(userId);

            //Assert
            // Check that result is null
            Assert.Null(result);

        }

        [Fact]
        // Test to verify that GetAllUsers returns all users
        public void GetAllUsers_ReturnsAllUsers()
        {
            //Arrange
            var result = _userRepository.GetAll();
            //Act
            //result is not null
            Assert.NotNull(result);
            //Assert
            //should be equal total count
            Assert.Equal(2, result.Count());
        }

        // Test to verify that AddUser adds a user correctly
        [Fact]
        public void AddUser_AddsUserCorrectly()
        {
            //Arrange
            var addingUser = new User { Id = 4, Name = "hemanth", Email = "hemanth@gmail.com" };
            
            //Act
           _userRepository.AddUser(addingUser);
           var result = _userRepository.GetUserById(4);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(addingUser.Id, result.Id);
            Assert.Equal(addingUser.Name, result.Name);
            Assert.Equal(addingUser.Email, result.Email);

        }

    }
}