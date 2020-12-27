using System.Collections.Generic;
using System.Linq;
namespace InredningOnline.Models
{

    public class MockUserRepo : IUserRepo
    {

        public IEnumerable<User> AllDesigners =>
        new List<User>
        {
            new User(){Name = "Nandan", Email = "me@nandan.com", IsAdmin = true},
            new User(){Name = "Hadis", Email = "me@hadis.com", IsAdmin = false},
            new User(){Name = "Ali", Email = "me@ali.com", IsAdmin = false}

        };

        public User GetUserByName(string name)
        {
            return this.AllDesigners.ToList().Find(u => u.Name == name);
        }

        public void SetUser(string name, string email, bool isAdmin)
        {
            this.AllDesigners.Append<User>(new User() { Name = name, Email = email, IsAdmin = isAdmin });
        }
    }
}