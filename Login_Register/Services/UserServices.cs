using Login_Register.Models;
using Login_Register.Repositry;

namespace Login_Register.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserReposirty repo;
        public UserServices(IUserReposirty repo)
        {
            this.repo = repo;
        }

        public int AddUsers(User users)
        {
            return repo.AddUsers(users);
        }

        public int DeleteUsers(int id)
        {
            return repo.DeleteUsers(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAllUsers();
        }

        public User GetUsersById(int id)
        {
            return repo.GetUsersById(id);
        }

        public User Login(User users)
        {
            return repo.Login(users);
        }

        public int UpdateUsers(User users)
        {
            return repo.UpdateUsers(users);
        }
    }
}
