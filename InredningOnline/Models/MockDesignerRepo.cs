using System.Collections.Generic;
using System.Linq;
namespace InredningOnline.Models
{

    public class MockDesignerRepo : IDesignerRepo
    {

        public IEnumerable<Designer> AllDesigners =>
        new List<Designer>
        {
            new Designer(){Id= 1, Name = "Nandan", Email = "me@nandan.com", IsAdmin = true},
            new Designer(){Id = 2, Name = "Hadis", Email = "me@hadis.com", IsAdmin = false},
            new Designer(){Id = 3, Name = "Ali", Email = "me@ali.com", IsAdmin = false}

        };

        public Designer GetDesignerByName(string name)
        {
            return this.AllDesigners.ToList().Find(u => u.Name == name);
        }

        public void SetDesigner(string name, string email, bool isAdmin)
        {
            this.AllDesigners.Append<Designer>(new Designer() { Name = name, Email = email, IsAdmin = isAdmin });
        }

        bool IDesignerRepo.CompareEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        Designer IDesignerRepo.GetDesignerById(int id)
        {
            return this.AllDesigners.FirstOrDefault(d => d.Id == id);
        }

    }
}