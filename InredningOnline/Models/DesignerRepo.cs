using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class DesignerRepo : IDesignerRepo
    {
        AppDbContext _appDbContext;

        public DesignerRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Designer> AllDesigners
        {
            get
            {
                return _appDbContext.Designers;
            }
        }

        public Designer GetDesignerByName(string name)
        {
            return _appDbContext.Designers.FirstOrDefault(u => u.Name == name);
        }

        public void SaveDesigner(string name, string email, bool isAdmin)
        {
            var designer = new Designer()
            {

                Name = name,
                Email = email,
                IsAdmin = isAdmin
            };
            _appDbContext.Add(designer);
            _appDbContext.SaveChanges();
        }

        public Designer GetDesignerById(int id)
        {
            return _appDbContext.Designers.FirstOrDefault(d => d.Id == id);
        }
        public bool CompareEmail(string email)
        {
            var test = new List<bool>();
            foreach (var designer in _appDbContext.Designers)
            {
                if (designer.Email == email)
                {
                    test.Add(true);
                }
                else
                {
                    test.Add(false);
                }
            }

            if (test.Contains(true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}