using Login_Register.Data;
using Login_Register.Models;

namespace Login_Register.Repositry
{
    public class UserRepositry : IUserReposirty
    {
        private readonly ApplicationDbContext db;
        public UserRepositry(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddUsers(User users)
        {
            db.Users.Add(users);
            int res = db.SaveChanges();
            return res;
        }

        public int DeleteUsers(int id)
        {
            int res = 0;
            var result = db.Users.Where(u => u.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Users.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public User GetUsersById(int id)
        {
            var result = db.Users.Where(u => u.Id == id).FirstOrDefault();
            return result;
        }

        public User Login(User users)
        {
            var result = db.Users
                         .Where(u => u.UserName == users.UserName && u.Password == users.Password)
                         .FirstOrDefault();
            return result;
        }

        public int UpdateUsers(User users)
        {
            int res = 0;
            var result = db.Users.Where(u => u.Id == users.Id).FirstOrDefault();
            if (result != null)
            {
                result.FirstName = users.FirstName;
                result.LastName = users.LastName;
                result.UserName = users.UserName;
                result.Email = users.Email;
                result.Password = users.Password;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
