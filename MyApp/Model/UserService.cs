
namespace MyApp.Model
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> GetAll()
        {
           return userRepository.GetAll();
        }
        public User GetUserById(int id)
        {
           return userRepository.GetUserById(id);
        }
        public void AddUser(User user1)
        {
            userRepository.AddUser(user1);
        }

        public void DeleteUser(int UserId)
        {
            userRepository.DeleteUser(UserId);
        }
        public void UpdateUser(int id, User user1)
        {
            userRepository.UpdateUser(id, user1);
        }
    }
}
