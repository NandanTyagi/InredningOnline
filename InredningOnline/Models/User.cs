using System;
using System.Collections.Generic;

namespace InredningOnline.Models
{
    public class User
    {
        public User(string name, string email, bool isAdmin)
        {
            // this.Id = Guid.NewGuid(); 
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