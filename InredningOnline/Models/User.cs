using System;

namespace InredningOnline.Models
{
    public class User
    {
        public User(MockUserRepo mockUserRepo, string name, string email, bool isAdmin)
        {
            // this.Id = Guid.NewGuid();

            mockUserRepo.SetUser(this);
            this.Id = mockUserRepo.AllUsers.Count;
            Name = name;
            Email = email;
            IsAdmin = isAdmin;
        }
        
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool IsAdmin { get; private set; }
    }
}