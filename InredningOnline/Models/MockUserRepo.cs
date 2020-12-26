using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace InredningOnline.Models
{

    public class MockUserRepo : IUserRepo
    {
        //     // Fields
        //     public List<User> AllUsers => new List<User>
        //     {
        //         new User("Nandan", "me@nandan.com", true),
        //         new User("Hadis", "me@hadis.com", false)
        //     };

        //     // Properties
        //     // public List<User> AllUsers { get => _allUsers; private set => _allUsers = value; }



        //     // Methods
        //     public User GetUserByName(string name)
        //     {
        //         return this.AllUsers.Find(u => u.Name == name);
        //     }

        //     public void SetUser(User user)
        //     {
        //         this.AllUsers.Add(user);
        //     }
        // }
        public IEnumerable<User> AllUsers =>
        new List<User>
        {
            new User(){Name = "Nandan", Email = "me@nandan.com", IsAdmin = true},
            new User(){Name = "Hadis", Email = "me@hadis.com", IsAdmin = false},
            new User(){Name = "Ali", Email = "me@ali.com", IsAdmin = false}
            
        };

        public User GetUserByName(string name)
        {
            return this.AllUsers.ToList().Find(u => u.Name == name);
        }

        public void SetUser(string name, string email, bool isAdmin)
        {
            this.AllUsers.Append<User>(new User() { Name = name, Email = email, IsAdmin = isAdmin });
        }
    }
}