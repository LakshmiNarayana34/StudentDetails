
namespace MyApp.Model
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> user;
        public UserRepository() 
        {
            user = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name ="Lakshmi Narayana",
                    Email = "lachinandam01@gmail.com"
                },
                new User()
                {
                    Id = 2,
                    Name = "Ravi Teja",
                    Email = "ravi@gmail.com"
                },
                new User()
                {
                    Id = 3,
                    Name ="Narayana",
                    Email ="narayana@gmail.com"
                }
            };
        }
        public IEnumerable<User> GetAll()
        {
           return user;
        }
        public User GetUserById(int id)
        {
          return user.FirstOrDefault(user => user.Id == id);
           
        }
        public void AddUser(User user1)
        {
           user.Add(user1);
        }

        public void DeleteUser(int UserId)
        {
           var deleteUser = user.FirstOrDefault(x => x.Id == UserId);
            if (deleteUser != null)
            {
                user.Remove(deleteUser);
            }
            
        }

        public void UpdateUser(int id,User user1)
        {
           var userUpdate = user.FirstOrDefault(x => x.Id == id);
            if (userUpdate != null) 
            {
                userUpdate.Id = user1.Id;
                userUpdate.Name = user1.Name;
                userUpdate.Email = user1.Email;
            }

        }
    }
}
