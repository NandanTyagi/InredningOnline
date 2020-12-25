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
            new User("Nandan", "me@nandan.com", true),
            new User("Hadis", "me@hadis.com", false),
            new User("Ali", "me@ali.com", false)
        };

        public User GetUserByName(string name)
        {
            return this.AllUsers.ToList().Find(u => u.Name == name);
        }

        public void SetUser(string name, string email, bool isAdmin)
        {
            this.AllUsers.Append<User>(new User(name, email, isAdmin));
        }
    }
}