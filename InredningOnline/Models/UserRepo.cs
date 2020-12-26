using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class UserRepo : IUserRepo
    {
        AppDbContext _appDbContext;

        public UserRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> AllUsers
        {
            get
            {
                return _appDbContext.Users;
            }
        }

        public User GetUserByName(string name)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Name == name);
        }

        // public void SetUser(string name, string email, bool isAdmin)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}