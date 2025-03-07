using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MyApp.Model;

namespace MyApp.xUnitTest
{
    public class UserServiceTests
    {
        // Instance of the service being tested
        private readonly UserService _demoService;
        // Mock instance of the repository
        private readonly Mock<IUserRepository> _mockRepository;
        // Constructor to initialize mock repository and the service
        public UserServiceTests()
        {
            _mockRepository = new Mock<IUserRepository>();
            _demoService = new UserService(_mockRepository.Object);
        }
        // Test to verify that GetUserById returns the correct user
        [Fact]
        public void GetUserById_ReturnsUser()
        {
            // Arrange
            var userId = 1;
            var expectedUser = new User { Id = 1, Name = "John Doe", Email = "john@example.com" };
            _mockRepository.Setup(repo => repo.GetUserById(userId)).Returns(expectedUser);
            // Act
            var result = _demoService.GetUserById(userId);
            // Assert
            Assert.NotNull(result); // Check that the result is not null
            Assert.Equal(expectedUser.Id, result.Id); // Check that the ID is correct
            Assert.Equal(expectedUser.Name, result.Name); // Check that the name is correct
            Assert.Equal(expectedUser.Email, result.Email); // Check that the email is correct
        }
        // Test to verify that GetUserById returns null when the user is not found
    }
}
