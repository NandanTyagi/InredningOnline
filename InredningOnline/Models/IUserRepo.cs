using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IUserRepo
    {
        IEnumerable<User> AllDesigners { get; }
        User GetUserByName(string name);
        // void SetUser(string name, string email, bool isAdmin);
    }
}