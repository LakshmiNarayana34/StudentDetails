namespace MyApp.Model
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        IEnumerable<User> GetAll();

        void AddUser(User user1);
        void UpdateUser(int id,User user1);
        void DeleteUser(int UserId);
    }
}
