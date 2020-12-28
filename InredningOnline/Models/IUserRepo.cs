using System.Collections.Generic;

namespace InredningOnline.Models
{
    public interface IDesignerRepo
    {
        IEnumerable<Designer> AllDesigners { get; }
        Designer GetDesignerByName(string name);
        // void SetDesigner(string name, string email, bool isAdmin);
    }
}