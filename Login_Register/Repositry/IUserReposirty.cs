using Login_Register.Models;

namespace Login_Register.Repositry
{
    public interface IUserReposirty
    {
        IEnumerable<User> GetAllUsers();
        User GetUsersById(int id);
        int AddUsers(User users);
        int UpdateUsers(User users);
        int DeleteUsers(int id);

        User Login(User users);
    }
}
