using System.Collections.Generic;

namespace InredningOnline.Models
{
    public class MockUserRepo
    {
        // Fields
        List<User> _allUsers = new List<User>();

        // Properties
        public List<User> AllUsers { get => _allUsers; private set => _allUsers = value; }
        
        // Methods
        public User GetUserByName(string name)
        {
            return this.AllUsers.Find(u => u.Name == name);
        }

        public void SetUser(User user)
        {
            this.AllUsers.Add(user);
        }
    }
}