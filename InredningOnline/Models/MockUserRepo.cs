using System.Collections.Generic;
using System.Linq;
namespace InredningOnline.Models
{

    public class MockDesignerRepo : IDesignerRepo
    {

        public IEnumerable<Designer> AllDesigners =>
        new List<Designer>
        {
            new Designer(){Name = "Nandan", Email = "me@nandan.com", IsAdmin = true},
            new Designer(){Name = "Hadis", Email = "me@hadis.com", IsAdmin = false},
            new Designer(){Name = "Ali", Email = "me@ali.com", IsAdmin = false}

        };

        public Designer GetDesignerByName(string name)
        {
            return this.AllDesigners.ToList().Find(u => u.Name == name);
        }

        public void SetDesigner(string name, string email, bool isAdmin)
        {
            this.AllDesigners.Append<Designer>(new Designer() { Name = name, Email = email, IsAdmin = isAdmin });
        }
    }
}