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

        public IEnumerable<User> AllDesigners
        {
            get
            {
                return _appDbContext.Designers;
            }
        }

        public User GetUserByName(string name)
        {
            return _appDbContext.Designers.FirstOrDefault(u => u.Name == name);
        }

        public void SaveUser(string name, string email, bool isAdmin)
        {
            var user = new User()
            {

                Name = name,
                Email = email,
                IsAdmin = isAdmin
            };
            _appDbContext.Add(user);
            _appDbContext.SaveChanges();
        }
    }
}